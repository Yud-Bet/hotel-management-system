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
    public partial class Form_Customer : UserControl
    {
        public Form_Customer()
        {
            InitializeComponent();

            pnAddItem.Controls.Add(new Item_Customer(123, "Lê Trung HIếu", "123456789", "1234567890", DateTime.Now, true, "Thừa Thiên Huế", 1234567890, this));
            pnAddItem.Controls.Add(new Item_Customer(123, "Lê Trung HIếu", "123456789", "1234567890", DateTime.Now, true, "Thừa Thiên Huế", 1234567890, this));
            pnAddItem.Controls.Add(new Item_Customer(123, "Lê Trung HIếu", "123456789", "1234567890", DateTime.Now, true, "Thừa Thiên Huế", 1234567890, this));
            pnAddItem.Controls.Add(new Item_Customer(123, "Lê Trung HIếu", "123456789", "1234567890", DateTime.Now, true, "Thừa Thiên Huế", 1234567890, this));
            pnAddItem.Controls.Add(new Item_Customer(123, "Lê Trung HIếu", "123456789", "1234567890", DateTime.Now, true, "Thừa Thiên Huế", 1234567890, this));
        }

        #region properties
        public FlowLayoutPanel _pnToAddItem
        {
            get { return pnAddItem; }
        }
        #endregion

        private void timerGC_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
