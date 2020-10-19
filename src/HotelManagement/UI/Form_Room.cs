﻿using System;
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
            DataTable data = DataAccess.RoomDA.GetAllRoom();

            int n = data.Rows.Count;
            lbNumberOfRoom.Text = n.ToString();

            int[] count = new int[5];

            for (int i = 0; i < n; i++)
            {
                Room newRoom = new Room(this);

                newRoom._RoomID = Convert.ToInt32(data.Rows[i].ItemArray[0]);
                newRoom._RoomStatus = (RoomStatus)Convert.ToInt32(data.Rows[i].ItemArray[1]);
                count[(int)newRoom._RoomStatus]++;
                newRoom._RoomType = (RoomType)Convert.ToInt32(data.Rows[i].ItemArray[2]);

                this.pnToAddRoom.Controls.Add(newRoom);
            }

            lbNumberOfEmptyRoom.Text = count[1].ToString();
            lbNumberOfRentedRoom.Text = count[2].ToString();
            lbNumberOfCleaningRoom.Text = count[3].ToString();
            lbNumberOfFixingRoom.Text = count[4].ToString();
        }
    }
}