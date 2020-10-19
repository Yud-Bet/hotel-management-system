using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Properties;

namespace HotelManagement.UI
{
    public partial class Room : UserControl
    {
        public Room(Form_Room parent)
        {
            InitializeComponent();
            this.Parent = parent;
        }

        #region Properties
        public Form_Room Parent;

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
                        pbVip.Image = Resources.icVip;
                        pbRoomType.Image = Resources.icSingleRoom;
                        break;
                    case RoomType.DoubleVIP:
                        pbVip.Image = Resources.icVip;
                        pbRoomType.Image = Resources.icDoubleRoom;
                        break;
                    case RoomType.Single:
                        pbRoomType.Image = Resources.icSingleRoom;
                        break;
                    case RoomType.Double:
                        pbRoomType.Image = Resources.icDoubleRoom;
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
            pbRoomStatus.Image = Resources.icYes;
            lbRoomStatus.BackColor = Color.FromArgb(181, 235, 220);
            pbRoomStatus.BackColor = Color.FromArgb(181, 235, 220);
            pnBackground.BackColor = Color.FromArgb(181, 235, 220);
            lbRoomID.BackColor = Color.FromArgb(181, 235, 220);
            label1.BackColor = Color.FromArgb(181, 235, 220);
            pnBar.BackColor = Color.FromArgb(103, 222, 190); 
        }

        public void SetRentedStatus()
        {
            lbRoomStatus.Text = "Đã thuê";
            pbRoomStatus.Image = (roomType == RoomType.SingleVIP || roomType == RoomType.Single) ? Resources.icRented_SR : Resources.icRented_DB;
            lbRoomStatus.BackColor = Color.FromArgb(255, 200, 227);
            pbRoomStatus.BackColor = Color.FromArgb(255, 200, 227);
            pnBackground.BackColor = Color.FromArgb(255, 200, 227);
            lbRoomID.BackColor = Color.FromArgb(255, 200, 227);
            label1.BackColor = Color.FromArgb(255, 200, 227);
            pnBar.BackColor = Color.FromArgb(255, 113, 184);
        }

        public void SetCleaningStatus()
        {
            lbRoomStatus.Text = "Đang dọn";
            pbRoomStatus.Image = Resources.icClean;
            lbRoomStatus.BackColor = Color.FromArgb(150, 228, 252);
            pbRoomStatus.BackColor = Color.FromArgb(150, 228, 252);
            pnBackground.BackColor = Color.FromArgb(150, 228, 252);
            lbRoomID.BackColor = Color.FromArgb(150, 228, 252);
            label1.BackColor = Color.FromArgb(150, 228, 252);
            pnBar.BackColor = Color.FromArgb(0, 194, 255);
        }

        public void SetFixingStatus()
        {
            lbRoomStatus.Text = "Đang sửa";
            pbRoomStatus.Image = Resources.icFix;
            lbRoomStatus.BackColor = Color.FromArgb(247, 249, 194);
            pbRoomStatus.BackColor = Color.FromArgb(247, 249, 194);
            pnBackground.BackColor = Color.FromArgb(247, 249, 194);
            lbRoomID.BackColor = Color.FromArgb(247, 249, 194);
            label1.BackColor = Color.FromArgb(247, 249, 194);
            pnBar.BackColor = Color.FromArgb(244, 251, 53);  
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
            MouseEventArgs mouseEventArgs = (MouseEventArgs) e;
            if(mouseEventArgs.Button== MouseButtons.Right)
            {
                showMenu();
            } else
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
                        this.Parent._lbNumberOfEmptyRoom.Text = (Convert.ToInt32(this.Parent._lbNumberOfEmptyRoom.Text) + 1).ToString();
                        this.Parent._lbNumberOfCleaningRoom.Text = (Convert.ToInt32(this.Parent._lbNumberOfCleaningRoom.Text) - 1).ToString();
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
                        this._RoomStatus = RoomStatus.Empty;
                        this.Parent._lbNumberOfEmptyRoom.Text = (Convert.ToInt32(this.Parent._lbNumberOfEmptyRoom.Text) + 1).ToString();
                        this.Parent._lbNumberOfRepairingRoom.Text = (Convert.ToInt32(this.Parent._lbNumberOfRepairingRoom.Text) - 1).ToString();
                    }
                }

                Form_RoomInfo temp = new Form_RoomInfo(this);
                this.Parent._pnToAddARoomInfo.BringToFront();
                this.Parent._pnToAddARoomInfo.Controls.Add(temp);
            }
            
        }

        void showMenu()
        {
            zeroitMaterialContextMenuStrip1.Items[0].Visible = false;
            zeroitMaterialContextMenuStrip1.Items[1].Visible = false;
            zeroitMaterialContextMenuStrip1.Items[2].Visible = false;
            zeroitMaterialContextMenuStrip1.Items[3].Visible = false;

            if (this.roomStatus == RoomStatus.Cleaning)
            {
                zeroitMaterialContextMenuStrip1.Items[0].Visible = true;
                zeroitMaterialContextMenuStrip1.Items[3].Visible = true;
            }
            else if (this.roomStatus == RoomStatus.Repairing)
            {
                zeroitMaterialContextMenuStrip1.Items[1].Visible = true;
                zeroitMaterialContextMenuStrip1.Items[2].Visible = true;
            } else
            {
                zeroitMaterialContextMenuStrip1.Items[0].Visible = true;
                zeroitMaterialContextMenuStrip1.Items[2].Visible = true;
            }

            zeroitMaterialContextMenuStrip1.Show(MousePosition);
        }

    }
}
