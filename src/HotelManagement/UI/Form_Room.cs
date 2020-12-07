using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Form_Room : UserControl
    {
        public string Username;
        public List<Item_Room> listRoom = new List<Item_Room>();
        public Form_Room(string Username)
        {
            InitializeComponent();
            Load_Data();
            this.Dock = DockStyle.Fill;
            this.Username = Username;
            lbRoomID.Hide();
            this.DoubleBuffered = true;
        }
        #region Properties
        public Label _lbRoomID
        {
            get { return lbRoomID; }
        }

        public Panel _pnToAddARoomInfo
        {
            get { return pnToAddARoomInfo; }
        }

        public FlowLayoutPanel _pnToAddARoom
        {
            get { return pnToAddRoom; }
        }

        public Label _lbNumberOfEmptyRoom
        {
            get { return lbNumberOfEmptyRoom; }
        }

        public Label _lbNumberOfRentedRoom
        {
            get { return lbNumberOfRentedRoom; }
        }

        public Label _lbNumberOfRepairingRoom
        {
            get { return lbNumberOfRepairingRoom; }
        }

        public Label _lbNumberOfCleaningRoom
        {
            get { return lbNumberOfCleaningRoom; }
        }

        public Label _lbNumberOfRoom
        {
            get { return lbNumberOfRoom; }
        }

        #endregion
        private void Load_Data()
        {
            DTO.RoomOverview room = new DTO.RoomOverview();
            lbNumberOfRoom.Text = room.RoomCount[0].ToString();
            for (int i = 0; i < room.RoomCount[0]; i++)
            {
                Item_Room newRoom = new Item_Room(this);

                newRoom._RoomID = room.Items[i].ID;
                newRoom._RoomStatus = room.Items[i].Status;
                newRoom._RoomType = room.Items[i].Type;

                this.listRoom.Add(newRoom);
                this.pnToAddRoom.Controls.Add(newRoom);
            }

            lbNumberOfEmptyRoom.Text = room.RoomCount[(int)RoomStatus.Empty].ToString();
            lbNumberOfRentedRoom.Text = room.RoomCount[(int)RoomStatus.Rented].ToString();
            lbNumberOfCleaningRoom.Text = room.RoomCount[(int)RoomStatus.Cleaning].ToString();
            lbNumberOfRepairingRoom.Text = room.RoomCount[(int)RoomStatus.Repairing].ToString();
        }

        private void btThreeDot_Click(object sender, System.EventArgs e)
        {
            if (animBookMulRooms.CordinateEnd_X == 100)
            {
                animBookMulRooms.Activate();
                animAddRoom.Activate();
                animPbSearch.Activate();
                timer1.Start();
                animBookMulRooms.CordinateEnd_X = 44;
                animBookMulRooms.CordinateStart_X = 100;
                animAddRoom.CordinateEnd_X = 44;
                animAddRoom.CordinateStart_X = 156;
                animPbSearch.CordinateEnd_X = 90;
                animPbSearch.CordinateStart_X = 202;
            }
            else
            {
                btAddRoom.Show();
                btBookMultipleRooms.Show();
                animBookMulRooms.Activate();
                animAddRoom.Activate();
                animPbSearch.Activate();
                animBookMulRooms.CordinateEnd_X = 100;
                animBookMulRooms.CordinateStart_X = 40;
                animAddRoom.CordinateEnd_X = 156;
                animAddRoom.CordinateStart_X = 38;
                animPbSearch.CordinateEnd_X = 202;
                animPbSearch.CordinateStart_X = 82;
            }
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            timer1.Stop();
            btAddRoom.Hide();
            btBookMultipleRooms.Hide();
        }

        private void btAddRoom_Click(object sender, System.EventArgs e)
        {
            btThreeDot_Click(sender, e);
            Form_AddEditRoom form_AddEditRoom = new Form_AddEditRoom();
            form_AddEditRoom.ShowDialog();
            
        }

        private void btBookMultipleRooms_Click(object sender, System.EventArgs e)
        {
            btThreeDot_Click(sender, e);
            Form_BookMulRooms temp = new Form_BookMulRooms(this);
            pnToAddARoomInfo.BringToFront();
            pnToAddARoomInfo.Controls.Add(temp);
            
        }
    }
}
