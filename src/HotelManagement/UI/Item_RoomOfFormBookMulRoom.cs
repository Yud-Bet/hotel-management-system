using System;
using System.Drawing;
using System.Windows.Forms;
using HotelManagement.Properties;

namespace HotelManagement.UI
{
    public partial class Item_RoomOfFormBookMulRoom : UserControl
    {
        public Item_RoomOfFormBookMulRoom(Item_Room parentRefItemRoom, Form_BookMulRooms parentRefBookMulRoom)
        {
            InitializeComponent();
            this.ParentRefBookMulRoom = parentRefBookMulRoom;
            this.ParentRefItemRoom = parentRefItemRoom;

            this._RoomID = this.ParentRefItemRoom._RoomID;
            this._RoomStatus = this.ParentRefItemRoom._RoomStatus;
            this._RoomType = this.ParentRefItemRoom._RoomType;
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
        public bool isChoose = false;
        public Item_Room ParentRefItemRoom;
        public Form_BookMulRooms ParentRefBookMulRoom;

        /// <summary>
        /// RoomType: 1.Single-Vip 2.Double-Vip 3.Single-Normal 4.Double-Normal
        /// </summary>
        private RoomType roomType;

        public RoomType _RoomType
        {
            get { return roomType; }
            set
            {
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
            set
            {
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
            set
            {
                RoomID = value;
                lbRoomID.Text = RoomID.ToString();
            }
        }


        #endregion

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

        private void pbRoomType_Click(object sender, EventArgs e)
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
                    this._RoomStatus = RoomStatus.Empty;
                    this.ParentRefItemRoom._RoomStatus = RoomStatus.Empty;
                    this.ParentRefItemRoom.ParentRef.Empty = this.ParentRefItemRoom.ParentRef.Empty + 1;
                    this.ParentRefItemRoom.ParentRef.Cleaning = this.ParentRefItemRoom.ParentRef.Cleaning - 1;

                    DataAccess.RoomDA.SetRoomStatus(RoomID, RoomStatus.Empty);
                }
            }

            if (!isChoose)
            {
                this.ParentRefBookMulRoom._pnSeletedRoom.Controls.Add(this);
                isChoose = true;
                this.ParentRefBookMulRoom._emtyCount--;
                this.ParentRefBookMulRoom._selectedCount++;
            }
            else
            {
                this.ParentRefBookMulRoom._pnToSelectRoom.Controls.Add(this);
                isChoose = false;
                this.ParentRefBookMulRoom._emtyCount++;
                this.ParentRefBookMulRoom._selectedCount--;
            }
        }
    }
}
