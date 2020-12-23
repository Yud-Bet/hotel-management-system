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
            loadAllService();
            //pnToAddItem.Controls.Add(new Item_ServiceManager(this));
        }

        #region properties
        public FlowLayoutPanel _pnToAddItem
        {
            get { return pnToAddItem; }
        }
        private Item_ServiceManager itemLaundry;
        private Item_ServiceManager itemIron;

        public Item_ServiceManager ItemLaundry { get => itemLaundry; set => itemLaundry = value; }
        public Item_ServiceManager ItemIron { get => itemIron; set => itemIron = value; }
        #endregion

        private void loadAllService()
        {
            pnToAddItem.Controls.Clear();
            DataTable dataEatServices = DataAccess.Services.GetServicesInfo(ServiceType.Eating);
            for (int i = 0; i < dataEatServices.Rows.Count; i++)
            {
                Item_ServiceManager item = new Item_ServiceManager(Convert.ToInt32(dataEatServices.Rows[i].ItemArray[0]),
                                                                   dataEatServices.Rows[i].ItemArray[1].ToString(),
                                                                   Convert.ToInt32(dataEatServices.Rows[i].ItemArray[2]),
                                                                   this);
                pnToAddItem.Controls.Add(item);
            }
            DataTable dataLaundryServices = DataAccess.Services.GetServicesInfo(ServiceType.Laundry);
            ItemLaundry = new Item_ServiceManager(Convert.ToInt32(dataLaundryServices.Rows[0].ItemArray[0]),
                                                dataLaundryServices.Rows[0].ItemArray[1].ToString(),
                                                Convert.ToInt32(dataLaundryServices.Rows[0].ItemArray[2]),
                                                this);
            LbLaundryName.Text = ItemLaundry._name;
            LbLaundryPrice.Text = ItemLaundry._price.ToString();

            ItemIron = new Item_ServiceManager(Convert.ToInt32(dataLaundryServices.Rows[1].ItemArray[0]),
                                                dataLaundryServices.Rows[1].ItemArray[1].ToString(),
                                                Convert.ToInt32(dataLaundryServices.Rows[1].ItemArray[2]),
                                                this);
            LbIronName.Text = ItemIron._name;
            LbIronPrice.Text = ItemIron._price.ToString();
        }
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
