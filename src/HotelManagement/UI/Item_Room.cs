using System;
using System.Drawing;
using System.Windows.Forms;
using HotelManagement.Properties;
using System.Threading.Tasks;

namespace HotelManagement.UI
{
    public partial class Item_Room : UserControl
    {
        public Item_Room(Form_Room parent)
        {
            InitializeComponent();
            this.ParentRef = parent;
        }

        #region Icon
        private static Bitmap VIPIcon = Resources.icVip;
        private static Bitmap SingleIcon = Resources.icSingleRoom;
        private static Bitmap DoubleIcon = Resources.icDoubleRoom;
        private static Bitmap YesIcon = Resources.icYes;
        private static Bitmap SingleRentedIcon = Resources.icRented_SR;
        private static Bitmap DoubleRentedIcon = Resources.icRented_DB;
        private static Bitmap RepairingIcon = Resources.icFix;
        private static Bitmap CleaningIcon = Resources.icClean;
        #endregion

        #region Properties
        public Form_Room ParentRef;

        /// <summary>
        /// RoomType: 1.Single-Vip 2.Double-Vip 3.Single-Normal 4.Double-Normal
        /// </summary>
        private RoomType roomType;

        public RoomType _RoomType
        {
            get { return roomType; }
            set {
                roomType = value;
                switch (roomType)
                {
                    case RoomType.SingleVIP:
                        pbVip.Image = VIPIcon;
                        pbRoomType.Image = SingleIcon;
                        break;
                    case RoomType.DoubleVIP:
                        pbVip.Image = VIPIcon;
                        pbRoomType.Image = DoubleIcon;
                        break;
                    case RoomType.Single:
                        pbRoomType.Image = SingleIcon;
                        break;
                    case RoomType.Double:
                        pbRoomType.Image = DoubleIcon;
                        break;
                }
            }
        }
        /// <summary>
        /// Roomstatus: 1.Empty 2.Rented 3.Cleaning 4.Fixing
        /// </summary>
        private RoomStatus roomStatus;

        public RoomStatus _RoomStatus
        {
            get { return roomStatus; }
            set { 
                roomStatus = value;
                switch (value)
                {
                    case RoomStatus.Empty:
                        SetEmptyStatus();
                        break;
                    case RoomStatus.Rented:
                        SetRentedStatus();
                        break;
                    case RoomStatus.Cleaning:
                        SetCleaningStatus();
                        break;
                    case RoomStatus.Repairing:
                        SetFixingStatus();
                        break;
                }
            }
        }

        private int RoomID;

        public int _RoomID
        {
            get { return RoomID; }
            set { 
                RoomID = value;
                lbRoomID.Text = RoomID.ToString();
            }
        }


        #endregion

        private void Room_Load(object sender, EventArgs e)
        {
            pbShadow.Hide();
        }

        public void SetEmptyStatus()
        {
            lbRoomStatus.Text = "Còn trống";
            pbRoomStatus.Image = YesIcon;
            lbRoomStatus.BackColor = Color.FromArgb(216, 243, 220);
            pbRoomStatus.BackColor = Color.FromArgb(216, 243, 220);
            pnBackground.BackColor = Color.FromArgb(216, 243, 220);
            lbRoomID.BackColor = Color.FromArgb(216, 243, 220);
            label1.BackColor = Color.FromArgb(216, 243, 220);
            pnBar.BackColor = Color.FromArgb(116, 198, 157);
        }

        public void SetRentedStatus()
        {
            lbRoomStatus.Text = "Đã thuê";
            pbRoomStatus.Image = (roomType == RoomType.SingleVIP || roomType == RoomType.Single) ? SingleRentedIcon : DoubleRentedIcon;
            lbRoomStatus.BackColor = Color.FromArgb(255, 166, 193);
            pbRoomStatus.BackColor = Color.FromArgb(255, 166, 193);
            pnBackground.BackColor = Color.FromArgb(255, 166, 193);
            lbRoomID.BackColor = Color.FromArgb(255, 166, 193);
            label1.BackColor = Color.FromArgb(255, 166, 193);
            pnBar.BackColor = Color.FromArgb(255, 93, 143);
        }

        public void SetCleaningStatus()
        {
            lbRoomStatus.Text = "Đang dọn";
            pbRoomStatus.Image = CleaningIcon;
            lbRoomStatus.BackColor = Color.FromArgb(173, 232, 244);
            pbRoomStatus.BackColor = Color.FromArgb(173, 232, 244);
            pnBackground.BackColor = Color.FromArgb(173, 232, 244);
            lbRoomID.BackColor = Color.FromArgb(173, 232, 244);
            label1.BackColor = Color.FromArgb(173, 232, 244);
            pnBar.BackColor = Color.FromArgb(72, 202, 228);
        }

        public void SetFixingStatus()
        {
            lbRoomStatus.Text = "Đang sửa";
            pbRoomStatus.Image = RepairingIcon;
            lbRoomStatus.BackColor = Color.FromArgb(254, 251, 199);
            pbRoomStatus.BackColor = Color.FromArgb(254, 251, 199);
            pnBackground.BackColor = Color.FromArgb(254, 251, 199);
            lbRoomID.BackColor = Color.FromArgb(254, 251, 199);
            label1.BackColor = Color.FromArgb(254, 251, 199);
            pnBar.BackColor = Color.FromArgb(253, 246, 116);
        }

        private void pnBackground_MouseMove(object sender, MouseEventArgs e)
        {
            pbShadow.Show();
        }

        private void pnBackground_MouseLeave(object sender, EventArgs e)
        {
            pbShadow.Hide();
        }

        private async void pbRoomType_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEventArgs = (MouseEventArgs) e;
            this.ParentRef._lbRoomID.Text = lbRoomID.Text;
            if(mouseEventArgs.Button == MouseButtons.Right)
            {
                if (roomStatus != RoomStatus.Rented)
                    showMenu();
            }
            else
            {
                if (roomStatus == RoomStatus.Cleaning)
                {
                    DialogResult result = MessageBox.Show("Xác nhận đã dọn phòng xong?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        try
                        {
                            int RowsAffected = await Task.Run(() => {
                                try
                                {
                                    return DataAccess.RoomDA.SetRoomStatus(RoomID, RoomStatus.Empty);
                                }
                                catch
                                {
                                    return -2;
                                }
                            });
                            if (RowsAffected == -2) throw new Exception("Đã xảy ra lỗi khi kết nối tới server");

                            this._RoomStatus = RoomStatus.Empty;
                            this.ParentRef.Empty = this.ParentRef.Empty + 1;
                            this.ParentRef.Cleaning = this.ParentRef.Cleaning - 1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Lỗi");
                        }
                    }
                }

                if (roomStatus == RoomStatus.Repairing)
                {
                    DialogResult result = MessageBox.Show("Xác nhận đã sửa phòng xong?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        try
                        {
                            int RowsAffected = await Task.Run(() => {
                                try
                                {
                                    return DataAccess.RoomDA.SetRoomStatus(RoomID, RoomStatus.Empty);
                                }
                                catch
                                {
                                    return -2;
                                }
                            });
                            if (RowsAffected == -2) throw new Exception("Đã xảy ra lỗi khi kết nối tới server");

                            this._RoomStatus = RoomStatus.Empty;
                            this.ParentRef.Empty = this.ParentRef.Empty + 1;
                            this.ParentRef.Repairing = this.ParentRef.Repairing - 1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Lỗi");
                        }
                    }
                }

                Form_RoomInfo temp = new Form_RoomInfo(this);
                this.ParentRef._pnToAddARoomInfo.BringToFront();
                this.ParentRef._pnToAddARoomInfo.Controls.Add(temp);
            }
            
        }

        void showMenu()
        {
            RightClickMenu.Items[0].Visible = false;
            RightClickMenu.Items[1].Visible = false;
            RightClickMenu.Items[2].Visible = false;
            RightClickMenu.Items[3].Visible = false;

            if (this.roomStatus == RoomStatus.Cleaning)
            {
                RightClickMenu.Items[0].Visible = true;
                RightClickMenu.Items[3].Visible = true;
            }
            else if (this.roomStatus == RoomStatus.Repairing)
            {
                RightClickMenu.Items[1].Visible = true;
                RightClickMenu.Items[2].Visible = true;
            } else
            {
                RightClickMenu.Items[0].Visible = true;
                RightClickMenu.Items[2].Visible = true;
            }

            RightClickMenu.Show(MousePosition);
        }

        private async void menuItemRepairRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int RowsAffected = await Task.Run(() =>
                {
                    try
                    {
                        return DataAccess.RoomDA.SetRoomStatus(RoomID, RoomStatus.Repairing);
                    }
                    catch
                    {
                        return -2;
                    }
                });
                if (RowsAffected == -2) throw new Exception("Đã xảy ra lỗi khi kết nối tới server");

                if (roomStatus == RoomStatus.Empty)
                {
                    _RoomStatus = RoomStatus.Repairing;
                    ParentRef.Empty = ParentRef.Empty - 1;
                    ParentRef.Repairing = ParentRef.Repairing + 1;
                }
                else if (roomStatus == RoomStatus.Cleaning)
                {
                    _RoomStatus = RoomStatus.Repairing;
                    ParentRef.Cleaning = ParentRef.Cleaning - 1;
                    ParentRef.Repairing = ParentRef.Repairing + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private async void menuItemEndRepairRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int RowsAffected = await Task.Run(() =>
                {
                    try
                    {
                        return DataAccess.RoomDA.SetRoomStatus(RoomID, RoomStatus.Empty);
                    }
                    catch
                    {
                        return -2;
                    }
                });
                if (RowsAffected == -2) throw new Exception("Đã xảy ra lỗi khi kết nối tới server");

                _RoomStatus = RoomStatus.Empty;
                ParentRef.Repairing = ParentRef.Repairing - 1;
                ParentRef.Empty = ParentRef.Empty + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private async void menuItemCleanRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int RowsAffected = await Task.Run(() =>
                {
                    try
                    {
                        return DataAccess.RoomDA.SetRoomStatus(RoomID, RoomStatus.Cleaning);
                    }
                    catch
                    {
                        return -2;
                    }
                });
                if (RowsAffected == -2) throw new Exception("Đã xảy ra lỗi khi kết nối tới server");

                if (roomStatus == RoomStatus.Repairing)
                {
                    _RoomStatus = RoomStatus.Cleaning;
                    ParentRef.Repairing = ParentRef.Repairing - 1;
                    ParentRef.Cleaning = ParentRef.Cleaning + 1;
                }
                else if (roomStatus == RoomStatus.Empty)
                {
                    _RoomStatus = RoomStatus.Cleaning;
                    ParentRef.Empty = ParentRef.Empty - 1;
                    ParentRef.Cleaning = ParentRef.Cleaning + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private async void menuItemEndCleanRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int RowsAffected = await Task.Run(() =>
                {
                    try
                    {
                        return DataAccess.RoomDA.SetRoomStatus(RoomID, RoomStatus.Empty);
                    }
                    catch
                    {
                        return -2;
                    }
                });
                if (RowsAffected == -2) throw new Exception("Đã xảy ra lỗi khi kết nối tới server");

                _RoomStatus = RoomStatus.Empty;
                ParentRef.Cleaning = ParentRef.Cleaning - 1;
                ParentRef.Empty = ParentRef.Empty + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
