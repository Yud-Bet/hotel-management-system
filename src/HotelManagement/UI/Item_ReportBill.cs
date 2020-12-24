using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace HotelManagement.UI
{
    public partial class Item_ReportBill : UserControl
    {
        public Item_ReportBill(int billID, string billDateCre, int roomID, string staffName, int roomCharge,
                                int serviceTotalMoney, int totalMoney, int discount, bool roomIsRenting)
        {
            InitializeComponent();
            BillID = billID;

            this.roomIsRenting = roomIsRenting;
            lbBillID.MainText = billID.ToString();
            lbBillDateCre.MainText = billDateCre;
            lbRoomReservationID.MainText = roomID.ToString();
            lbStaffName.MainText = staffName;
            lbRoomCharge.MainText = roomCharge.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            lbServiceCharge.MainText = serviceTotalMoney.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            lbTotalMoney.MainText = totalMoney.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            //lbRoomCharge.MainText = discount.ToString() + " %";

            this.Disposed += delegate { zeroitUltraTextBox1.MouseMove -= Item_ReportBill_MouseMove; };
        }

        #region properties
        public int BillID;
        public BillType billType;
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
            BillPrintPreview.Document = PrintDocument;
            BillPrintPreview.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (billType == BillType.Services)
            {

            }
            else
            {
                DTO.RoomServices svc = new DTO.RoomServices(billID, 0, 0);
                DrawBill drawBill = new DrawBill(e.Graphics);
                drawBill.drawBillHeader();
                //drawBill.drawCustomerInfo(Customer.Name, RoomID, Customer.PhoneNumber, Customer.Addr,
                //    dtpCheckInDate.Text, dtpCheckOutDate.Text);
                drawBill.drawCustomerInfo("", 1, "", "", "", "");
                int TotalMoney = 0;
                for (int i = 0; i < svc.items.Count; i++)
                {
                    drawBill.drawItem(svc.items[i].Name, svc.items[i].Count, svc.items[i].Price, svc.items[i].IntoMoney);
                    TotalMoney += svc.items[i].IntoMoney;
                }
                drawBill.drawEndOfBill(lbStaffName.MainText, TotalMoney, 0);
            }
        }
    }
}
