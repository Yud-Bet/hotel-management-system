using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Form_ReportBill : UserControl
    {
        public Form_ReportBill()
        {
            InitializeComponent();
            //pnAddItem.Controls.Add(new Item_ReportBill(123, "12/12/2020", 122, "Lê Trung Hiếu", 1000000000, 200050, 20, true));
            //pnAddItem.Controls.Add(new Item_ReportBill(123, "12/12/2020", 122, "Lê Trung Hiếu", 1000000, 200050, 20, false));
            DataTable dataStaff = DataAccess.Report.GetAllStaffInfo();
            for (int i = 0; i < dataStaff.Rows.Count; i++)
            {
                cbStaff.Items.Add(dataStaff.Rows[i].ItemArray[0].ToString() + " | " + dataStaff.Rows[i].ItemArray[1].ToString());
            }
            loadData();
        }

        private void loadData()
        {
            while (pnAddItem.Controls.Count > 0) pnAddItem.Controls[0].Dispose();
            GC.Collect();

            DataTable dataBillInfo = DataAccess.Report.GetAllBillInfo(dtStart.Value, dtEnd.Value, cbStaff.SelectedIndex, cbSort.SelectedIndex);
            for (int i=0;i<dataBillInfo.Rows.Count; i++)
            {
                Item_ReportBill itemBillInfo = new Item_ReportBill(
                    Convert.ToInt32(dataBillInfo.Rows[i].ItemArray[0]),
                    Convert.ToDateTime(dataBillInfo.Rows[i].ItemArray[1].ToString()).ToShortDateString(),
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

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void cbRoomReservationIsRenting_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
