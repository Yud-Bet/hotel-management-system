using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Properties;


namespace HotelManagement.UI
{
    public partial class Form_ChangePassword : MetroFramework.Forms.MetroForm
    {
        Item_Staff staff = new Item_Staff();

        public Form_ChangePassword(string user)
        {
            InitializeComponent();
            tbUsername.Text = user;
            staff._Username = user;
            DataTable staffInfo = DataAccess.Account.GetStaffInfor(user);
            if (staffInfo.Rows.Count > 0)
            {
                staff._Pass = staffInfo.Rows[0].ItemArray[3].ToString();
                staff._ID = Convert.ToInt32(staffInfo.Rows[0].ItemArray[0]);
            }
        }
        private void btCharge_Click(object sender, EventArgs e)
        {
            if (tbOldPass.Text != staff._Pass)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo!");
                return;
            }
            if (tbNewPass.Text != tbNewPass1.Text)
            {
                MessageBox.Show("Mật mới không khớp!", "Thông báo!");
                return;
            }
            int ef = DataAccess.Account.ChangePassword(staff._Username, staff._Pass, tbNewPass.Text);
            if (ef > 0)
            {
                MessageBox.Show("Đã đổi mật khẩu thành công!", "Thông báo!");
                this.Close();
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbShowHidePass_Click(object sender, EventArgs e)
        {
            changeStatusPass(tbOldPass, pbShowHidePass);
        }

        void changeStatusPass(Zeroit.Framework.Labels.ZeroitUltraTextBox tb, PictureBox pb)
        {
            if (tb.PasswordChar == '•')
            {
                tb.PasswordChar = (char)0;
                pb.Image = Resources.icHidePass;
            }
            else
            {
                tb.PasswordChar = '•';
                pb.Image = Resources.icShowPass;
            }
        }

        private void pbShowHidePass1_Click(object sender, EventArgs e)
        {
            changeStatusPass(tbNewPass, pbShowHidePass1);

        }

        private void pbShowHidePass2_Click(object sender, EventArgs e)
        {
            changeStatusPass(tbNewPass1, pbShowHidePass2);

        }
    }
}
