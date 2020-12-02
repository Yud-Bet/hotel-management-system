using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data;

namespace HotelManagement.UI
{
    public partial class Form_RoomInfo : UserControl
    {
        private DTO.FullCustomerInfo Customer;
        private List<DTO.CustomerOverview> customerAlreadyExistsInfos;
        private int RoomID;
        public Form_RoomInfo(Item_Room parent)
        {
            InitializeComponent();
            LoadAllCustomer();
            this.ParentRef = parent;
            ParentRef.ParentRef._lbRoomID.Show();
            Load_Data();

            dropDownList1.Hide();
            dropDownList1.ChooseItem += delegate
            {
                setCustomerInfoAlreadyExists(dropDownList1.selectedItemName);
            };
        }
        private void LoadAllCustomer()
        {
            customerAlreadyExistsInfos = new List<DTO.CustomerOverview>();
            DataTable data = DataAccess.ExecuteQuery.ExecuteReader("QLKS_GetAllCustomerInfo");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var item = new DTO.CustomerOverview();
                item.Name = Convert.ToString(data.Rows[i].ItemArray[0]);
                item.Birthday = Convert.ToDateTime(data.Rows[i].ItemArray[1]);
                item.PhoneNumber = Convert.ToString(data.Rows[i].ItemArray[2]);
                item.sex = (Sex)Convert.ToInt32(data.Rows[i].ItemArray[3]);
                item.IDNumber = Convert.ToString(data.Rows[i].ItemArray[4]);
                item.Passport = Convert.ToString(data.Rows[i].ItemArray[5]);
                item.Addr = Convert.ToString(data.Rows[0].ItemArray[6]);

                customerAlreadyExistsInfos.Add(item);
            }
        }
        private void setCustomerInfoAlreadyExists(string selectedItemName)
        {
            int i;
            for (i = 0; i < customerAlreadyExistsInfos.Count && selectedItemName != customerAlreadyExistsInfos[i].IDNumber; i++) {}
            if (i >= customerAlreadyExistsInfos.Count) return;
            tbCustomerName.Text = customerAlreadyExistsInfos[i].Name;
            dtpCustomerBirthday.Value = customerAlreadyExistsInfos[i].Birthday;
            tbCustomerPhoneNum.Text = customerAlreadyExistsInfos[i].PhoneNumber;
            SetValueForControl.SetSex(customerAlreadyExistsInfos[i].sex, rbtMale, rbtFemale);
            tbIDNo.Text = customerAlreadyExistsInfos[i].IDNumber;
            tbCustomerAddress.Text = customerAlreadyExistsInfos[i].Addr;
        }

        #region Properties
        public Item_Room ParentRef;
        #endregion

        private void Form_RoomInfo_Load(object sender, EventArgs e)
        {
            tbCustomerName.Focus();
            pnVip_Nor.Enabled = false;
            pnSignle_Dou.Enabled = false;
            tbRoomsize.IsEnabled = false;
            tbRoomPrice.IsEnabled = false;
        }

        private void Load_Data()
        {
            RoomID = this.ParentRef._RoomID;
            if (this.ParentRef._RoomStatus == RoomStatus.Empty)
            {
                btPay.Hide();
            }
            else
            {
                btBookRoom.Hide();
            }

            DTO.RoomDetail room = new DTO.RoomDetail(RoomID);
            tbRoomsize.Text = room.Size;
            tbRoomPrice.Text = room.Price;
            SetValueForControl.SetRoomType(room.Type, rbtNor, rbtVip, rbtSingle, rbtDouble);

            if (this.ParentRef._RoomStatus == RoomStatus.Rented)
            {
                Customer = new DTO.FullCustomerInfo(RoomID);
                tbCustomerName.Text = Customer.Name;
                dtpCustomerBirthday.Value = Customer.Birthday;
                tbCustomerPhoneNum.Text = Customer.PhoneNumber;
                SetValueForControl.SetSex(Customer.sex, rbtMale, rbtFemale);
                if (Customer.IDNumber.Length != 0)
                {
                    tbIDNo.Text = Customer.IDNumber;
                }
                else
                {
                    tbPassport.Text = Customer.Passport;
                    tbIDNo.Enabled = false;
                    cbIDNo.Checked = false;
                    cbPassport.Checked = true;
                    tbPassport.Enabled = true;
                }
                tbCustomerAddress.Text = Customer.Addr;
                tbNote.Text = Customer.Note;
                dtpCheckInDate.Value = Customer.CheckInDate;
            }
            else Customer = null;
        }

        private void pbArrowBack_Click(object sender, EventArgs e)
        {
            this.ParentRef.ParentRef._lbRoomID.Hide();
            this.ParentRef.ParentRef._pnToAddARoomInfo.Controls.Remove(this);
            this.ParentRef.ParentRef._pnToAddARoomInfo.SendToBack();
            
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
                tbIDNo.IsEnabled = true;
                tbPassport.IsEnabled = false;
                tbPassport.Text = "";
            }
            else
            {
                cbPassport.Checked = true;
                tbIDNo.IsEnabled = false;
                tbIDNo.Text = "";
                tbPassport.IsEnabled = true;
            }
        }

        private void cbPassport_Click(object sender, EventArgs e)
        {
            if (cbPassport.Checked == true)
            {
                cbIDNo.Checked = false;
                tbIDNo.IsEnabled = false;
                tbIDNo.Text = "";
                tbPassport.IsEnabled = true;
            }
            else
            {
                cbIDNo.Checked = true;
                tbIDNo.IsEnabled = true;
                tbPassport.IsEnabled = false;
                tbPassport.Text = "";
            }
        }

        private void btBookRoom_Click(object sender, EventArgs e)
        {
            //if (!checkEmptyValue()) return;
            //if (!checkValidityOfValue()) return;
            int a = DataAccess.CustomerDA.AddReservation(RoomID, tbCustomerName.Text,
                dtpCustomerBirthday.Value, tbCustomerPhoneNum.Text, rbtMale.Checked ? Sex.Male : Sex.Female, tbIDNo.Text,
                tbPassport.Text, tbCustomerAddress.Text, dtpCheckInDate.Value, tbNote.Text);
            int b = DataAccess.CustomerDA.AddBill(RoomID, ParentRef.ParentRef.Username);
            if (a > 0 && b > 0)
            {
                this.ParentRef.ParentRef._lbNumberOfEmptyRoom.Text = (Convert.ToInt32(this.ParentRef.ParentRef._lbNumberOfEmptyRoom.Text) - 1).ToString();
                this.ParentRef.ParentRef._lbNumberOfRentedRoom.Text = (Convert.ToInt32(this.ParentRef.ParentRef._lbNumberOfRentedRoom.Text) + 1).ToString();
                this.ParentRef._RoomStatus = RoomStatus.Rented;
                pbArrowBack_Click(sender, e);
            }
            else MessageBox.Show("Lỗi khi đặt phòng");
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
            int RowEffected = DataAccess.CustomerDA.Pay(RoomID);
            if (RowEffected > 0)
            {
                printPreviewDialogBill.Document = bill;
                printPreviewDialogBill.ShowDialog();

                this.ParentRef.ParentRef._lbNumberOfCleaningRoom.Text = (Convert.ToInt32(this.ParentRef.ParentRef._lbNumberOfCleaningRoom.Text) + 1).ToString();
                this.ParentRef.ParentRef._lbNumberOfRentedRoom.Text = (Convert.ToInt32(this.ParentRef.ParentRef._lbNumberOfRentedRoom.Text) - 1).ToString();
                this.ParentRef._RoomStatus = RoomStatus.Cleaning;
                pbArrowBack_Click(sender, e);
            }
            else MessageBox.Show("Thanh toán thất bại!", "Lỗi");
        }

        private void btSettingRoom_Click(object sender, EventArgs e)
        {
            Form_AddEditRoom form_AddEditRoom = new Form_AddEditRoom(RoomID);
            form_AddEditRoom._btAdd.Hide();
            if (form_AddEditRoom.ShowDialog() == DialogResult.OK)
            {
                DTO.RoomDetail room = new DTO.RoomDetail(RoomID);
                tbRoomsize.Text = room.Size;
                tbRoomPrice.Text = room.Price;
                SetValueForControl.SetRoomType(room.Type, rbtNor, rbtVip, rbtSingle, rbtDouble);
            }
        }

        private void bill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DTO.RoomServices svc = new DTO.RoomServices(RoomID, this.ParentRef.ParentRef.Username);
            DrawBill drawBill = new DrawBill(e.Graphics);
            drawBill.drawBillHeader();
            drawBill.drawCustomerInfo(Customer.Name, RoomID, Customer.PhoneNumber, Customer.Addr,
                dtpCheckInDate.Text, dtpCheckOutDate.Text);
            drawBill.drawItem("Phòng", (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days, Convert.ToInt32(tbRoomPrice.Text));
            int TotalMoney = Convert.ToInt32(tbRoomPrice.Text) * (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days;
            for (int i = 0; i < svc.services.Count; i++)
            {
                drawBill.drawItem(svc.services[i].Name, svc.services[i].Count, svc.services[i].Price);
                TotalMoney += svc.services[i].Count * svc.services[i].Price;
            }
            DTO.StaffOverview staff = new DTO.StaffOverview(this.ParentRef.ParentRef.Username);
            drawBill.drawEndOfBill(staff.Name, TotalMoney, 0);
        }

        private void tbCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (tbCustomerName.Text != "")
            {
                TakeCustomerAlreadyExistsToMenuItems(tbCustomerName.Text);
            }
            else
            {
                dropDownList1.Hide();
            }
        }

        private void TakeCustomerAlreadyExistsToMenuItems(string customerName)
        {
            dropDownList1.clear();
            foreach (var i in customerAlreadyExistsInfos)
            {
                if (i.Name.ToLower().Contains(customerName.ToLower()))
                {
                    dropDownList1.addItem(i.Name + " | " + i.IDNumber, i.IDNumber);
                }
            }
        }

        private void pnCustomerInfo_Click(object sender, EventArgs e)
        {
            if (dropDownList1.Location.X > MousePosition.X || dropDownList1.Location.X + dropDownList1.Width < MousePosition.X ||
                dropDownList1.Location.Y> MousePosition.Y || dropDownList1.Location.Y+dropDownList1.Height < MousePosition.Y)
            {
                dropDownList1.Hide();
            }
        }
    }
}
