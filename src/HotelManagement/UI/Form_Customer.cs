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
            load_AllCustomer();
        }

        private void load_AllCustomer()
        {
            DataTable dataAllCustomer = DataAccess.Manager.GetAllCustomerInfo(Convert.ToInt32(cbSort.SelectedIndex));
            pnAddItem.Controls.Clear();
            for (int i=0; i<dataAllCustomer.Rows.Count; i++)
            {

                pnAddItem.Controls.Add(new Item_Customer(Convert.ToInt32(dataAllCustomer.Rows[i].ItemArray[0]),
                                                        dataAllCustomer.Rows[i].ItemArray[1].ToString(),
                                                        dataAllCustomer.Rows[i].ItemArray[2].ToString(),
                                                        dataAllCustomer.Rows[i].ItemArray[3].ToString(),
                                                        Convert.ToDateTime(dataAllCustomer.Rows[i].ItemArray[4]),
                                                        Convert.ToBoolean(dataAllCustomer.Rows[i].ItemArray[5]),
                                                        dataAllCustomer.Rows[i].ItemArray[6].ToString(),
                                                        Convert.ToInt32(dataAllCustomer.Rows[i].ItemArray[7]),
                                                        this));
            }
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

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_AllCustomer();
        }
    }
}
