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
        public Item_ReportBill(int billID, string billDateCre, int roomID, string staffName, int totalMoney, int serviceTotalMoney, int discount, bool roomIsRenting)
        {
            InitializeComponent();

            if (roomIsRenting)
            {
                pbMenu.Show();
            }
            else
            {
                pbMenu.Hide();
            }

            this.roomIsRenting = roomIsRenting;
            lbBillID.MainText = billID.ToString();
            lbBillDateCre.MainText = billDateCre;
            lbRoomID.MainText = roomID.ToString();
            lbStaffName.MainText = staffName;
            lbRoomCharge.MainText = totalMoney.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            lbServiceCharge.MainText = serviceTotalMoney.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            lbDiscount.MainText = discount.ToString() + " %";
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
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            zeroitMaterialContextMenuStrip1.Show(MousePosition);
        }
    }
}
