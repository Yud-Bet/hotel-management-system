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
            tbCustomerName.Focus();
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

        private void cbCheckOutDate_Click(object sender, EventArgs e)
        {
            if (cbCheckOutDate.Checked == true)
            {
                dtpCheckOutDate.Enabled = true;
            }
            else
            {
                dtpCheckOutDate.Enabled = false;
            }
        }

        private void cbIDNo_Click(object sender, EventArgs e)
        {
            if (cbIDNo.Checked == true)
            {
                cbPassport.Checked = false;
                tbIDNo.Enabled = true;
                tbPassport.Enabled = false;
                tbPassport.Text = "";
            }
            else
            {
                cbPassport.Checked = true;
                tbIDNo.Enabled = false;
                tbIDNo.Text = "";
                tbPassport.Enabled = true;
            }
        }

        private void cbPassport_Click(object sender, EventArgs e)
        {
            if (cbPassport.Checked == true)
            {
                cbIDNo.Checked = false;
                tbIDNo.Enabled = false;
                tbIDNo.Text = "";
                tbPassport.Enabled = true;
            }
            else
            {
                cbIDNo.Checked = true;
                tbIDNo.Enabled = true;
                tbPassport.Enabled = false;
                tbPassport.Text = "";
            }
        }

        private void btBookRoom_Click(object sender, EventArgs e)
        {
            this.Parent._RoomStatus = 2;
            pbArrowBack_Click(sender, e);
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            this.Parent._RoomStatus = 3;
            pbArrowBack_Click(sender, e);
        }

        private void btSettingRoom_Click(object sender, EventArgs e)
        {
            Form_AddEditRoom form_AddEditRoom = new Form_AddEditRoom();
            form_AddEditRoom.ShowDialog();
        }
    }
}
