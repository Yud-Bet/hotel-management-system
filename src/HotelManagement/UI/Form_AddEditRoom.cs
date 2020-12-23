using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HotelManagement.UI
{
    public partial class Form_AddEditRoom : MetroFramework.Forms.MetroForm
    {
        private bool IsProcessing = false;
        private int roomID;
        private int roomSize;
        private int price;
        private RoomType type;

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
        }

        public Form_AddEditRoom()
        {
            InitializeComponent();
            tbRoomID.Enabled = true;
        }

        private async void btSave_Click(object sender, EventArgs e)
        {
            if (!IsProcessing)
            {
                IsProcessing = true;
                tbRoomPrice.Enabled = false;
                tbRoomSize.Enabled = false;
                rbtDouble.Enabled = rbtSingle.Enabled = rbtNor.Enabled = rbtVip.Enabled = false;
                if (!checkEmptyValue())
                {
                    IsProcessing = false;
                    tbRoomSize.Enabled = true;
                    tbRoomPrice.Enabled = true;
                    rbtDouble.Enabled = rbtSingle.Enabled = rbtNor.Enabled = rbtVip.Enabled = true;
                    return;
                }
                if (!checkValidityOfValue())
                {
                    IsProcessing = false;
                    tbRoomSize.Enabled = true;
                    tbRoomPrice.Enabled = true;
                    rbtDouble.Enabled = rbtSingle.Enabled = rbtNor.Enabled = rbtVip.Enabled = true;
                    return;
                }
                try
                {
                    RoomSize = Convert.ToInt32(tbRoomSize.Text);
                    Price = Convert.ToInt32(tbRoomPrice.Text);
                    Type = GetValueOfControl.GetRoomType(rbtNor, rbtVip, rbtSingle, rbtDouble);

                    int RowsAffected = await Task.Run(() => DataAccess.RoomDA.EditRoomInfo(Convert.ToInt32(tbRoomID.Text),
                        Type, RoomSize, Price));

                    if (RowsAffected > 0) DialogResult = DialogResult.OK;

                    this.Close();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Lỗi khi kết nối đến server!", "Lỗi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    IsProcessing = false;
                    tbRoomSize.Enabled = true;
                    tbRoomPrice.Enabled = true;
                    rbtDouble.Enabled = rbtSingle.Enabled = rbtNor.Enabled = rbtVip.Enabled = true;
                }
            }
            else MessageBox.Show("Từ từ đừng vội~", "Thông báo");
        }

        bool checkEmptyValue()
        {
            if (tbRoomID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbRoomID.Focus();
                return false;
            }

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
            if(!Regex.IsMatch(tbRoomID.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Mã phòng là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbRoomID.Focus();
                return false;
            }

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
