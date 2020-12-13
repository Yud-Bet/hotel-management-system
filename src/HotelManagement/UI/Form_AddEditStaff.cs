using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Form_AddEditStaff : MetroFramework.Forms.MetroForm
    {
        public Form_AddEditStaff(Form_Staff parentRef)
        {
            InitializeComponent();

            this.parentRef_Addstaff = parentRef;
            btSave.Hide();
            btCancel.Hide();
        }

        public Form_AddEditStaff(Item_Staff parentRef)
        {
            InitializeComponent();

            this.parentRef_EditStaff = parentRef;
            loadData_IfEditInfo();
            btAddStaff.Hide();
        }

        #region properties
        Item_Staff parentRef_EditStaff;
        Form_Staff parentRef_Addstaff;
        #endregion

        void loadData_IfEditInfo()
        {
            tbID.Text = parentRef_EditStaff._ID.ToString();
            if (parentRef_EditStaff._Position)
            {
                rbNorStaff.Checked = true;
            }
            else
            {
                rbManager.Checked = true;
            }
            tbName.Text = parentRef_EditStaff._Name;
            tbIDNo.Text = parentRef_EditStaff._IDNo;
            dtBirthdate.Value = parentRef_EditStaff._Birthdate;
            if (parentRef_EditStaff._Sex)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            tbAddress.Text = parentRef_EditStaff._Address;
            tbPhonenum.Text = parentRef_EditStaff._Phonenum;
            dtStartDate.Value = parentRef_EditStaff._StartDate;
            tbSalary.Text = parentRef_EditStaff._Salary.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            parentRef_EditStaff.parentRef.setStaffValues(parentRef_EditStaff);
            //
            //gán lại data giùm t, t nhác vl
            //
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAddStaff_Click(object sender, EventArgs e)
        {
            Item_Staff item_Staff = new Item_Staff(parentRef_Addstaff);
            item_Staff._Username = "";
            item_Staff._Pass = "";

            Form_EditAccount temp = new Form_EditAccount(item_Staff, 1);// showform để nó
            temp.ShowDialog();
            if (item_Staff._Username == "")
            {
                return;
            }
            //
            //làm như hàm additem bên form_staff (parentRef_AddStaff.addItem(....)) để add nhân viên mới thêm vào danh sách trong form staff
            //

            this.Close();
        }
    }
}
