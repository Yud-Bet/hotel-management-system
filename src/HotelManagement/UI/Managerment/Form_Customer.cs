using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HotelManagement.UI
{
    using Customers = List<Item_Customer>; 
    public partial class Form_Customer : UserControl
    {
        Customers customers;
        Form_Main ParentRef;
        CancellationTokenSource cts;
        public Form_Customer(Form_Main ParentRef)
        {
            InitializeComponent();
            customers = new Customers();
            this.ParentRef = ParentRef;
            cts = new CancellationTokenSource();
        }

        private async void Form_Customer_Load(object sender, EventArgs e)
        {
            await load_AllCustomer();
        }

        private async Task load_AllCustomer()
        {
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef, new LoadingForm(cts.Token));
                overlay.Show();

                int cbSortSelectedIndex = cbSort.SelectedIndex;
                (DataTable, bool) tuple = await Task.Run(() =>
                {
                    try
                    {
                        return (DataAccess.Manager.GetAllCustomer(cbSortSelectedIndex), false);
                    }
                    catch
                    {
                        return (null, true);
                    }
                });
                if (tuple.Item2) throw new Exception("Lỗi khi kết nối tới server");
                DataTable dataAllCustomer = tuple.Item1;
                pnAddItem.Controls.Clear();
                customers.Clear();
                for (int i = 0; i < dataAllCustomer.Rows.Count; i++)
                {

                    customers.Add(new Item_Customer(Convert.ToInt32(dataAllCustomer.Rows[i].ItemArray[0]),
                                                            dataAllCustomer.Rows[i].ItemArray[1].ToString(),
                                                            dataAllCustomer.Rows[i].ItemArray[2].ToString(),
                                                            dataAllCustomer.Rows[i].ItemArray[3].ToString(),
                                                            Convert.ToDateTime(dataAllCustomer.Rows[i].ItemArray[4]),
                                                            Convert.ToBoolean(dataAllCustomer.Rows[i].ItemArray[5]),
                                                            dataAllCustomer.Rows[i].ItemArray[6].ToString(),
                                                            Convert.ToInt32(dataAllCustomer.Rows[i].ItemArray[7]),
                                                            this));
                }
                pnAddItem.Controls.AddRange(customers.ToArray());
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

        private async void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            await load_AllCustomer();
        }

        private void pnAddItem_ControlAdded(object sender, ControlEventArgs e)
        {
            lbListCustomerIsEmpty.Hide();
        }

        private void pnAddItem_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (pnAddItem.Controls.Count == 1)
            {
                lbListCustomerIsEmpty.Show();
            }
        }

        private async Task<Customers> SearchForCustomers(string Criteria)
        {
            Customers res = new Customers();
            await Task.Run(() =>
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i]._Name.ToLower().Contains(Criteria.ToLower()))
                    {
                        res.Add(customers[i]);
                    }
                }
            });
            return res;
        }

        private async void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                _pnToAddItem.Controls.Clear();
                _pnToAddItem.Controls.AddRange(customers.ToArray());
            }
            else
            {
                Customers SearchRes = await SearchForCustomers(tbSearch.Text);
                _pnToAddItem.Controls.Clear();
                _pnToAddItem.Controls.AddRange(SearchRes.ToArray());
            }
        }
    }
}
