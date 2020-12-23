using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using System.Data;
using System.IO;
using System.Drawing;
using HotelManagement.Properties;

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
            load_AllStaffInfo();
        }
        private void load_AllStaffInfo()
        {
            DataTable StaffInfo = DataAccess.Report.GetAllStaffInfo(Convert.ToInt32(cbSort.SelectedIndex));
            item_Staffs.Clear();
            pnToAddItem.Controls.Clear();
            for (int i = 0; i < StaffInfo.Rows.Count; i++)
            {
                //addItem(StaffInfo.Rows[i].ItemArray[i].ToString())
                addItem(Convert.ToInt32(StaffInfo.Rows[i].ItemArray[0]),
                        Convert.ToBoolean(StaffInfo.Rows[i].ItemArray[1]),
                        StaffInfo.Rows[i].ItemArray[2].ToString(),
                        StaffInfo.Rows[i].ItemArray[3].ToString(),
                        Convert.ToDateTime(StaffInfo.Rows[i].ItemArray[4]),
                        Convert.ToBoolean(StaffInfo.Rows[i].ItemArray[5]),
                        StaffInfo.Rows[i].ItemArray[6].ToString(),
                        StaffInfo.Rows[i].ItemArray[7].ToString(),
                        Convert.ToDateTime(StaffInfo.Rows[i].ItemArray[8]),
                        Convert.ToInt32(StaffInfo.Rows[i].ItemArray[9]),
                        StaffInfo.Rows[i].ItemArray[10].ToString(),
                        StaffInfo.Rows[i].ItemArray[11].ToString()
                        );
            }
        }

        #region properties
        public Item_Staff selectedItem;

        public Panel _pnToAddItem
        {
            get { return pnToAddItem; }
        }

        public CirclePictureBox _staffImage
        {
            get { return staffImage; }
        }

        public Image Resource { get; private set; }
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

            try
            {
                string[] staffImageFiles = Directory.GetFiles(@".\\staffimage", item_Staff._IDNo + "*");

                staffImage.Image = Image.FromFile(staffImageFiles[0]);
            }
            catch 
            {
                staffImage.Image = Resources.profile_user;
            }
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

            staffImage.Image = Resources.profile_user;
        }

        public void addItem(int ID, bool position, string name, string IDNo, DateTime birthdate, bool sex,
                    string address, string phonenum, DateTime startdate, int salary, string username, string pass)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch
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
            //Form_AddEditStaff temp = new Form_AddEditStaff(this);
            (new Form_AddEditStaff(this)).ShowDialog();
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_AllStaffInfo();
            resetStaffValues();
        }

        private void pnToAddItem_ControlAdded(object sender, ControlEventArgs e)
        {
            lbListStaffIsEmpty.Hide();
        }

        private void pnToAddItem_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (pnToAddItem.Controls.Count == 1)
            {
                lbListStaffIsEmpty.Show();
            }
        }
    }
}
