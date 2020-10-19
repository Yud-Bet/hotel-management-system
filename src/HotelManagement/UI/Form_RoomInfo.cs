using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            pnVip_Nor.Enabled = false;
            pnSignle_Dou.Enabled = false;
            tbRoomsize.Enabled = false;
            tbRoomPrice.Enabled = false;
        }

        private void Load_Data()
        {
            lbRoomID.Text = this.Parent._RoomID.ToString();

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
                    rbtFemale.Checked = true;
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
            if (!checkEmptyValue()) return;
            if (!checkValidityOfValue()) return;
            //
            // Huấn code
            //
            this.Parent.Parent._lbNumberOfEmptyRoom.Text = (Convert.ToInt32(this.Parent.Parent._lbNumberOfEmptyRoom.Text) - 1).ToString();
            this.Parent.Parent._lbNumberOfRentedRoom.Text = (Convert.ToInt32(this.Parent.Parent._lbNumberOfRentedRoom.Text) + 1).ToString();
            this.Parent._RoomStatus = RoomStatus.Rented;
            pbArrowBack_Click(sender, e);
        }

        bool checkEmptyValue()
        {
            if (tbCustomerName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCustomerName.Focus();
                return false;
            }

            if ((DateTime.Today - dtpCustomerBirthday.Value).TotalDays < 365 * 16)
            {
                MessageBox.Show("Khách hàng chưa đủ tuổi.\nVui lòng kiểm tra lại ngày sinh khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            
            if (tbCustomerPhoneNum.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCustomerPhoneNum.Focus();
                return false;
            }

            if(rbtMale.Checked==false && rbtFemale.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (cbIDNo.Checked == true)
            {
                if (tbIDNo.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số CMDD.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbIDNo.Focus();
                    return false;
                }
            }
            else
            {
                if (tbPassport.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số hộ chiếu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbPassport.Focus();
                    return false;
                }
            }

            if (tbCustomerAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCustomerAddress.Focus();
                return false;
            }

            return true;
        }

        bool checkValidityOfValue()
        {
            if (!Regex.IsMatch(tbCustomerName.Text, @"^([\p{L}]+( [\p{L}]+){0,})$"))
            {
                MessageBox.Show("Tên không được chứa ký tự đặt biệt và không chứa số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCustomerName.Focus();
                return false;
            }

            if (!Regex.IsMatch(tbCustomerPhoneNum.Text, @"^[0-9]{10}$"))
            {
                MessageBox.Show("Số điện thoại gồm chỉ gồm 10 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCustomerPhoneNum.Focus();
                return false;
            }

            if (!Regex.IsMatch(tbIDNo.Text, @"^[0-9]{9}$") && cbIDNo.Checked==true)
            {
                MessageBox.Show("CMNN gồm chỉ gồm 9 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbIDNo.Focus();
                return false;
            }

            return true;
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            //
            // Huấn code
            //
            this.Parent.Parent._lbNumberOfCleaningRoom.Text = (Convert.ToInt32(this.Parent.Parent._lbNumberOfCleaningRoom.Text) + 1).ToString();
            this.Parent.Parent._lbNumberOfRentedRoom.Text = (Convert.ToInt32(this.Parent.Parent._lbNumberOfRentedRoom.Text) - 1).ToString();
            this.Parent._RoomStatus = RoomStatus.Cleaning;
            pbArrowBack_Click(sender, e);
        }

        private void btSettingRoom_Click(object sender, EventArgs e)
        {
            Form_AddEditRoom form_AddEditRoom = new Form_AddEditRoom();
            form_AddEditRoom._btAdd.Hide();
            form_AddEditRoom.ShowDialog();
        }
    }
}
