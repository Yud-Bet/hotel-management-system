using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HotelManagement.UI
{
    public partial class Form_ServiceManager : UserControl
    {
        public List<Item_ServiceManager> Services;
        public Form_Main ParentRef;
        CancellationTokenSource cts = new CancellationTokenSource();
        public Form_ServiceManager(Form_Main ParentRef)
        {
            InitializeComponent();
            this.ParentRef = ParentRef;
            //pnToAddItem.Controls.Add(new Item_ServiceManager(this));
            Disposed += (s, e) =>
              {
                  tbSearch.TextChanged -= tbSearch_TextChanged;
              };
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

        private async Task loadAllService()
        {
            Services = new List<Item_ServiceManager>();
            pnToAddItem.Controls.Clear();
            DataTable dataEatServices = await Task.Run(()=> {
                try
                {
                    return DataAccess.Services.GetServicesInfo(ServiceType.Eating);
                }
                catch
                {
                    return null;
                }
            });
            if (dataEatServices == null) throw new Exception("Lỗi khi kết nối tới server");
            for (int i = 0; i < dataEatServices.Rows.Count; i++)
            {
                Item_ServiceManager item = new Item_ServiceManager(Convert.ToInt32(dataEatServices.Rows[i].ItemArray[0]),
                                                                   dataEatServices.Rows[i].ItemArray[1].ToString(),
                                                                   Convert.ToInt32(dataEatServices.Rows[i].ItemArray[2]),
                                                                   this);
                Services.Add(item);
            }

            pnToAddItem.Controls.AddRange(Services.ToArray());
            DataTable dataLaundryServices = await Task.Run(()=> {
                try
                {
                    return DataAccess.Services.GetServicesInfo(ServiceType.Laundry);
                }
                catch
                {
                    return null;
                }
            });
            if (dataLaundryServices == null) throw new Exception("Lỗi khi kết nối tới server");
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

        private List<Item_ServiceManager> SearchForSvcs(string Criteria)
        {
            List<Item_ServiceManager> res = new List<Item_ServiceManager>();
            for (int i = 0; i < Services.Count; i++)
            {
                if (Services[i]._name.ToLower().Contains(Criteria.ToLower()))
                {
                    res.Add(Services[i]);
                }
            }
            return res;
        }

        private async void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                pnToAddItem.Controls.Clear();
                pnToAddItem.Controls.AddRange(Services.ToArray());
            }
            else
            {
                List<Item_ServiceManager> SearchRes = await Task.Run(() => SearchForSvcs(tbSearch.Text));
                pnToAddItem.Controls.Clear();
                pnToAddItem.Controls.AddRange(SearchRes.ToArray());
            }
        }

        private async void Form_ServiceManager_Load(object sender, EventArgs e)
        {
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef, new LoadingForm(cts.Token));
                overlay.Show();

                await loadAllService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
            }
        }
    }
}
