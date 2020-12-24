using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace HotelManagement.UI
{
    public partial class Item_ReportBill : UserControl
    {
        bool ofCustommer = false;
        public BillType billType;
        Form_ReportBill ParentRefRep;
        Form_CustomerBill ParentRefCus;
        CancellationTokenSource cts;
        public Item_ReportBill(Form_CustomerBill ParentRef, int billID, string billDateCre, int roomID, string staffName, int roomCharge,
                                int serviceTotalMoney, int totalMoney, int discount, bool roomIsRenting)
        {
            InitializeComponent();
            this.ofCustommer = true;
            this.billID = billID;

            this.roomIsRenting = roomIsRenting;
            lbBillID.MainText = billID.ToString();
            lbBillDateCre.MainText = billDateCre;
            lbRoomReservationID.MainText = roomID.ToString();
            lbStaffName.MainText = staffName;
            lbRoomCharge.MainText = roomCharge.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            lbServiceCharge.MainText = serviceTotalMoney.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            lbTotalMoney.MainText = totalMoney.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            //lbRoomCharge.MainText = discount.ToString() + " %";

            this.ParentRefCus = ParentRef;
            cts = new CancellationTokenSource();
            this.Disposed += delegate { zeroitUltraTextBox1.MouseMove -= Item_ReportBill_MouseMove; };
        }

        public Item_ReportBill(Form_ReportBill ParentRef, int billID, string billDateCre, int roomID, string staffName, int roomCharge,
                                int serviceTotalMoney, int totalMoney, int discount, bool roomIsRenting)
        {
            InitializeComponent();
            this.ofCustommer = false;
            this.billID = billID;

            this.roomIsRenting = roomIsRenting;
            lbBillID.MainText = billID.ToString();
            lbBillDateCre.MainText = billDateCre;
            lbRoomReservationID.MainText = roomID.ToString();
            lbStaffName.MainText = staffName;
            lbRoomCharge.MainText = roomCharge.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            lbServiceCharge.MainText = serviceTotalMoney.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            lbTotalMoney.MainText = totalMoney.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            //lbRoomCharge.MainText = discount.ToString() + " %";

            this.ParentRefRep = ParentRef;
            cts = new CancellationTokenSource();
            this.Disposed += delegate { zeroitUltraTextBox1.MouseMove -= Item_ReportBill_MouseMove; };
        }

        #region properties
        bool roomIsRenting = false;

        private int billID;
        public int _billID
        {
            get { return billID; }
            set { 
                billID = value;
                lbBillID.MainText = value.ToString();
            }
        }


        #endregion

        private void Item_ReportBill_MouseMove(object sender, MouseEventArgs e)
        {
            zeroitUltraTextBox1.Focus();

            GC.Collect();
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            menu.Show(new Point(MousePosition.X - menu.Width, MousePosition.Y));
        }

        private void menuItemDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ofCustommer)
                {
                    OverlayForm overlay = new OverlayForm(ParentRefRep.ParentRef, new LoadingForm(cts.Token));
                    overlay.Show();
                }
                else
                {
                    OverlayForm overlay = new OverlayForm(ParentRefCus, new LoadingForm(cts.Token));
                    overlay.Show();
                }
                BillPrintPreview.Document = PrintDocument;
                BillPrintPreview.ShowDialog();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Lỗi khi kết nối đến server", "Lỗi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
            }
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (!ofCustommer && billType == BillType.Services)
            {
                DataTable SvcBillDetail = DataAccess.Services.GetServiceBillOnlyDetail(billID);
                DrawBill drawBill = new DrawBill(e.Graphics);
                drawBill.drawBillHeader();
                drawBill.drawServiceInfo();
                int TotalMoney = 0;
                for (int i = 0; i < SvcBillDetail.Rows.Count; i++)
                {
                    string ItemName = SvcBillDetail.Rows[i].ItemArray[0].ToString();
                    int ItemCount = Convert.ToInt32(SvcBillDetail.Rows[i].ItemArray[1]);
                    int ItemPrice = Convert.ToInt32(SvcBillDetail.Rows[i].ItemArray[2]);
                    int IntoMoney = Convert.ToInt32(SvcBillDetail.Rows[i].ItemArray[3]);
                    drawBill.drawItem(ItemName, ItemCount, ItemPrice, IntoMoney);
                    TotalMoney += ItemCount * ItemPrice;
                }
                //DTO.StaffOverview staff = new DTO.StaffOverview(Username);
                string staffName = SvcBillDetail.Rows[0].ItemArray[4].ToString();
                drawBill.drawEndOfBill(staffName, TotalMoney, 0);
            }
            else
            {
                DTO.RoomServices svc = new DTO.RoomServices(billID, 0, 0);
                DrawBill drawBill = new DrawBill(e.Graphics);
                drawBill.drawBillHeader();
                DataTable additionalData = DataAccess.AdditionalInfoForBillViewing.GetData(billID);
                string CustomerName = additionalData.Rows[0].ItemArray[1].ToString();
                string CustomerPhoneNo = additionalData.Rows[0].ItemArray[2].ToString();
                string CustomerAddr = additionalData.Rows[0].ItemArray[3].ToString();
                string CheckInDate = additionalData.Rows[0].ItemArray[4].ToString();
                string CheckOutDate = additionalData.Rows[0].ItemArray[5].ToString();
                string StaffName = additionalData.Rows[0].ItemArray[6].ToString();
                drawBill.drawCustomerInfo(CustomerName, CustomerPhoneNo, CustomerAddr, CheckInDate, CheckOutDate);
                int TotalMoney = 0;
                for (int i = 0; i < svc.items.Count; i++)
                {
                    drawBill.drawItem(svc.items[i].Name, svc.items[i].Count, svc.items[i].Price, svc.items[i].IntoMoney);
                    TotalMoney += svc.items[i].IntoMoney;
                }
                drawBill.drawEndOfBill(StaffName, TotalMoney, 0);
            }
        }
    }
}
