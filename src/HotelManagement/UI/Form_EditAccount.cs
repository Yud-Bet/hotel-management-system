using HotelManagement.Properties;
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
    public partial class Form_EditAccount : MetroFramework.Forms.MetroForm
    {
        Item_Staff parentRef;

        public Form_EditAccount(Item_Staff parentRef, int type)
        {
            InitializeComponent();
            this.parentRef = parentRef;

            tbUsername.Text = this.parentRef._Username;
            tbPass.Text = this.parentRef._Pass;

            if (type==1)
            {
                lbTitle.Text = "Thêm tài khoản nhân viên";
            }
        }



        private void btSave_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbUsername.Focus();
                return;
            }

            if (tbPass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbUsername.Focus();
                return;
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbShowHidePass_Click(object sender, EventArgs e)
        {
            changeStatusPass(tbPass, pbShowHidePass);
        }

        void changeStatusPass(Zeroit.Framework.Labels.ZeroitUltraTextBox tb, PictureBox pb)
        {
            if(tb.PasswordChar== '•')
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
    }
}
