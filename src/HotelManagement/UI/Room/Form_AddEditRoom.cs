using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Data;

namespace HotelManagement.UI
{
    public partial class Form_AddEditRoom : MetroFramework.Forms.MetroForm
    {
        private int roomID;
        private int roomSize;
        private int price;
        private RoomType type;
        private Form_Room parentRef;
        private CancellationTokenSource cts;


        public int RoomID
        {
            get { return roomID; }
            set
            {
                roomID = value;
                tbRoomID.Text = roomID.ToString();
            }
        }
        public int RoomSize
        {
            get { return roomSize; }
            set
            {
                roomSize = value;
                tbRoomSize.Text = roomSize.ToString();
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                tbRoomPrice.Text = price.ToString();
            }
        }
        public RoomType Type
        {
            get { return type; }
            set
            {
                type = value;
                SetValueForControl.SetRoomType(type, rbtNor, rbtVip, rbtSingle, rbtDouble);
            }
        }

        public XanderUI.XUIButton _btAdd
        {
            get { return btAddRoom; }
        }

        public XanderUI.XUIButton _btSave
        {
            get { return btSave; }
        }

        public Form_AddEditRoom(DTO.RoomDetail room)
        {
            InitializeComponent();
            RoomID = room.ID;
            RoomSize = room.Size;
            Price = room.Price;
            Type = room.Type;

            cts = new CancellationTokenSource();
        }

        public Form_AddEditRoom(Form_Room parentRef)
        {
            InitializeComponent();
            tbRoomID.Enabled = false;
            this.parentRef = parentRef;
            cts = new CancellationTokenSource();
        }

        private async void btAddRoom_Click(object sender, EventArgs e)
        {
            if (!checkEmptyValue())
            {
                return;
            }
            if (!checkValidityOfValue())
            {
                return;
            }
            try
            {
                OverlayForm overlay = new OverlayForm(this, new LoadingForm(cts.Token));
                overlay.Show();
                RoomSize = Convert.ToInt32(tbRoomSize.Text);
                Price = Convert.ToInt32(tbRoomPrice.Text);
                Type = GetValueOfControl.GetRoomType(rbtNor, rbtVip, rbtSingle, rbtDouble);

                int RowsAffected = await Task.Run(() => {
                    try
                    {
                        return DataAccess.RoomDA.AddNewRoom(Type, RoomSize);
                    }
                    catch
                    {
                        return -2;
                    }
                });
                if (RowsAffected == -2) throw new Exception("Lỗi khi kết nối đến server!");
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Thêm phòng mới thành công!", "Thông báo!");
                    DataTable idNewRoom = DataAccess.RoomDA.GetRoomIdOfNewRoom();
                    if (idNewRoom.Rows.Count > 0)
                    {
                        DataTable data = DataAccess.RoomDA.GetRoomInfo(Convert.ToInt32(idNewRoom.Rows[0].ItemArray[0]));
                        if (data.Rows.Count > 0)
                        {
                            Item_Room newRoom = new Item_Room(parentRef);
                            newRoom._RoomID = Convert.ToInt32(idNewRoom.Rows[0].ItemArray[0]);
                            newRoom._RoomStatus = (RoomStatus)(Convert.ToInt32(data.Rows[0].ItemArray[3]));
                            newRoom._RoomType = (RoomType)(Convert.ToInt32(data.Rows[0].ItemArray[0]));

                            this.parentRef._pnToAddARoom.Controls.Add(newRoom);
                        }
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
            }
        }
        private async void btSave_Click(object sender, EventArgs e)
        {
            if (!checkEmptyValue())
            {
                return;
            }
            if (!checkValidityOfValue())
            {
                return;
            }
            try
            {
                OverlayForm overlay = new OverlayForm(this, new LoadingForm(cts.Token));
                overlay.Show();
                RoomSize = Convert.ToInt32(tbRoomSize.Text);
                Price = Convert.ToInt32(tbRoomPrice.Text);
                Type = GetValueOfControl.GetRoomType(rbtNor, rbtVip, rbtSingle, rbtDouble);

                int RowsAffected = await Task.Run(() => {
                    try
                    {
                        return DataAccess.RoomDA.EditRoomInfo(Convert.ToInt32(tbRoomID.Text),
                                Type, RoomSize, Price);
                    }
                    catch
                    {
                        return -2;
                    }
                });
                if (RowsAffected == -2) throw new Exception("Lỗi khi kết nối đến server!");
                if (RowsAffected > 0) DialogResult = DialogResult.OK;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
            }
        }

        bool checkEmptyValue()
        {
            //if (tbRoomID.Text == "")
            //{
            //    MessageBox.Show("Vui lòng nhập số phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    tbRoomID.Focus();
            //    return false;
            //}

            if(!rbtVip.Checked && !rbtNor.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại phòng Vip hoặc Thường.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!rbtSingle.Checked && !rbtDouble.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại phòng Đơn hoặc Đôi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (tbRoomSize.Text == "")
            {
                MessageBox.Show("Vui lòng nhập diện tích phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbRoomSize.Focus();
                return false;
            }

            if (tbRoomPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbRoomPrice.Focus();
                return false;
            }

            return true;
        }

        bool checkValidityOfValue()
        {
            //if(!Regex.IsMatch(tbRoomID.Text, @"^[0-9]+$"))
            //{
            //    MessageBox.Show("Mã phòng là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    tbRoomID.Focus();
            //    return false;
            //}

            if (!Regex.IsMatch(tbRoomSize.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Diện tích phòng là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbRoomSize.Focus();
                return false;
            }

            if (!Regex.IsMatch(tbRoomPrice.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Giá phòng là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbRoomPrice.Focus();
                return false;
            }

            return true;
        }

        private void Form_AddEditRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel4.Dispose();
            System.GC.Collect();
        }

    }
}
