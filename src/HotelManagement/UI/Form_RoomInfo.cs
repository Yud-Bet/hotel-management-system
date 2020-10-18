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
            lbRoomID.Text= this.Parent._RoomID.ToString();

            if (this.Parent._RoomStatus == RoomStatus.Empty)
            {
                btPay.Hide();
            }
            else
            {
                btBookRoom.Hide();
            }


            DataTable data = DataAccess.RoomDA.GetRoomInfo(Convert.ToInt32(lbRoomID.Text));
            RoomType temp = (RoomType)Convert.ToInt32(data.Rows[0].ItemArray[0]);
            tbRoomsize.Text = data.Rows[0].ItemArray[1].ToString();
            tbRoomPrice.Text = Convert.ToInt32(data.Rows[0].ItemArray[2]).ToString();
            if (temp == RoomType.DoubleVIP)
            {
                rbtVip.Checked = true;
                rbtDouble.Checked = true;
            }
            else if (temp == RoomType.Double)
            {
                rbtNor.Checked = true;
                rbtDouble.Checked = true;
            }
            else if (temp == RoomType.SingleVIP)
            {
                rbtVip.Checked = true;
                rbtSingle.Checked = true;
            }
            else
            {
                rbtNor.Checked = true;
                rbtSingle.Checked = true;
            }

            if (this.Parent._RoomStatus == RoomStatus.Rented)
            {
                data = DataAccess.CustomerDA.GetCustomerInfo(Convert.ToInt32(lbRoomID.Text));
                tbCustomerName.Text = data.Rows[0].ItemArray[0].ToString();
                dtpCustomerBirthday.Value = Convert.ToDateTime(data.Rows[0].ItemArray[1]);
                tbCustomerPhoneNum.Text = data.Rows[0].ItemArray[2].ToString();
                if ((Sex)Convert.ToInt32(data.Rows[0].ItemArray[3]) == Sex.Female)
                {
                    rdbFemale.Checked = true;
                }
                else
                {
                    rbtMale.Checked = true;
                }
                if (data.Rows[0].ItemArray[4] != null)
                {
                    tbIDNo.Text = data.Rows[0].ItemArray[4].ToString();
                }
                if (data.Rows[0].ItemArray[5] != null)
                {
                    tbPassport.Text = data.Rows[0].ItemArray[5].ToString();
                }
                tbCustomerAddress.Text = data.Rows[0].ItemArray[6].ToString();
                tbNote.Text = data.Rows[0].ItemArray[7].ToString();
                dtpCheckInDate.Value = Convert.ToDateTime(data.Rows[0].ItemArray[8]);
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
            this.Parent._RoomStatus = RoomStatus.Rented;
            pbArrowBack_Click(sender, e);
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            this.Parent._RoomStatus = RoomStatus.Cleaning;
            pbArrowBack_Click(sender, e);
        }

        private void btSettingRoom_Click(object sender, EventArgs e)
        {
            Form_AddEditRoom form_AddEditRoom = new Form_AddEditRoom();
            form_AddEditRoom.ShowDialog();
        }
    }
}
