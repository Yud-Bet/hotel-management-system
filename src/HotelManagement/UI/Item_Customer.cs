using System;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using HotelManagement.Properties;

namespace HotelManagement.UI
{
    public partial class Item_Customer : UserControl
    {
        bool isHide = true;
        Form_Customer parentRef;

        public Item_Customer(int ID, string Name, string IDNo, string Phonenum, DateTime Birthdate, bool sex, string Address, int Revenue, Form_Customer ParentRef)
        {
            InitializeComponent();
            this.Size = new Size(815, 33);

            lbID.Text = ID.ToString();
            lbName.Text = Name;
            lbIDNO.Text = IDNo;
            lbPhonenum.Text = Phonenum;
            lbBirthdate.Text = Birthdate.ToShortDateString();
            lbSex.Text = (sex) ? "Nam" : "Nữ";
            lbAddress.Text = Address;
            lbRevenue.Text = Revenue.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));

            this.parentRef = ParentRef;

            this.Disposed += delegate { zeroitUltraTextBox1.MouseMove -= pnMain_MouseMove; };
        }

        private void pnMain_MouseMove(object sender, MouseEventArgs e)
        {
            zeroitUltraTextBox1.Focus();
        }

        private void pnMain_Click(object sender, EventArgs e)
        {
            if (isHide)
            {
                timerShow.Start();
                this.pictureBox1.Image = Resources.icVerticalArrow2;
            } else
            {
                timerHide.Start();
                this.pictureBox1.Image = Resources.icHorizontalArrow;
            }
        }

        private void timerShow_Tick(object sender, EventArgs e)
        {
            if (this.Height == 103)
            {
                timerShow.Stop();
                isHide = false;
            } else
            {
                this.Height += 7;
            }
        }

        private void timerHide_Tick(object sender, EventArgs e)
        {
            if (this.Height == 33)
            {
                timerHide.Stop();
                isHide = true;
            }
            else
            {
                this.Height -= 7;
            }
        }

        private void pbRemove_Click(object sender, EventArgs e)
        {
            this.parentRef._pnToAddItem.Controls.Remove(this);
            this.Dispose();

            GC.Collect();
        }
    }
}
