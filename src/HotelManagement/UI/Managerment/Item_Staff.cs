using System;
using System.IO;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Properties;
using System.Threading;

namespace HotelManagement.UI
{
    public partial class Item_Staff : UserControl
    {
        CancellationTokenSource cts;
        static Bitmap DefaultUserImage = Resources.profile_user;
        public Item_Staff(Form_Staff parentRef)
        {
            InitializeComponent();
            this.parentRef = parentRef;
            cts = new CancellationTokenSource();
        }

        public Item_Staff()
        {
        }

        #region properties
        public Form_Staff parentRef;
        private bool isUsingThisAcc;

        public bool _IsUsingThisAcc
        {
            get { return isUsingThisAcc; }
            set 
            { 
                isUsingThisAcc = value;
                if (value) pbRemove.Hide();
            }
        }

        private int ID;

        public int _ID
        {
            get { return ID; }
            set { ID = value; }
        }

        private bool position;

        public bool _Position
        {
            get { return position; }
            set { 
                position = value;
                lbPosition.Text = value ? "Nhân viên" : "Quản lý";
            }
        }

        private string name;

        public string _Name
        {
            get { return name; }
            set { 
                name = value;
                lbName.Text = value;
            }
        }

        private string IDNo;

        public string _IDNo
        {
            get { return IDNo; }
            set {
                IDNo = value;
                lbIDNo.Text = IDNo;
                setStaffImage();
            }
        }

        private DateTime birthdate;

        public DateTime _Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        private bool sex;

        public bool _Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        private string address;

        public string _Address
        {
            get { return address; }
            set { address = value; }
        }

        private string phonenum;

        public string _Phonenum
        {
            get { return phonenum; }
            set { 
                phonenum = value;
                lbPhonenum.Text = value;
            }
        }

        private DateTime startDate;

        public DateTime _StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private int salary;

        public int _Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private string username;

        public string _Username
        {
            get { return username; }
            set { username = value; }
        }

        private string pass;

        public string _Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        #endregion

        private async void pbRemove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn xóa nhân viên này chứ?","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OverlayForm overlay = new OverlayForm(parentRef.parentRef, new LoadingForm(cts.Token));
                overlay.Show();
                if (this == this.parentRef.selectedItem)
                {
                    parentRef.resetStaffValues();
                    parentRef.selectedItem = null;
                }
                try
                {
                    int a = await Task.Run(() => {
                        try
                        {
                            return DataAccess.Manager.RemoveStaff(this._ID);
                        }
                        catch
                        {
                            return -2;
                        }
                    });
                    if (a == -2) throw new Exception("Lỗi khi kết nối đến server!");
                    if (!Directory.Exists(@".\\staffimage"))
                    {
                        Directory.CreateDirectory(@".\\staffimage");
                    }

                    string[] staffImageFiles = Directory.GetFiles(@".\\staffimage", this._IDNo + "*");

                    foreach (string i in staffImageFiles)
                    {
                        File.Delete(i);
                    }
                    parentRef._pnToAddItem.Controls.Remove(this);
                    parentRef.item_Staffs.Remove(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
                finally
                {
                    cts.Cancel();
                    cts.Dispose();
                    cts = new CancellationTokenSource();
                }
            }
            //MessageBox.Show(parentRef.item_Staffs.Count.ToString());
        }

        private void itemStaff_Click(object sender, EventArgs e)
        {
            this.parentRef.setStaffValues(this);
            this.parentRef.selectedItem = this;
        }

        //private void setStaffInfo(Item_Staff temp, bool position, string name, string IDNo, DateTime birthdate, bool sex,
        //            string address, string phonenum, DateTime startdate, int salary, string username, string pass)
        //{
        //    //temp._ID = ID;
        //    temp._Position = position;
        //    temp._Name = name;
        //    temp._IDNo = IDNo;
        //    temp._Birthdate = birthdate;
        //    temp._Sex = sex;
        //    temp._Address = address;
        //    temp._Phonenum = phonenum;
        //    temp._StartDate = startdate;
        //    temp._Salary = salary;
        //    temp._Username = username;
        //    temp._Pass = pass;

        //    item_Staffs.Add(temp);
        //    pnToAddItem.Controls.Add(temp);

        //}
        public void setStaffImage()
        {
            string staffImageDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\\hotel_management\\staffimage\\";
            try
            {
                string[] staffImageFiles = Directory.GetFiles(staffImageDirectory, IDNo + "*");
                Image image;
                using (Stream stream = File.OpenRead(staffImageFiles[0]))
                {
                    image = System.Drawing.Image.FromStream(stream);
                }
                staffImage.Image = image;
            }
            catch
            {
                staffImage.Image = DefaultUserImage;
            }
        } 
    }
}
