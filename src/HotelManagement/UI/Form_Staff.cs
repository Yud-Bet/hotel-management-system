using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;

namespace HotelManagement.UI
{
    public partial class Form_Staff : UserControl
    {
        public List<Item_Staff> item_Staffs = new List<Item_Staff>();

        public Form_Staff()
        {
            InitializeComponent();
            btAccount.Hide();
            btChangeStaffInfo.Hide();
            addItem(312, true, "Hiếu", "192031252", DateTime.Now, true, "", "12348560", DateTime.Now, 34567890, "kakabanlaai", "1234");
            addItem(123, true, "Dàn", "192031252", DateTime.Now, true, "", "12345890", DateTime.Now, 34567890, "thanhdan", "12345");
            addItem(1234, true, "Huấn", "192031252", DateTime.Now, true, "", "12345890", DateTime.Now, 34567890, "huanbui", "12345");
        }

        #region properties
        public Item_Staff selectedItem;

        public Panel _pnToAddItem
        {
            get { return pnToAddItem; }
        }
        #endregion

        public void setStaffValues(Item_Staff item_Staff)
        {
            btAccount.Show();
            btChangeStaffInfo.Show();
            lbID.Text = item_Staff._ID.ToString();
            lbPosition.Text = item_Staff._Position ? "Nhân viên" : "Quản lý";
            lbName.Text = item_Staff._Name;
            lbIDNo.Text = item_Staff._IDNo;
            lbBirthdate.Text = item_Staff._Birthdate.ToShortDateString().ToString();
            lbSex.Text = item_Staff._Sex ? "Nam" : "Nữ";
            lbAddress.MainText = item_Staff._Address;
            lbPhonenum.Text = item_Staff._Phonenum;
            lbStartDate.Text = item_Staff._StartDate.ToShortDateString().ToString();
            lbSalary.Text = item_Staff._Salary.ToString("C",CultureInfo.GetCultureInfo("vi-VN"));
        }

        public void resetStaffValues()
        {
            btAccount.Hide();
            btChangeStaffInfo.Hide();
            lbID.Text = "";
            lbPosition.Text = "";
            lbName.Text = "";
            lbIDNo.Text = "";
            lbBirthdate.Text = "";
            lbSex.Text = "";
            lbAddress.MainText = "";
            lbPhonenum.Text = "";
            lbStartDate.Text = "";
            lbSalary.Text = "";
        }

        public void addItem(int ID, bool position, string name, string IDNo, DateTime birthdate, bool sex, 
                    string address, string phonenum, DateTime startdate, int salary, string username, string pass)
        {
            Item_Staff temp = new Item_Staff(this);
            temp._ID = ID;
            temp._Position = position;
            temp._Name = name;
            temp._IDNo = IDNo;
            temp._Birthdate = birthdate;
            temp._Sex = sex;
            temp._Address = address;
            temp._Phonenum = phonenum;
            temp._StartDate = startdate;
            temp._Salary = salary;
            temp._Username = username;
            temp._Pass = pass;

            item_Staffs.Add(temp);
            pnToAddItem.Controls.Add(temp);
        }

        private void btAccount_Click(object sender, EventArgs e)
        {
            Form_EditAccount temp = new Form_EditAccount(selectedItem, 0);
            temp.ShowDialog();
        }

        private void btChangeStaffInfo_Click(object sender, EventArgs e)
        {
            Form_AddEditStaff temp = new Form_AddEditStaff(selectedItem);
            temp.ShowDialog();
        }

        private void btAddStaff_Click(object sender, EventArgs e)
        {
            Form_AddEditStaff temp = new Form_AddEditStaff(this);
            temp.ShowDialog();
        }
    }
}
