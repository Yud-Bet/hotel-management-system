﻿using HotelManagement.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Form_Main : MetroFramework.Forms.MetroForm
    {
        private string Username;
        public Form_Main(string Username)
        {
            InitializeComponent();
            this.Username = Username;
            LoadStaffInfo();
            this.DoubleBuffered = true;
        }

        #region Icon
        private static Bitmap ChoseRoomIcon = Resources.icRoom2;
        private static Bitmap EatingServicesIcon = Resources.icEatService;
        private static Bitmap ChoseEatingServicesIcon = Resources.icEatService2;
        private static Bitmap LaundryServicesIcon = Resources.icLaundryService;
        private static Bitmap RevenueIcon = Resources.icRevenue;
        private static Bitmap ChoseRevenueIcon = Resources.icRevenue2;
        private static Bitmap ChoseBillIcon = Resources.icBill2;
        private static Bitmap BillIcon = Resources.icBill;
        private static Bitmap ChoseStaffIcon = Resources.icStaff2;
        private static Bitmap StaffIcon = Resources.icStaff;
        private static Bitmap ChoseCustomerIcon = Resources.icCustomer2;
        private static Bitmap CustomerIcon = Resources.icCustomer;
        private static Bitmap ChoseWarehouseIcon = Resources.icWarehouse2;
        private static Bitmap WarehouseIcon = Resources.icWarehouse;
        private static Bitmap ChoseServicesIcon = Resources.icSevice2;
        private static Bitmap ServicesIcon = Resources.icSevice;
        private static Bitmap ChoseSubservicesIcon = Resources.icSubService2;
        private static Bitmap SubservicesIcon = Resources.icSubService;
        private static Bitmap RoomIcon = Resources.icRoom;
        private static Bitmap VerticalArrow = Resources.icVerticalArrow2;
        private static Bitmap HorizontalArrow = Resources.icHorizontalArrow;
        private static Bitmap ChoseHorizontalArrow = Resources.icHorizontalArrow2;
        private static Bitmap ManageIcon = Resources.icManage;
        private static Bitmap ChoseManageIcon = Resources.icManage2;
        private static Bitmap ChoseLaundryServicesIcon = Resources.icLaundryService2;
        private static Bitmap ReportIcon = Resources.icReport;
        private static Bitmap ChoseReportIcon = Resources.icReport2;
        #endregion

        private bool isChoosebtRoom = false, isChoosebtService = false, isChoosebtReport = false, isChoosebtManage = false,
                    isChoosebtEatService = false, isChoosebtLaundryService = false, isChoosebtRevenue = false, isChoosebtBill = false,
                    isChoosebtStaff = false, isChoosebtCustomer = false, isChoosebtWarehouse = false, isChoosebtSubService = false;
        private Color colorChoose = Color.FromArgb(27, 152, 224), colorNChoose = Color.Black;

        private void LoadStaffInfo()
        {
            try
            {
                DTO.StaffOverview staff = new DTO.StaffOverview(Username);
                lbStaffname.Text = staff.Name;
                lbStaffPosition.Text = staff.Position;
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải thông tin người dùng", "Lỗi");
            }
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            isChoosebtRoom = true;
            ChooseAButton();
            setStatus(pbRoom, lbRoom, pnTickChooseBtRoom, ChoseRoomIcon, true);
            pnSubMenu_Service.Hide();
            pnSubMenu_Report.Hide();
            pnSubMenu_Manage.Hide();
            Form_Room temp = new Form_Room(Username, this);
            panel4.Controls.Add(temp);
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
            setStatus(pbEatService, lbEatService, EatingServicesIcon, false);
            setStatus(pbLaundryService, lbLaundryService, LaundryServicesIcon, false);
        }

        private void resetReportSubmenu()
        {
            isChoosebtRevenue = false;
            isChoosebtBill = false;
            setStatus(pbRevenue, lbRevenue, RevenueIcon, false);
            setStatus(pbBill, lbBill, BillIcon, false);
        }

        private void resetManageSubmenu()
        {
            isChoosebtStaff = false;
            isChoosebtCustomer = false;
            isChoosebtWarehouse = false;
            isChoosebtSubService = false;
            setStatus(pbStaff, lbStaff, StaffIcon, false);
            setStatus(pbCustomer, lbCustomer, CustomerIcon, false);
            setStatus(pbWarehouse, lbWarehouse, WarehouseIcon, false);
            setStatus(pbSubService, lbSubService, SubservicesIcon, false);
        }

        private void ResetStatus()
        {
            if (isChoosebtRoom)
            {
                isChoosebtRoom = false;
                setStatus(pbRoom, lbRoom, pnTickChooseBtRoom, RoomIcon, false);
            }
            if (isChoosebtService)
            {
                isChoosebtService = false;
                setStatus(pbService, lbService, pnTickChooseBtService, ServicesIcon, false);
                pbArrow_Service.Image = HorizontalArrow;
                pnSubMenu_Service.Hide();
                resetServiceSubmenu();
            }
            if (isChoosebtReport)
            {
                isChoosebtReport = false;
                setStatus(pbReport, lbReport, pnTickChooseBtReport, ReportIcon, false);
                pbArrow_Report.Image = HorizontalArrow;
                pnSubMenu_Report.Hide();
                resetReportSubmenu();
                
            }
            if (isChoosebtManage)
            {
                isChoosebtManage = false;
                setStatus(pbManage, lbManage, pnTickChooseBtManage, ManageIcon, false);
                pbArrow_Manage.Image = HorizontalArrow;
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
                setStatus(pbRoom, lbRoom, pnTickChooseBtRoom, ChoseRoomIcon, true);

                panel4.Controls.Clear();
                panel4.Controls.Add(new Form_Room(Username, this));
            }
        }

        private void btRoom_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtRoom)
            {
                setStatus(pbRoom, lbRoom, pnTickChooseBtRoom, ChoseRoomIcon, true);
            }
        }

        private void btRoom_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtRoom)
            {
                setStatus(pbRoom, lbRoom, pnTickChooseBtRoom, RoomIcon, false);
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
                setStatus(pbService, lbService, pnTickChooseBtService, ChoseServicesIcon, true);
                pbArrow_Service.Image = VerticalArrow;
                pnSubMenu_Service.Show();
            }
        }

        private void btService_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtService)
            {
                setStatus(pbService, lbService, pnTickChooseBtService, ChoseServicesIcon, true);
                pbArrow_Service.Image = ChoseHorizontalArrow;
            }
        }

        private void btService_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtService)
            {
                setStatus(pbService, lbService, pnTickChooseBtService, ServicesIcon, false);
                pbArrow_Service.Image = HorizontalArrow;
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
                setStatus(pbReport, lbReport, pnTickChooseBtReport, ChoseReportIcon, true);
                pbArrow_Report.Image = VerticalArrow;
                pnSubMenu_Report.Show();
            }        
        }

        private void btReport_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtReport)
            {
                setStatus(pbReport, lbReport, pnTickChooseBtReport, ChoseReportIcon, true);
                pbArrow_Report.Image = ChoseHorizontalArrow;
            }
        }

        private void btReport_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtReport)
            {
                setStatus(pbReport, lbReport, pnTickChooseBtReport, ReportIcon, false);
                pbArrow_Report.Image = HorizontalArrow;
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
                setStatus(pbManage, lbManage, pnTickChooseBtManage, ChoseManageIcon, true);
                pbArrow_Manage.Image = VerticalArrow;
                pnSubMenu_Manage.Show();
            }
        }

        private void btManage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtManage)
            {
                setStatus(pbManage, lbManage, pnTickChooseBtManage, ChoseManageIcon, true);
                pbArrow_Manage.Image = ChoseHorizontalArrow;
            }
        }

        private void btManage_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtManage)
            {
                setStatus(pbManage, lbManage, pnTickChooseBtManage, ManageIcon, false);
                pbArrow_Manage.Image = HorizontalArrow;
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
                setStatus(pbEatService, lbEatService, ChoseEatingServicesIcon, true);

                panel4.Controls.Clear();
                panel4.Controls.Add(new Form_EatService(this, Username));
            }
        }

        private void btEatService_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtEatService)
            {
                setStatus(pbEatService, lbEatService, ChoseEatingServicesIcon, true);
            }
        }

        private void btEatService_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtEatService)
            {
                setStatus(pbEatService, lbEatService, EatingServicesIcon, false);
            }
        }

        private void btLaundryService_Click(object sender, EventArgs e)
        {
            if (!isChoosebtLaundryService)
            {
                resetServiceSubmenu();
                isChoosebtLaundryService = true;
                setStatus(pbLaundryService, lbLaundryService, ChoseLaundryServicesIcon, true);

                panel4.Controls.Clear();
                panel4.Controls.Add(new Form_LaundryService(this));
            }
        }

        private void btLaundryService_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtLaundryService)
            {
                setStatus(pbLaundryService, lbLaundryService, ChoseLaundryServicesIcon, true);
            }
        }

        private void btLaundryService_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtLaundryService)
            {
                setStatus(pbLaundryService, lbLaundryService, LaundryServicesIcon, false);
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
                setStatus(pbRevenue, lbRevenue, ChoseRevenueIcon, true);
            }
        }

        private void btRevenue_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtRevenue)
            {
                setStatus(pbRevenue, lbRevenue, ChoseRevenueIcon, true);
            }
        }

        private void btRevenue_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtRevenue)
            {
                setStatus(pbRevenue, lbRevenue, RevenueIcon, false);
            }
        }

        private void pnBill_Click(object sender, EventArgs e)
        {
            if (!isChoosebtBill)
            {
                resetReportSubmenu();
                isChoosebtBill = true;
                setStatus(pbBill, lbBill, ChoseBillIcon, true);
            }
        }

        private void pnBill_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtBill)
            {
                setStatus(pbBill, lbBill, ChoseBillIcon, true);
            }
        }

        private void pnBill_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtBill)
            {
                setStatus(pbBill, lbBill, BillIcon, false);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btRoom_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        #region SubMenu Manage Event

        private void btStaff_Click(object sender, EventArgs e)
        {
            if (!isChoosebtStaff)
            {
                resetManageSubmenu();
                isChoosebtStaff = true;
                setStatus(pbStaff, lbStaff, ChoseStaffIcon, true);
            }
        }

        private void btStaff_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtStaff)
            {
                setStatus(pbStaff, lbStaff, ChoseStaffIcon, true);
            }
        }

        private void btStaff_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtStaff)
            {
                setStatus(pbStaff, lbStaff, StaffIcon, false);
            }
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            if (!isChoosebtCustomer)
            {
                resetManageSubmenu();
                isChoosebtCustomer = true;
                setStatus(pbCustomer, lbCustomer, ChoseCustomerIcon, true);
            }
        }

        private void btCustomer_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtCustomer)
            {
                setStatus(pbCustomer, lbCustomer, ChoseCustomerIcon, true);
            }
        }

        private void btCustomer_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtCustomer)
            {
                setStatus(pbCustomer, lbCustomer, CustomerIcon, false);
            }
        }

        private void btWarehouse_Click(object sender, EventArgs e)
        {
            if (!isChoosebtWarehouse)
            {
                resetManageSubmenu();
                isChoosebtWarehouse = true;
                setStatus(pbWarehouse, lbWarehouse, ChoseWarehouseIcon, true);
            }
        }

        private void btWarehouse_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtWarehouse)
            {
                setStatus(pbWarehouse, lbWarehouse, ChoseWarehouseIcon, true);
            }
        }

        private void btWarehouse_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtWarehouse)
            {
                setStatus(pbWarehouse, lbWarehouse, WarehouseIcon, false);
            }
        }

        private void btService_manage_Click(object sender, EventArgs e)
        {
            if (!isChoosebtSubService)
            {
                resetManageSubmenu();
                isChoosebtSubService = true;
                setStatus(pbSubService, lbSubService, ChoseSubservicesIcon, true);
            }
        }

        private void btService_manage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isChoosebtSubService)
            {
                setStatus(pbSubService, lbSubService, ChoseSubservicesIcon, true);
            }
        }

        private void btService_manage_MouseLeave(object sender, EventArgs e)
        {
            if (!isChoosebtSubService)
            {
                setStatus(pbSubService, lbSubService, SubservicesIcon, false);
            }
        }

        #endregion
    }
}
