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
    public partial class Form_Main : Form
    {
        private string Username;
        public Form_Main(string Username)
        {
            InitializeComponent();
            this.Username = Username;
            LoadStaffInfo();
        }

        private bool isChoosebtRoom = false, isChoosebtService = false, isChoosebtReport = false, isChoosebtManage = false;

        private void LoadStaffInfo()
        {
            DataTable data = DataAccess.Account.GetStaffInfor(Username);
            if (data.Rows.Count > 0)
            {
                lbStaffname.Text = data.Rows[0].ItemArray[0].ToString();
                lbDuty.Text = ((StaffPosition)Convert.ToInt32(data.Rows[0].ItemArray[1]) == StaffPosition.Manager) ?
                    "Manager" : "Receptionist";
            }
            else MessageBox.Show("Lỗi khi tải thông tin  nhân viên");
            
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            isChoosebtRoom = true;
            ChooseAButton();
            pnSubMenu_Service.Hide();
            pnSubMenu_Report.Hide();
            pnSubMenu_Manage.Hide();
            Form_Room temp = new Form_Room();
            panel4.Controls.Add(temp);
        }

        private void ChooseAButton()
        {
            if (!isChoosebtRoom)
            {
                pnTickChooseBtRoom.Hide();
            }
            if (!isChoosebtService)
            {
                pnTickChooseBtService.Hide();
            }
            if (!isChoosebtReport)
            {
                pnTickChooseBtReport.Hide();
            }
            if (!isChoosebtManage)
            {
                pnTickChooseBtManage.Hide();
            }
        }

        private void ResetStatus()
        {
            if (isChoosebtRoom)
            {
                isChoosebtRoom = false;
                pnTickChooseBtRoom.Hide();
            }
            if (isChoosebtService)
            {
                isChoosebtService = false;
                pnTickChooseBtService.Hide();
                pbArrow_Service.Image = Resources.icHorizontalArrow;
                pnSubMenu_Service.Hide();
            }
            if (isChoosebtReport)
            {
                isChoosebtReport = false;
                pnTickChooseBtReport.Hide();
                pbArrow_Report.Image = Resources.icHorizontalArrow;
                pnSubMenu_Report.Hide();
            }
            if (isChoosebtManage)
            {
                isChoosebtManage = false;
                pnTickChooseBtManage.Hide();
                pbArrow_Manage.Image = Resources.icHorizontalArrow;
                pnSubMenu_Manage.Hide();
            }
        }

        #region btRoom Event

        private void btRoom_Click(object sender, EventArgs e)
        {
            ResetStatus();
            isChoosebtRoom = true;
            pnTickChooseBtRoom.Show();
        }

        private void btRoom_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtRoom)
            {
                pnTickChooseBtRoom.Show();
            }
            btRoom.BackColor = Color.FromArgb(246, 246, 246);
        }

        private void btRoom_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtRoom)
            {
                pnTickChooseBtRoom.Hide();
            }
            btRoom.BackColor = Color.White;
        }

        #endregion

        #region btService Event

        private void btService_Click(object sender, EventArgs e)
        {
            ResetStatus();
            isChoosebtService = true;
            pnTickChooseBtService.Show();
            pbArrow_Service.Image = Resources.icVerticalArrow;
            pnSubMenu_Service.Show();
        }

        private void btService_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtService)
            {
                pnTickChooseBtService.Show();
            }
            btService.BackColor = Color.FromArgb(246, 246, 246);
        }

        private void btService_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtService)
            {
                pnTickChooseBtService.Hide();
            }
            btService.BackColor = Color.White;
        }

        #endregion

        #region btReport Event


        private void btReport_Click(object sender, EventArgs e)
        {
            ResetStatus();
            isChoosebtReport = true;
            pnTickChooseBtReport.Show();
            pbArrow_Report.Image = Resources.icVerticalArrow;
            pnSubMenu_Report.Show();
        }

        private void btReport_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtReport)
            {
                pnTickChooseBtReport.Show();
            }
            btReport.BackColor = Color.FromArgb(246, 246, 246);
        }

        private void btReport_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtReport)
            {
                pnTickChooseBtReport.Hide();
            }
            btReport.BackColor = Color.White;
        }

        #endregion

        #region btManage Event

        private void btManage_Click(object sender, EventArgs e)
        {
            ResetStatus();
            isChoosebtManage = true;
            pnTickChooseBtManage.Show();
            pbArrow_Manage.Image = Resources.icVerticalArrow;
            pnSubMenu_Manage.Show();
        }

        private void btManage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtManage)
            {
                pnTickChooseBtManage.Show();
            }
            btManage.BackColor = Color.FromArgb(246, 246, 246);
        }

        private void btManage_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtManage)
            {
                pnTickChooseBtManage.Hide();
            }
            btManage.BackColor = Color.White;
        }

        #endregion

        #region SubMenu Service Event

        private void btEatService_Click(object sender, EventArgs e)
        {

        }

        private void btEatService_MouseMove(object sender, MouseEventArgs e)
        {
            btEatService.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btEatService_MouseLeave(object sender, EventArgs e)
        {
            btEatService.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void btLaundryService_Click(object sender, EventArgs e)
        {

        }

        private void btLaundryService_MouseMove(object sender, MouseEventArgs e)
        {
            btLaundryService.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btLaundryService_MouseLeave(object sender, EventArgs e)
        {
            btLaundryService.BackColor = Color.FromArgb(245, 245, 245);
        }

        #endregion

        #region SubMenu Report Event

        private void btRevenue_Click(object sender, EventArgs e)
        {

        }

        private void btRevenue_MouseMove(object sender, MouseEventArgs e)
        {
            btRevenue.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btRevenue_MouseLeave(object sender, EventArgs e)
        {
            btRevenue.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void pnBill_Click(object sender, EventArgs e)
        {

        }

        private void pnBill_MouseMove(object sender, MouseEventArgs e)
        {
            pnBill.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void pnBill_MouseLeave(object sender, EventArgs e)
        {
            pnBill.BackColor = Color.FromArgb(245, 245, 245);
        }

        #endregion

        #region SubMenu Manage Event

        private void btStaff_Click(object sender, EventArgs e)
        {

        }

        private void btStaff_MouseMove(object sender, MouseEventArgs e)
        {
            btStaff.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btStaff_MouseLeave(object sender, EventArgs e)
        {
            btStaff.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btCustomer_MouseMove(object sender, MouseEventArgs e)
        {
            btCustomer.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btCustomer_MouseLeave(object sender, EventArgs e)
        {
            btCustomer.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void btWarehouse_Click(object sender, EventArgs e)
        {

        }

        private void btWarehouse_MouseMove(object sender, MouseEventArgs e)
        {
            btWarehouse.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btWarehouse_MouseLeave(object sender, EventArgs e)
        {
            btWarehouse.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void btService_manage_Click(object sender, EventArgs e)
        {
            
        }

        private void btService_manage_MouseMove(object sender, MouseEventArgs e)
        {
            btService_manage.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btService_manage_MouseLeave(object sender, EventArgs e)
        {
            btService_manage.BackColor = Color.FromArgb(245, 245, 245);
        }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
