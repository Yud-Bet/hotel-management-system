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
    public partial class Form_CustomerBill : MetroFramework.Forms.MetroForm
    {
        public Form_CustomerBill(int CustomerID)
        {
            InitializeComponent();
            this.customerID = CustomerID;
            loadData();
        }
        #region properties
        int customerID;
        Form_Customer parentForm;
        #endregion
        private void loadData()
        {
            DataTable dataBillInfo = DataAccess.Bill.GetBillInfoOfCustomer(this.customerID);
            for (int i = 0; i < dataBillInfo.Rows.Count; i++)
            {
                Item_ReportBill itemBillInfo = new Item_ReportBill( this,
                    Convert.ToInt32(dataBillInfo.Rows[i].ItemArray[0]),
                    Convert.ToDateTime(dataBillInfo.Rows[i].ItemArray[1]).ToShortDateString(),
                    Convert.ToInt32(dataBillInfo.Rows[i].ItemArray[2]),
                    dataBillInfo.Rows[i].ItemArray[3].ToString(),
                    Convert.ToInt32(dataBillInfo.Rows[i].ItemArray[4]),
                    Convert.ToInt32(dataBillInfo.Rows[i].ItemArray[5]),
                    Convert.ToInt32(dataBillInfo.Rows[i].ItemArray[6]),
                    //Convert.ToInt32(dataBillInfo.Rows[i].ItemArray[7]),
                    0,
                    true
                    );
                pnAddItem.Controls.Add(itemBillInfo);
            }

        }
    }
}
