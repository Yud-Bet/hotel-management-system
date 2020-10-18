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
using Zeroit.Framework.Transitions;

namespace HotelManagement.UI
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();

            this.tbUsername.GotFocus += delegate { OnFocusTbUsername(); };
            this.tbUsername.LostFocus += delegate { DeFocusTbUsername(); };
            this.tbPassword.GotFocus += delegate { OnFocusTbPassword(); };
            this.tbPassword.LostFocus += delegate { DeFocusTbPassword(); };

            this.tbUsername.KeyDown += new KeyEventHandler(tbUsername_PressEnter);
            this.tbPassword.KeyDown += new KeyEventHandler(tbPassword_PressEnter);

            lbPassword.Hide();
            lbUsername.Hide();

        }

        private void OnFocusTbUsername()
        {
            if (tbUsername.Text == "Tên đăng nhập")
            {
                tbUsername.Text = "";
            }

            pnUsernameLine.BackColor = Color.FromArgb(37, 170, 160);
            lbUsername.Show();
            pbUser.Image = Resources.icUserLogin2;

        }

        private void DeFocusTbUsername()
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Tên đăng nhập";
            }

            pnUsernameLine.BackColor = Color.FromArgb(102, 102, 120);
            lbUsername.Hide();
            pbUser.Image = Resources.icUserLogin1;
        }

        private void OnFocusTbPassword()
        {
            if (tbPassword.Text == "Mật khẩu")
            {
                tbPassword.Text = "";
                tbPassword.PasswordChar = '●';
            }

            pnPasswordLine.BackColor = Color.FromArgb(37, 170, 160);
            lbPassword.Show();
            pbPass.Image = Resources.icPassLogin2;
        }

        private void DeFocusTbPassword()
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Mật khẩu";
                tbPassword.PasswordChar = (char)0;
            }

            pnPasswordLine.BackColor = Color.FromArgb(102, 102, 120);
            lbPassword.Hide();
            pbPass.Image = Resources.icPassLogin1;
        }

        private void tbUsername_PressEnter(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Enter)
            {
                tbPassword.Focus();
            }
        }

        private void tbPassword_PressEnter(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Enter)
            {
                btLogin_Click(sender, kea);
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Tên đăng nhập" || tbUsername.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbUsername.Focus();
                return;
            }

            if (tbPassword.Text == "Mật khẩu" || tbPassword.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbPassword.Focus();
                return;
            }
            try
            {
                if (DataAccess.Account.Login(tbUsername.Text, tbPassword.Text))
                {
                    Form_Main temp = new Form_Main();
                    this.Hide();
                    temp.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbUsername.Focus();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
