using HotelManagement.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Form_Main : MetroFramework.Forms.MetroForm
    {
        private string Username;
        private Panel pnToAddForm;
        public Form_Main(string Username)
        {
            InitializeComponent();
            createPanelToAddForm();
            this.Username = Username;
            LoadStaffInfo();
            this.DoubleBuffered = true;
        }

        private bool isChoosebtRoom = false, isChoosebtService = false, isChoosebtReport = false, isChoosebtManage = false,
                    isChoosebtEatService = false, isChoosebtLaundryService = false, isChoosebtRevenue = false, isChoosebtBill = false,
                    isChoosebtStaff = false, isChoosebtCustomer = false, isChoosebtWarehouse = false, isChoosebtSubService = false;
        private Color colorChoose = Color.FromArgb(27, 152, 224), colorNChoose = Color.Black;

        void createPanelToAddForm()
        {
            this.pnToAddForm = new Panel();
            this.Controls.Add(pnToAddForm);
            this.pnToAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnToAddForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnToAddForm.Location = new System.Drawing.Point(255, 27);
            this.pnToAddForm.Name = "pnToAddForm";
            this.pnToAddForm.Size = new System.Drawing.Size(968, 666);
            this.pnToAddForm.TabIndex = 1;
        }

        private void LoadStaffInfo()
        {
            DTO.StaffOverview staff = new DTO.StaffOverview(Username);
            lbStaffname.Text = staff.Name;
            lbStaffPosition.Text = staff.Position;
        }
        
        private void Form_Main_Load(object sender, EventArgs e)
        {
            isChoosebtRoom = true;
            ChooseAButton();
            setStatus(pbRoom, lbRoom, pnTickChooseBtRoom, Resources.icRoom2, true);
            pnSubMenu_Service.Hide();
            pnSubMenu_Report.Hide();
            pnSubMenu_Manage.Hide();
            Form_Room temp = new Form_Room(Username);
            pnToAddForm.Controls.Add(temp);
        }

        private void setStatus(PictureBox pb, Label lb, Panel pn, Image img, bool stt)
        {
            if (stt)
            {
                pn.Show();
                pb.Image = img;
                lb.ForeColor = colorChoose;
            } else
            {
                pn.Hide();
                pb.Image = img;
                lb.ForeColor = colorNChoose;
            }
        }

        private void setStatus(PictureBox pb, Label lb, Image img, bool stt)
        {
            if (stt)
            {
                pb.Image = img;
                lb.ForeColor = colorChoose;
            }
            else
            {
                pb.Image = img;
                lb.ForeColor = colorNChoose;
            }
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

        private void resetServiceSubmenu()
        {
            isChoosebtEatService = false;
            isChoosebtLaundryService = false;
            setStatus(pbEatService, lbEatService, Resources.icEatService, false);
            setStatus(pbLaundryService, lbLaundryService, Resources.icLaundryService, false);
        }

        private void resetReportSubmenu()
        {
            isChoosebtRevenue = false;
            isChoosebtBill = false;
            setStatus(pbRevenue, lbRevenue, Resources.icRevenue, false);
            setStatus(pbBill, lbBill, Resources.icBill, false);
        }

        private void resetManageSubmenu()
        {
            isChoosebtStaff = false;
            isChoosebtCustomer = false;
            isChoosebtWarehouse = false;
            isChoosebtSubService = false;
            setStatus(pbStaff, lbStaff, Resources.icStaff, false);
            setStatus(pbCustomer, lbCustomer, Resources.icCustomer, false);
            setStatus(pbWarehouse, lbWarehouse, Resources.icWarehouse, false);
            setStatus(pbSubService, lbSubService, Resources.icSubService, false);
        }

        private void ResetStatus()
        {
            if (isChoosebtRoom)
            {
                isChoosebtRoom = false;
                setStatus(pbRoom, lbRoom, pnTickChooseBtRoom, Resources.icRoom, false);
            }
            if (isChoosebtService)
            {
                isChoosebtService = false;
                setStatus(pbService, lbService, pnTickChooseBtService, Resources.icSevice, false);
                pbArrow_Service.Image = Resources.icHorizontalArrow;
                pnSubMenu_Service.Hide();
                resetServiceSubmenu();
            }
            if (isChoosebtReport)
            {
                isChoosebtReport = false;
                setStatus(pbReport, lbReport, pnTickChooseBtReport, Resources.icReport, false);
                pbArrow_Report.Image = Resources.icHorizontalArrow;
                pnSubMenu_Report.Hide();
                resetReportSubmenu();
                
            }
            if (isChoosebtManage)
            {
                isChoosebtManage = false;
                setStatus(pbManage, lbManage, pnTickChooseBtManage, Resources.icManage, false);
                pbArrow_Manage.Image = Resources.icHorizontalArrow;
                pnSubMenu_Manage.Hide();
                resetManageSubmenu();
            }
        }

        #region btRoom Event

        private void btRoom_Click(object sender, EventArgs e)
        {
            if (!isChoosebtRoom)
            {
                ResetStatus();
                isChoosebtRoom = true;
                setStatus(pbRoom, lbRoom, pnTickChooseBtRoom, Resources.icRoom2, true);

                //pnToAddForm.Controls.Clear();
                pnToAddForm.Dispose();
                System.GC.Collect();
                createPanelToAddForm();
                pnToAddForm.Controls.Add(new Form_Room(Username));
            }
        }

        private void btRoom_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtRoom)
            {
                setStatus(pbRoom, lbRoom, pnTickChooseBtRoom, Resources.icRoom2, true);
            }
        }

        private void btRoom_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtRoom)
            {
                setStatus(pbRoom, lbRoom, pnTickChooseBtRoom, Resources.icRoom, false);
            }
        }

        #endregion

        #region btService Event

        private void btService_Click(object sender, EventArgs e)
        {
            if (!isChoosebtService)
            {
                ResetStatus();
                isChoosebtService = true;
                setStatus(pbService, lbService, pnTickChooseBtService, Resources.icSevice2, true);
                pbArrow_Service.Image = Resources.icVerticalArrow2;
                pnSubMenu_Service.Show();
            }
        }

        private void btService_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtService)
            {
                setStatus(pbService, lbService, pnTickChooseBtService, Resources.icSevice2, true);
                pbArrow_Service.Image = Resources.icHorizontalArrow2;
            }
        }

        private void btService_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtService)
            {
                setStatus(pbService, lbService, pnTickChooseBtService, Resources.icSevice, false);
                pbArrow_Service.Image = Resources.icHorizontalArrow;
            }
        }

        #endregion

        #region btReport Event


        private void btReport_Click(object sender, EventArgs e)
        {
            if (!isChoosebtReport)
            {
                ResetStatus();
                isChoosebtReport = true;
                setStatus(pbReport, lbReport, pnTickChooseBtReport, Resources.icReport2, true);
                pbArrow_Report.Image = Resources.icVerticalArrow2;
                pnSubMenu_Report.Show();
            }        
        }

        private void btReport_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtReport)
            {
                setStatus(pbReport, lbReport, pnTickChooseBtReport, Resources.icReport2, true);
                pbArrow_Report.Image = Resources.icHorizontalArrow2;
            }
        }

        private void btReport_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtReport)
            {
                setStatus(pbReport, lbReport, pnTickChooseBtReport, Resources.icReport, false);
                pbArrow_Report.Image = Resources.icHorizontalArrow;
            }
        }

        #endregion

        #region btManage Event

        private void btManage_Click(object sender, EventArgs e)
        {
            if (!isChoosebtManage)
            {
                ResetStatus();
                isChoosebtManage = true;
                setStatus(pbManage, lbManage, pnTickChooseBtManage, Resources.icManage2, true);
                pbArrow_Manage.Image = Resources.icVerticalArrow2;
                pnSubMenu_Manage.Show();

                btStaff_Click(sender, e);
            }
        }

        private void btManage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtManage)
            {
                setStatus(pbManage, lbManage, pnTickChooseBtManage, Resources.icManage2, true);
                pbArrow_Manage.Image = Resources.icHorizontalArrow2;
            }
        }

        private void btManage_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtManage)
            {
                setStatus(pbManage, lbManage, pnTickChooseBtManage, Resources.icManage, false);
                pbArrow_Manage.Image = Resources.icHorizontalArrow;
            }
        }

        #endregion

        #region SubMenu Service Event

        private void btEatService_Click(object sender, EventArgs e)
        {
            if (!isChoosebtEatService)
            {
                resetServiceSubmenu();
                isChoosebtEatService = true;
                setStatus(pbEatService, lbEatService, Resources.icEatService2, true);

                pnToAddForm.Dispose();
                System.GC.Collect();
                createPanelToAddForm();
                pnToAddForm.Controls.Add(new Form_EatService(Username));
            }
        }

        private void btEatService_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtEatService)
            {
                setStatus(pbEatService, lbEatService, Resources.icEatService2, true);
            }
        }

        private void btEatService_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtEatService)
            {
                setStatus(pbEatService, lbEatService, Resources.icEatService, false);
            }
        }

        private void btLaundryService_Click(object sender, EventArgs e)
        {
            if (!isChoosebtLaundryService)
            {
                resetServiceSubmenu();
                isChoosebtLaundryService = true;
                setStatus(pbLaundryService, lbLaundryService, Resources.icLaundryService2, true);

                pnToAddForm.Dispose();
                System.GC.Collect();
                createPanelToAddForm();
                pnToAddForm.Controls.Add(new Form_LaundryService());
            }
        }

        private void btLaundryService_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtLaundryService)
            {
                setStatus(pbLaundryService, lbLaundryService, Resources.icLaundryService2, true);
            }
        }

        private void btLaundryService_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtLaundryService)
            {
                setStatus(pbLaundryService, lbLaundryService, Resources.icLaundryService, false);
            }
        }

        #endregion

        #region SubMenu Report Event

        private void btRevenue_Click(object sender, EventArgs e)
        {
            if (!isChoosebtRevenue)
            {
                resetReportSubmenu();
                isChoosebtRevenue = true;
                setStatus(pbRevenue, lbRevenue, Resources.icRevenue2, true);

                pnToAddForm.Dispose();
                System.GC.Collect();
                createPanelToAddForm();
                pnToAddForm.Controls.Add(new Form_Revenue());
            }
        }

        private void btRevenue_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtRevenue)
            {
                setStatus(pbRevenue, lbRevenue, Resources.icRevenue2, true);
            }
        }

        private void btRevenue_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtRevenue)
            {
                setStatus(pbRevenue, lbRevenue, Resources.icRevenue, false);
            }
        }

        private void pnBill_Click(object sender, EventArgs e)
        {
            if (!isChoosebtBill)
            {
                resetReportSubmenu();
                isChoosebtBill = true;
                setStatus(pbBill, lbBill, Resources.icBill2, true);

                pnToAddForm.Dispose();
                System.GC.Collect();
                createPanelToAddForm();
                pnToAddForm.Controls.Add(new Form_ReportBill());
            }
        }

        private void pnBill_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtBill)
            {
                setStatus(pbBill, lbBill, Resources.icBill2, true);
            }
        }

        private void pnBill_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtBill)
            {
                setStatus(pbBill, lbBill, Resources.icBill, false);
            }
        }

        private void pbStaffAvatar_Click(object sender, EventArgs e)
        {
            Form_ChargePassword temp = new Form_ChargePassword(this.Username);
            temp.ShowDialog();

        }

        #endregion

        #region SubMenu Manage Event

        private void btStaff_Click(object sender, EventArgs e)
        {
            if (!isChoosebtStaff)
            {
                resetManageSubmenu();
                isChoosebtStaff = true;
                setStatus(pbStaff, lbStaff, Resources.icStaff2, true);

                pnToAddForm.Dispose();
                System.GC.Collect();
                createPanelToAddForm();
                pnToAddForm.Controls.Add(new Form_Staff());
            }
        }

        private void btStaff_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtStaff)
            {
                setStatus(pbStaff, lbStaff, Resources.icStaff2, true);
            }
        }

        private void btStaff_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtStaff)
            {
                setStatus(pbStaff, lbStaff, Resources.icStaff, false);
            }
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            if (!isChoosebtCustomer)
            {
                resetManageSubmenu();
                isChoosebtCustomer = true;
                setStatus(pbCustomer, lbCustomer, Resources.icCustomer2, true);
            }
        }

        private void btCustomer_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtCustomer)
            {
                setStatus(pbCustomer, lbCustomer, Resources.icCustomer2, true);
            }
        }

        private void btCustomer_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtCustomer)
            {
                setStatus(pbCustomer, lbCustomer, Resources.icCustomer, false);
            }
        }

        private void btWarehouse_Click(object sender, EventArgs e)
        {
            if (!isChoosebtWarehouse)
            {
                resetManageSubmenu();
                isChoosebtWarehouse = true;
                setStatus(pbWarehouse, lbWarehouse, Resources.icWarehouse2, true);
            }
        }

        private void btWarehouse_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtWarehouse)
            {
                setStatus(pbWarehouse, lbWarehouse, Resources.icWarehouse2, true);
            }
        }

        private void btWarehouse_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtWarehouse)
            {
                setStatus(pbWarehouse, lbWarehouse, Resources.icWarehouse, false);
            }
        }

        private void btService_manage_Click(object sender, EventArgs e)
        {
            if (!isChoosebtSubService)
            {
                resetManageSubmenu();
                isChoosebtSubService = true;
                setStatus(pbSubService, lbSubService, Resources.icSubService2, true);
            }
        }

        private void btService_manage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtSubService)
            {
                setStatus(pbSubService, lbSubService, Resources.icSubService2, true);
            }
        }

        private void btService_manage_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtSubService)
            {
                setStatus(pbSubService, lbSubService, Resources.icSubService, false);
            }
        }

        #endregion
    }
}
