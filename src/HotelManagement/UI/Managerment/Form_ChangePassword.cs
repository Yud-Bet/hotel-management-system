using System;
using System.Data;
using System.Windows.Forms;
using HotelManagement.Properties;
using System.Threading.Tasks;
using System.Threading;


namespace HotelManagement.UI
{
    public partial class Form_ChangePassword : MetroFramework.Forms.MetroForm
    {
        Item_Staff staff = new Item_Staff();
        CancellationTokenSource cts = new CancellationTokenSource();

        public Form_ChangePassword(string user)
        {
            InitializeComponent();
            tbUsername.Text = user;
            staff._Username = user;
        }
        private async void btCharge_Click(object sender, EventArgs e)
        {
            if (DataAccess.Account.Encrypt(tbOldPass.Text) != staff._Pass)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo!");
                return;
            }
            if (tbNewPass.Text != tbNewPass1.Text)
            {
                MessageBox.Show("Mật mới không khớp!", "Thông báo!");
                return;
            }
            try
            {
                OverlayForm overlay = new OverlayForm(this, new LoadingForm(cts.Token));
                overlay.Show();

                int ef = await Task.Run(() => {
                    try
                    {
                        return DataAccess.Account.ChangePassword(staff._Username, tbOldPass.Text, tbNewPass.Text);
                    }
                    catch
                    {
                        return -2;
                    }
                });
                if (ef == -2) throw new Exception("Đã xảy ra lỗi khi kết nối đến server");
                if (ef > 0)
                {
                    MessageBox.Show("Đã đổi mật khẩu thành công!", "Thông báo!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
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

        private async void Form_ChangePassword_Load(object sender, EventArgs e)
        {
            try
            {
                OverlayForm overlay = new OverlayForm(this, new LoadingForm(cts.Token));
                overlay.Show();

                DataTable staffInfo = await Task.Run(() => {
                    try
                    {
                        return DataAccess.Account.GetStaffInfor(staff._Username);
                    }
                    catch
                    {
                        return null;
                    }
                });
                if (staffInfo == null) throw new Exception("Đã xảy ra lỗi khi kết nối đến server");
                if (staffInfo.Rows.Count > 0)
                {
                    staff._Pass = staffInfo.Rows[0].ItemArray[3].ToString();
                    staff._ID = Convert.ToInt32(staffInfo.Rows[0].ItemArray[0]);
                }
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
    }
}
