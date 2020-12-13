using HotelManagement.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HotelManagement.UI
{
    public partial class Form_Login : Form
    {
        LoginState loginState;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Form_Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));

            this.tbUsername.GotFocus += delegate { OnFocusTbUsername(); };
            this.tbUsername.LostFocus += delegate { DeFocusTbUsername(); };
            this.tbPassword.GotFocus += delegate { OnFocusTbPassword(); };
            this.tbPassword.LostFocus += delegate { DeFocusTbPassword(); };

            this.tbUsername.KeyDown += new KeyEventHandler(tbUsername_PressEnter);
            this.tbPassword.KeyDown += new KeyEventHandler(tbPassword_PressEnter);

            lbPassword.Hide();
            lbUsername.Hide();
            LoginBGWorker.WorkerReportsProgress = true;
        }

        private void OnFocusTbUsername()
        {
            if (tbUsername.Text == "Tên đăng nhập")
            {
                tbUsername.Text = "";
            }

            pnUsernameLine.BackColor = Color.FromArgb(27, 152, 224);
            lbUsername.Show();
            pbUser.Image = Resources.icUserLogin2;

        }

        private void DeFocusTbUsername()
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Tên đăng nhập";
            }

            pnUsernameLine.BackColor = Color.FromArgb(36, 123, 160);
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

            pnPasswordLine.BackColor = Color.FromArgb(27, 152, 224);
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

            pnPasswordLine.BackColor = Color.FromArgb(36, 123, 160);
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

        private async void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Tên đăng nhập" || tbUsername.Text == "")
            {
                await Task.Run(() => {
                    MessageBox.Show("Tên đăng nhập không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbUsername.Focus();
                });
                return;
            }
            if (tbPassword.Text == "Mật khẩu" || tbPassword.Text == "")
            {
                await Task.Run(() => {
                    MessageBox.Show("Mật khẩu không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbPassword.Focus();
                });
                return;
            }
            try
            {
                if (LoginBGWorker.IsBusy) return;
                LoginBGWorker.RunWorkerAsync();
                StatusLabel.Text = "Đang đăng nhập...";
                tbUsername.ReadOnly = true;
                tbPassword.ReadOnly = true;
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
            ExitTimer.Tick += delegate { Application.Exit(); };
        }

        private void LoginBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                bool LoginSuccessful = DataAccess.Account.Login(tbUsername.Text, tbPassword.Text);
                if (LoginSuccessful) LoginBGWorker.ReportProgress(100);
                else LoginBGWorker.ReportProgress(50);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                LoginBGWorker.ReportProgress(0);
            }
        }

        private void LoginBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                loginState = LoginState.CantConnect;
                StatusLabel.Text = "Không thể kết nối đến server";
            }
            else if (e.ProgressPercentage == 50)
            {
                loginState = LoginState.Failed;
                StatusLabel.Text = "Đăng nhập thất bại";
            }
            else if (e.ProgressPercentage == 100)
            {
                loginState = LoginState.Successful;
            }
        }

        private void LoginBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (loginState == LoginState.CantConnect)
            {
                MessageBox.Show("Không thể kết nối đến server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (loginState == LoginState.Successful)
            {
                Form_Main main = new Form_Main(tbUsername.Text);
                this.Hide();
                main.ShowDialog();
                this.Show();
                StatusLabel.Text = "";
            }
            else if (loginState == LoginState.Failed)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbUsername.ReadOnly = false;
            tbPassword.ReadOnly = false;
        }

    }
}
