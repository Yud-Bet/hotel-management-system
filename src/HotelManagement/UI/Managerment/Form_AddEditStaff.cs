using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using HotelManagement.Properties;

namespace HotelManagement.UI
{
    public partial class Form_AddEditStaff : MetroFramework.Forms.MetroForm
    {
        OpenFileDialog open = new OpenFileDialog();

        //Use add staff
        public Form_AddEditStaff(Form_Staff parentRef)
        {
            InitializeComponent();

            tbName.Focus();
            this.parentRef_Addstaff = parentRef;
            rbNorStaff.Checked = true;
            rbMale.Checked = true;
            btSave.Hide();
            btCancel.Hide();
        }

        //Use edit staffinfo
        public Form_AddEditStaff(Item_Staff parentRef)
        {
            InitializeComponent();

            tbName.Focus();
            this.parentRef_EditStaff = parentRef;
            loadDataIfEditInfo();
            btAddStaff.Hide();
        }

        //Use show staffinfo
        public Form_AddEditStaff(string username)
        {
            InitializeComponent();

            pbCam.Hide();
            staffImage.Click -= staffImage_Click;
            pnButton.Hide();
            pnPosition.Enabled = false;
            pnSex.Enabled = false;
            tbName.IsEnabled = false;
            tbID.IsEnabled = false;
            tbIDNo.IsEnabled = false;
            tbPhonenum.IsEnabled = false;
            tbSalary.IsEnabled = false;
            tbAddress.IsEnabled = false;
            dtBirthdate.Enabled = false;
            dtStartDate.Enabled = false;

            loadDataIfShowInfo(username);
        }

        #region properties
        Item_Staff parentRef_EditStaff;
        Form_Staff parentRef_Addstaff;
        #endregion

        void loadDataIfShowInfo(string username)
        {
            DataTable data = DataAccess.Account.GetStaffInfor(username);
            if (data.Rows.Count > 0)
            {
                tbID.Text = data.Rows[0].ItemArray[0].ToString();
                tbName.Text = data.Rows[0].ItemArray[1].ToString();
                if (Convert.ToInt32(data.Rows[0].ItemArray[2]) == 0)
                    rbManager.Checked = true;
                else rbNorStaff.Checked = true;
                tbIDNo.Text = data.Rows[0].ItemArray[4].ToString();
                dtBirthdate.Value = Convert.ToDateTime(data.Rows[0].ItemArray[5]);
                if (Convert.ToInt32(data.Rows[0].ItemArray[6]) == 0)
                    rbMale.Checked = true;
                else rbFemale.Checked = true;
                tbAddress.Text = data.Rows[0].ItemArray[7].ToString();
                tbPhonenum.Text = data.Rows[0].ItemArray[8].ToString();
                dtStartDate.Value = Convert.ToDateTime(data.Rows[0].ItemArray[9]);
                tbSalary.Text = data.Rows[0].ItemArray[10].ToString();
            }
        }

        void loadDataIfEditInfo()
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
            if (!parentRef_EditStaff._Sex)
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

            try
            {
                string[] staffImageFiles = Directory.GetFiles(@".\\staffimage", parentRef_EditStaff._IDNo + "*");
                Image image;
                using (Stream stream = File.OpenRead(staffImageFiles[0]))
                {
                    image = System.Drawing.Image.FromStream(stream);
                }
                staffImage.Image = image;
            }
            catch
            {
                staffImage.Image = Resources.profile_user;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!checkValidityOfValue())
                return;

            try
            {
                string[] staffImageFiles = Directory.GetFiles(@".\\staffimage", parentRef_EditStaff._IDNo + "*");

                File.Move(@".\\staffimage\\" + parentRef_EditStaff._IDNo + Path.GetExtension(staffImageFiles[0]),
                    @".\\staffimage\\" + tbIDNo.Text + Path.GetExtension(staffImageFiles[0]));
            }
            catch { }

            parentRef_EditStaff._Name = tbName.Text;
            parentRef_EditStaff._Birthdate = dtBirthdate.Value;
            parentRef_EditStaff._Sex = rbFemale.Checked;
            parentRef_EditStaff._Address = tbAddress.Text;
            parentRef_EditStaff._Phonenum = tbPhonenum.Text;
            parentRef_EditStaff._IDNo = tbIDNo.Text;
            parentRef_EditStaff._Position = rbNorStaff.Checked;
            parentRef_EditStaff._StartDate = dtStartDate.Value;
            parentRef_EditStaff._Salary = Convert.ToInt32(tbSalary.Text);

            parentRef_EditStaff.parentRef.setStaffValues(parentRef_EditStaff);
            int ef = DataAccess.Manager.SetStaffInfo(parentRef_EditStaff._ID, parentRef_EditStaff._Name, parentRef_EditStaff._Birthdate, parentRef_EditStaff._Sex,
                                                     parentRef_EditStaff._Address, parentRef_EditStaff._Phonenum, parentRef_EditStaff._IDNo, parentRef_EditStaff._Position,
                                                     parentRef_EditStaff._StartDate, parentRef_EditStaff._Salary, "");
            try
            {
                if (open.FileName != "")
                {
                    if (!Directory.Exists(@".\\staffimage"))
                    {
                        Directory.CreateDirectory(@".\\staffimage");
                    }

                    string[] staffImageFiles = Directory.GetFiles(@".\\staffimage", parentRef_EditStaff._IDNo + "*");

                    foreach (string i in staffImageFiles)
                    {
                        File.Delete(i);
                    }

                    File.Copy(open.FileName, @".\\staffimage\\" + parentRef_EditStaff._IDNo + Path.GetExtension(open.FileName));
                    
                    Image image;
                    using (Stream stream = File.OpenRead(@".\\staffimage\\" + parentRef_EditStaff._IDNo + Path.GetExtension(open.FileName)))
                    {
                        image = System.Drawing.Image.FromStream(stream);
                    }
                    staffImage.Image = image;
                    parentRef_EditStaff.setStaffImage();
                    parentRef_EditStaff.parentRef._staffImage.Image = image;
                }
            }
            catch {}
            
            if (ef > 0)
            {
                if (parentRef_EditStaff._IsUsingThisAcc)
                {
                    MessageBox.Show("Bạn vừa sửa thông tin nhân viên đang đăng nhập.\nVui lòng đăng nhập lại để cập nhật thông tin!", "Thông báo!");
                    this.Close();
                    this.parentRef_EditStaff.parentRef.parentRef.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thành công!", "Thông báo!");
                    this.Close();
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool checkValidityOfValue()
        {
            if (!Regex.IsMatch(tbName.Text, @"^([\p{L}]+( [\p{L}]+){0,})$"))
            {
                MessageBox.Show("Tên không được chứa ký tự đặt biệt và không chứa số.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbName.Focus();
                return false;
            }
            if (tbName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên nhân viên.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!Regex.IsMatch(tbPhonenum.Text, @"^[0-9]{10}$"))
            {
                MessageBox.Show("Số điện thoại chỉ gồm 10 số.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbPhonenum.Focus();
                return false;
            }
            if (tbPhonenum.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Số Điện Thoại.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!Regex.IsMatch(tbIDNo.Text, @"^[0-9]{9}$"))
            {
                MessageBox.Show("CMNN chỉ gồm 9 số.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbIDNo.Focus();
                return false;
            }
            if (tbIDNo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập CMND.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!Regex.IsMatch(tbSalary.Text, @"^[0-9]{0,}$"))
            {
                MessageBox.Show("Lương chỉ được phép nhập số.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSalary.Focus();
                return false;
            }
            if (tbSalary.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Lương.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
        private void btAddStaff_Click(object sender, EventArgs e)
        {
            if (!checkValidityOfValue())
                return;
            Item_Staff item_Staff = new Item_Staff(parentRef_Addstaff);
            item_Staff._Username = "";
            item_Staff._Pass = "";
            item_Staff._Name = tbName.Text;
            item_Staff._Birthdate = dtBirthdate.Value;
            item_Staff._Sex = rbMale.Checked;
            item_Staff._Address = tbAddress.Text;
            item_Staff._Phonenum = tbPhonenum.Text;
            item_Staff._IDNo = tbIDNo.Text;
            item_Staff._Position = rbNorStaff.Checked;
            item_Staff._StartDate = dtStartDate.Value;
            item_Staff._Salary = Convert.ToInt32(tbSalary.Text);
            //int a = DataAccess.Manager.AddNewStaff("new", "new", "new", DateTime.Now, false , "", "", "100", false, DateTime.Now, 1000, "");
            int a = DataAccess.Manager.AddNewStaff(item_Staff._Name, item_Staff._Username, item_Staff._Pass, item_Staff._Birthdate, item_Staff._Sex, item_Staff._Address,
                                            item_Staff._Phonenum, item_Staff._IDNo, item_Staff._Position, item_Staff._StartDate, item_Staff._Salary, "");
            if (a > 0)
            {
                DataTable id = DataAccess.Manager.GetStaffIdOfNewStaff();
                item_Staff._ID = Convert.ToInt32(id.Rows[0].ItemArray[0].ToString());
                item_Staff._Username = item_Staff._ID.ToString();
                item_Staff._Pass = item_Staff._ID.ToString();
                MessageBox.Show("Thêm nhân viên thành công!");
            }
                    

            //Form_EditAccount temp = new Form_EditAccount(item_Staff, 1);// showform để nó
            //temp.ShowDialog();
            if (item_Staff._Username == "")
            {
                return;
            }

            if (open.FileName != "")
            {
                if (!Directory.Exists(@".\\staffimage"))
                {
                    Directory.CreateDirectory(@".\\staffimage");
                }

                File.Copy(open.FileName, @".\\staffimage\\" + tbIDNo.Text.ToString() + Path.GetExtension(open.FileName));
            }
            
            this.parentRef_Addstaff.addItem(item_Staff._ID, item_Staff._Position,item_Staff._Name, item_Staff._IDNo, item_Staff._Birthdate, item_Staff._Sex,
                                            item_Staff._Address, item_Staff._Phonenum, item_Staff._StartDate, item_Staff._Salary, item_Staff._Username, item_Staff._Pass);
            this.Close();
        }

        private void staffImage_Click(object sender, EventArgs e)
        {
            try
            {
                open.Title = "Select a File";
                open.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|"
                            + "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    //staffImage.Image = new Bitmap(open.FileName);
                    staffImage.Image = new Bitmap(open.FileName);
                }
            }
            catch
            {

            }
        }

        private void Form_AddEditStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            open.Dispose();
            panel3.Dispose();

            System.GC.Collect();
        }
    }
}
