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
            pnAddItem.Controls.Add(new Item_ReportBill(123, "12/12/2020", 122, "Lê Trung Hiếu", 1000000, 200050, 20, true));
            pnAddItem.Controls.Add(new Item_ReportBill(123, "12/12/2020", 122, "Lê Trung Hiếu", 1000000, 200050, 20, false));
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
