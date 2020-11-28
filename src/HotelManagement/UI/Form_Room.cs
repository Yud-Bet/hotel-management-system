using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Form_Room : UserControl
    {
        public Form_Room()
        {
            InitializeComponent();
            Load_Data();
            this.Dock = DockStyle.Fill;
            lbRoomID.Hide();
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
                Room newRoom = new Room(this);

                newRoom._RoomID = room.Rooms[i].ID;
                newRoom._RoomStatus = room.Rooms[i].Status;
                newRoom._RoomType = room.Rooms[i].Type;

                this.pnToAddRoom.Controls.Add(newRoom);
            }

            lbNumberOfEmptyRoom.Text = room.RoomCount[(int)RoomStatus.Empty].ToString();
            lbNumberOfRentedRoom.Text = room.RoomCount[(int)RoomStatus.Rented].ToString();
            lbNumberOfCleaningRoom.Text = room.RoomCount[(int)RoomStatus.Cleaning].ToString();
            lbNumberOfRepairingRoom.Text = room.RoomCount[(int)RoomStatus.Repairing].ToString();
        }
    }
}
