using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Form_Room : UserControl
    {
        public Form_Room()
        {
            InitializeComponent();
            Load_Data();
        }

        public Panel _pnToAddARoomInfo
        {
            get { return pnToAddARoomInfo; }
        }

        private void Load_Data()
        {
            int n = 10;
            lbNumberOfRoom.Text = n.ToString();

            int[] count = new int[5];
            Random rd = new Random();

            for (int i = 0; i < n; i++)
            {
                Room newRoom = new Room(this);
                int trd = rd.Next(1, 5);
                count[trd]++;

                newRoom._RoomCount = rd.Next(100, 120);
                newRoom._RoomStatus = trd;
                newRoom._RoomType = trd;

                this.pnToAddRoom.Controls.Add(newRoom);
            }

            lbNumberOfEmptyRoom.Text = count[1].ToString();
            lbNumberOfRentedRoom.Text = count[2].ToString();
            lbNumberOfCleaningRoom.Text = count[3].ToString();
            lbNumberOfFixingRoom.Text = count[4].ToString();
        }
    }
}
