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
    public partial class Form_RoomInfo : UserControl
    {
        public Form_RoomInfo(Room parent)
        {
            InitializeComponent();
            this.Parent = parent;
            Load_Data();
        }

        #region Properties
        public Room Parent;
        #endregion

        private void Form_RoomInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void Load_Data()
        {
            lbRoomCount.Text= this.Parent._RoomCount.ToString();

            if (this.Parent._RoomStatus == 1)
            {
                btPay.Hide();
            }
            else
            {
                btBookRoom.Hide();
            }
        }

        private void pbArrowBack_Click(object sender, EventArgs e)
        {
            this.Parent.Parent._pnToAddARoomInfo.Controls.Remove(this);
            this.Parent.Parent._pnToAddARoomInfo.SendToBack();
        }

        private void cbCheckoutDate_OnChange(object sender, EventArgs e)
        {
            if (cbCheckoutDate.Checked == true)
            {
                dtCheckoutDate.Enabled = true;
            } else
            {
                dtCheckoutDate.Enabled = false;
            }
        }
    }
}
