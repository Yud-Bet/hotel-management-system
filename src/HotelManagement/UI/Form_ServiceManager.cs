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
    public partial class Form_ServiceManager : UserControl
    {
        public Form_ServiceManager()
        {
            InitializeComponent();

            pnToAddItem.Controls.Add(new Item_ServiceManager(this));
        }

        #region properties
        public FlowLayoutPanel _pnToAddItem
        {
            get { return pnToAddItem; }
        }
        #endregion

        private void btAddService_Click(object sender, EventArgs e)
        {
            (new Form_AddEditService(null, this, ServiceManagerType.AddEatService)).ShowDialog();
        }

        private void btItemLaundry_Click(object sender, EventArgs e)
        {
            (new Form_AddEditService(null, this, ServiceManagerType.EditWashService)).ShowDialog();
        }

        private void btItemIron_Click(object sender, EventArgs e)
        {
            (new Form_AddEditService(null, this, ServiceManagerType.EditIronService)).ShowDialog();
        }

        private void pnToAddItem_ControlAdded(object sender, ControlEventArgs e)
        {
            lbListServiceIsEmpty.Hide();
        }

        private void pnToAddItem_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (pnToAddItem.Controls.Count == 1)
            {
                lbListServiceIsEmpty.Show();
            }
        }
    }
}
