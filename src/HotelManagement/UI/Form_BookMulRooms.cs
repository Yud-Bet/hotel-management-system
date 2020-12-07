﻿using System;
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
    public partial class Form_BookMulRooms : UserControl
    {
        List<Item_RoomOfFormBookMulRoom> items = new List<Item_RoomOfFormBookMulRoom>();
        private List<DTO.CustomerOverview> Customers;
        private int ClientID = -1;

        public Form_BookMulRooms(Form_Room parentRef)
        {
            InitializeComponent();
            ParentRef = parentRef;
            loadData();

            LoadAllCustomer();
            dropDownList1.Hide();
            dropDownList1.ChooseItem += delegate
            {
                setCustomerInfoAlreadyExists(dropDownList1.selectedItemName);
            };
        }

        private void LoadAllCustomer()
        {
            Customers = new List<DTO.CustomerOverview>();
            DataTable data = DataAccess.ExecuteQuery.ExecuteReader("QLKS_GetAllCustomerInfo");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var item = new DTO.CustomerOverview();
                item.ID = Convert.ToInt32(data.Rows[i].ItemArray[0]);
                item.Name = Convert.ToString(data.Rows[i].ItemArray[1]);
                item.Birthday = Convert.ToDateTime(data.Rows[i].ItemArray[2]);
                item.PhoneNumber = Convert.ToString(data.Rows[i].ItemArray[3]);
                item.sex = (Sex)Convert.ToInt32(data.Rows[i].ItemArray[4]);
                item.IDNumber = Convert.ToString(data.Rows[i].ItemArray[5]);
                item.Passport = Convert.ToString(data.Rows[i].ItemArray[6]);
                item.Addr = Convert.ToString(data.Rows[0].ItemArray[7]);

                Customers.Add(item);
            }
        }

        private void setCustomerInfoAlreadyExists(string selectedItemName)
        {
            int i;
            //for (i = 0; i < Customers.Count
            //    && (selectedItemName != Customers[i].IDNumber && selectedItemName != Customers[i].Passport); i++) {}
            for (i = 0; i < Customers.Count
                && (selectedItemName != Customers[i].ID.ToString()); i++) { }
            ClientID = Customers[i].ID;
            if (i >= Customers.Count) return;
            tbCustomerName.Text = Customers[i].Name;
            dtpCustomerBirthday.Value = Customers[i].Birthday;
            tbCustomerPhoneNum.Text = Customers[i].PhoneNumber;
            SetValueForControl.SetSex(Customers[i].sex, rbtMale, rbtFemale);
            if (Customers[i].IDNumber.Length != 0)
            {
                tbIDNo.Text = Customers[i].IDNumber;
            }
            else
            {
                tbPassport.Text = Customers[i].Passport;
                tbIDNo.Enabled = false;
                cbIDNo.Checked = false;
                cbPassport.Checked = true;
                tbPassport.Enabled = true;
            }
            tbCustomerAddress.Text = Customers[i].Addr;
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
            foreach (var i in Customers)
            {
                string AdditionalInfo = (i.IDNumber.Length != 0) ? i.IDNumber : i.Passport;
                //string AdditionalInfo = i.ID.ToString();
                if (i.Name.ToLower().Contains(customerName.ToLower()))
                {
                    dropDownList1.addItem(i.Name + " | " + AdditionalInfo, i.ID.ToString());
                }
            }
        }

        private void pnCustomerInfo_Click(object sender, EventArgs e)
        {
            if (dropDownList1.Location.X > MousePosition.X || dropDownList1.Location.X + dropDownList1.Width < MousePosition.X ||
                dropDownList1.Location.Y > MousePosition.Y || dropDownList1.Location.Y + dropDownList1.Height < MousePosition.Y)
            {
                dropDownList1.Hide();
            }
        }

        void loadData()
        {
            foreach(var i in ParentRef.listRoom)
            {
                if(i._RoomStatus == RoomStatus.Empty || i._RoomStatus == RoomStatus.Cleaning)
                {
                    Item_RoomOfFormBookMulRoom newItem = new Item_RoomOfFormBookMulRoom(i, this);
                    items.Add(newItem);
                    pnToSelectRoom.Controls.Add(newItem);
                }
            }
            emtyCount = items.Count();
            PanelList.XPanderPanels[0].Text = "Danh sách phòng trống: " + emtyCount.ToString() + " phòng";
            PanelList.XPanderPanels[1].Text = "Danh sách phòng đã chọn: " + selectedCount.ToString() + " phòng";
        }

        #region Properties
        public Form_Room ParentRef;
        public int emtyCount, selectedCount = 0;

        public int _emtyCount
        {
            get { return emtyCount; }
            set { 
                emtyCount = value;
                PanelList.XPanderPanels[0].Text = "Danh sách phòng trống: " + emtyCount.ToString() + " phòng";
            }
        }

        public int _selectedCount
        {
            get { return selectedCount; }
            set
            {
                selectedCount = value;
                PanelList.XPanderPanels[1].Text = "Danh sách phòng đã chọn: " + selectedCount.ToString() + " phòng";
            }
        }

        public FlowLayoutPanel _pnToSelectRoom
        {
            get { return pnToSelectRoom; }
        }

        public FlowLayoutPanel _pnSeletedRoom
        {
            get { return pnSeletedRoom; }
        }

        public Zeroit.Framework.MiscControls.ZeroitProPanelList _panelList
        {
            get { return PanelList; }
        }
        #endregion

        private void btBookRoom_Click(object sender, EventArgs e)
        {
            if (!checkValidityOfValue()) return;
            List<Item_RoomOfFormBookMulRoom> listRoomID = new List<Item_RoomOfFormBookMulRoom>();
            foreach (Item_RoomOfFormBookMulRoom item in items)
            {
                if (item.isChoose)
                {
                    listRoomID.Add(item);
                }
            }

            if (listRoomID.Count > 0)
            {
                if (ClientID <= 0)
                {
                    int a = DataAccess.CustomerDA.InsertNewClient(tbCustomerName.Text, dtpCustomerBirthday.Value, tbIDNo.Text, tbPassport.Text,
                    tbCustomerAddress.Text, tbCustomerPhoneNum.Text, rbtMale.Checked ? Sex.Male : Sex.Female);
                }
                int b = DataAccess.CustomerDA.InsertNewRoomReservation(dtpCheckInDate.Value, 0, ParentRef.Username, 0, tbNote.Text);
                int d = DataAccess.CustomerDA.InsertNewBill(0, ParentRef.Username);
                foreach (Item_RoomOfFormBookMulRoom item in listRoomID)
                {

                    int c = DataAccess.CustomerDA.InsertRoomReservationDetail(0, item._RoomID);
                    item.ParentRefItemRoom._RoomStatus = RoomStatus.Rented;
                    this.ParentRef._lbNumberOfEmptyRoom.Text = (Convert.ToInt32(this.ParentRef._lbNumberOfEmptyRoom.Text) - 1).ToString();
                    this.ParentRef._lbNumberOfRentedRoom.Text = (Convert.ToInt32(this.ParentRef._lbNumberOfRentedRoom.Text) + 1).ToString();

                }

                MessageBox.Show("Bạn đã đặt phòng thành công!", "Thông báo!");
                pbArrowBack_Click(sender, e);
            }
            else {
                MessageBox.Show("Vui lòng chọn phòng!", "Thông báo!");
            }
        }


        private void pbArrowBack_Click(object sender, EventArgs e)
        {
            this.ParentRef._lbRoomID.Hide();
            this.ParentRef._pnToAddARoomInfo.Controls.Remove(this);
            this.ParentRef._pnToAddARoomInfo.SendToBack();
        }

        bool checkValidityOfValue()
        {
            if (!Regex.IsMatch(tbCustomerName.Text, @"^$|^([\p{L}]+( [\p{L}]+){0,})$"))
            {
                MessageBox.Show("Tên không được chứa ký tự đặt biệt và không chứa số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCustomerName.Focus();
                return false;
            }

            if (!Regex.IsMatch(tbCustomerPhoneNum.Text, @"^$|^[0-9]{10}$"))
            {
                MessageBox.Show("Số điện thoại gồm chỉ gồm 10 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCustomerPhoneNum.Focus();
                return false;
            }

            if (!Regex.IsMatch(tbIDNo.Text, @"^$|^[0-9]{9}$") && cbIDNo.Checked == true)
            {
                MessageBox.Show("CMNN gồm chỉ gồm 9 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbIDNo.Focus();
                return false;
            }

            return true;
        }

        private void cbIDNo_Click(object sender, EventArgs e)
        {
            if (cbIDNo.Checked == true)
            {
                cbPassport.Checked = false;
                tbIDNo.IsEnabled = true;
                tbPassport.IsEnabled = false;
                tbPassport.Text = "";
                tbIDNo.Focus();
            }
            else
            {
                cbPassport.Checked = true;
                tbIDNo.IsEnabled = false;
                tbPassport.IsEnabled = true;
                tbIDNo.Text = "";
                tbPassport.Focus();
            }
        }

        private void cbPassport_Click(object sender, EventArgs e)
        {
            if (cbPassport.Checked == true)
            {
                cbIDNo.Checked = false;
                tbIDNo.IsEnabled = false;
                tbPassport.IsEnabled = true;
                tbIDNo.Text = "";
                tbPassport.Focus();
            }
            else
            {
                cbIDNo.Checked = true;
                tbIDNo.IsEnabled = true;
                tbPassport.IsEnabled = false;
                tbPassport.Text = "";
                tbIDNo.Focus();
            }
        }
    }
}
