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

        private int total;
        private int rented;
        private int empty;
        private int repairing;
        private int cleaning;
        public int Total
        {
            get { return total; }
            set
            {
                total = value;
                lbNumberOfRoom.Text = total.ToString();
            }
        }
        public int Empty
        {
            get { return empty; }
            set
            {
                empty = value;
                lbNumberOfEmptyRoom.Text = empty.ToString();
            }
        }
        public int Rented
        {
            get { return rented; }
            set
            {
                rented = value;
                lbNumberOfRentedRoom.Text = rented.ToString();
            }
        }
        public int Cleaning
        {
            get { return cleaning; }
            set
            {
                cleaning = value;
                lbNumberOfCleaningRoom.Text = cleaning.ToString();
            }
        }
        public int Repairing
        {
            get { return repairing; }
            set
            {
                repairing = value;
                lbNumberOfRepairingRoom.Text = repairing.ToString();
            }
        }

        #endregion
        private void Load_Data()
        {
            DTO.RoomOverview room = new DTO.RoomOverview();
            Total = room.RoomCount[0];
            for (int i = 0; i < room.RoomCount[0]; i++)
            {
                Item_Room newRoom = new Item_Room(this);

                newRoom._RoomID = room.Items[i].ID;
                newRoom._RoomStatus = room.Items[i].Status;
                newRoom._RoomType = room.Items[i].Type;

                this.listRoom.Add(newRoom);
                this.pnToAddRoom.Controls.Add(newRoom);
            }

            Empty = room.RoomCount[(int)RoomStatus.Empty];
            Rented = room.RoomCount[(int)RoomStatus.Rented];
            Cleaning = room.RoomCount[(int)RoomStatus.Cleaning];
            Repairing = room.RoomCount[(int)RoomStatus.Repairing];
        }

        private void btThreeDot_Click(object sender, System.EventArgs e)
        {
            if (animBookMulRooms.CordinateEnd_X == 100)
            {
                animBookMulRooms.Activate();
                animAddRoom.Activate();
                animPbSearch.Activate();
                animTbSearch.Activate();
                timerHide2SubBt.Start();
                animBookMulRooms.CordinateEnd_X = 44;
                animBookMulRooms.CordinateStart_X = 100;
                animAddRoom.CordinateEnd_X = 44;
                animAddRoom.CordinateStart_X = 156;
                animPbSearch.CordinateEnd_X = 90;
                animPbSearch.CordinateStart_X = 202;
                animTbSearch.CordinateEnd_X = 130;
                animTbSearch.CordinateStart_X = 242;
            }
            else
            {
                btAddRoom.Show();
                btBookMultipleRooms.Show();
                animBookMulRooms.Activate();
                animAddRoom.Activate();
                animPbSearch.Activate();
                animTbSearch.Activate();
                animBookMulRooms.CordinateEnd_X = 100;
                animBookMulRooms.CordinateStart_X = 40;
                animAddRoom.CordinateEnd_X = 156;
                animAddRoom.CordinateStart_X = 38;
                animPbSearch.CordinateEnd_X = 202;
                animPbSearch.CordinateStart_X = 82;
                animTbSearch.CordinateEnd_X = 242;
                animTbSearch.CordinateStart_X = 122;
            }
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            timerHide2SubBt.Stop();
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
