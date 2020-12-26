using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HotelManagement.UI
{
    using Services = List<Item_EatService1>;
    public partial class Form_EatService : UserControl
    {
        private DTO.RoomOverview rooms;
        private string Username;
        private CancellationTokenSource cts;
        private Form ParentRef;
        private Services serviceList;

        public Form_EatService(Form ParentRef, string Username)
        {
            InitializeComponent();
            this.ParentRef = ParentRef;
            this.Username = Username;
            cts = new CancellationTokenSource();
            lbDiscount.Text = discount.ToString();

            Disposed += (s, e) =>
            {
                tbSearch.TextChanged -= tbSearch_TextChanged;
            };
        }

        private async Task Init_pnServicesList()
        {
            DTO.ServicesInfo services = await Task.Run(() => {
                try
                {
                    return new DTO.ServicesInfo(ServiceType.Eating);
                }
                catch
                {
                    return null;
                }
            });
            if (services == null) throw new Exception("Không thể kết nối đến server");
            serviceList = new Services();
            for (int i = 0; i < services.Items.Count; i++)
            {
                Item_EatService1 item = new Item_EatService1(this);
                item._itemID = services.Items[i].ServiceID;
                item._name = services.Items[i].Name;
                item._price = services.Items[i].Price;
                item.setServiceImage();
                serviceList.Add(item);
                pnServicesList.Controls.Add(item);
            }
        }

        private Services SearchForEatingServices(string Criteria)
        {
            var res = new Services();
            for (int i = 0; i < serviceList.Count; i++)
            {
                if (serviceList[i]._name.ToLower().Contains(Criteria.ToLower()))
                {
                    res.Add(serviceList[i]);
                }
            }
            return res;
        }

        private async Task Init_cbRoomSelection()
        {
            rooms = await Task.Run(() => {
                try
                {
                    return new DTO.RoomOverview();
                }
                catch
                {
                    return null;
                }
            });
            if (rooms == null) throw new Exception("Không thể kết nối đến server");
            cbRoomSelection.Items.Add("None");
            for (int i = 0; i < rooms.Items.Length; i++)
            {
                cbRoomSelection.Items.Add("Phòng " + rooms.Items[i].ID.ToString());
            }
            cbRoomSelection.SelectedIndex = 0;
        }
        public async Task calcTotalMoney()
        {
            int sum = 0;
            await Task.Run(() =>
            {
                foreach (Item_EatService2 i in this._SelectedItems)
                {
                    sum += (i._count * i._price);
                }
            });
            this._totalMoney = sum;
        }

        #region properties

        private int discount = 0;

        public int _discount
        {
            get { return discount; }
            set {
                discount = value;
                lbDiscount.Text = discount.ToString();
            }
        }


        public FlowLayoutPanel _pnServicesList
        {
            get { return this.pnServicesList; }
        }

        public FlowLayoutPanel _pnSelectedServices
        {
            get { return this.pnSelectedServices; }
        }

        private List<Item_EatService2> SelectedItems= new List<Item_EatService2>();

        public List<Item_EatService2> _SelectedItems
        {
            get { return SelectedItems; }
            set { SelectedItems = value; }
        }

        private int totalMoney;

        public int _totalMoney
        {
            get { return totalMoney; }
            set { 
                totalMoney = value;
                lbTotalMoney.Text = value.ToString();
                lbTotalPayable.Text = (totalMoney - (int)((float)totalMoney * discount / 100)).ToString();
            }
        }

        #endregion

        private async void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedItems.Count == 0)
                {
                    MessageBox.Show("Mời chọn ít nhất 1 sản phẩm!", "Lỗi");
                    throw new ArgumentException();
                }
                if (cbRoomSelection.SelectedIndex == -1 || cbRoomSelection.SelectedIndex == 0)
                {
                    MessageBox.Show("Mời chọn phòng!", "Lỗi");
                    throw new ArgumentException();
                }
                if (rooms.Items[cbRoomSelection.SelectedIndex - 1].Status != RoomStatus.Rented)
                {
                    MessageBox.Show("Phòng này chưa được thuê!", "Lỗi");
                    throw new ArgumentException();
                }

                OverlayForm overlay = new OverlayForm(ParentRef, new LoadingForm(cts.Token));
                overlay.Show();

                for (int i = 0; i < SelectedItems.Count; i++)
                {
                    int RoomID = rooms.Items[cbRoomSelection.SelectedIndex - 1].ID;
                    int a = await Task.Run(() => {
                        try
                        {
                            return DataAccess.Services.InsertServicetoBillDetail(RoomID, SelectedItems[i]._itemID, SelectedItems[i]._count);
                        }
                        catch
                        {
                            return -2;
                        }
                    });
                    if (a == -2) throw new Exception("Không thể kết nối đến server");
                }
                MessageBox.Show("Thêm thành công!", "Thông báo");
                StatusLabel.Text = "";
            }
            catch (ArgumentException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StatusLabel.Text = "Thêm thất bại";
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
            }
        }

        private async void btPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedItems.Count == 0)
                {
                    MessageBox.Show("Mời chọn ít nhất 1 sản phẩm!", "Lỗi");
                    throw new ArgumentException();
                }
                if (cbRoomSelection.SelectedIndex != -1 && cbRoomSelection.SelectedIndex != 0)
                {
                    MessageBox.Show("Thanh toán trực tiếp, vui lòng không chọn phòng!", "Lỗi");
                    throw new ArgumentException();
                }

                OverlayForm overlay = new OverlayForm(ParentRef, new LoadingForm(cts.Token));
                overlay.Show();

                int InsSvcsBill = await Task.Run(() => {
                    try
                    {
                        return DataAccess.Services.InsertNewServicesBillOnly(Username);
                    }
                    catch
                    {
                        return -2;
                    }
                });
                if (InsSvcsBill == -2) throw new Exception("Không thể kết nối đến server");

                for (int i = 0; i < SelectedItems.Count; i++)
                {
                    int InsItemToBill = await Task.Run(() => {
                        try
                        {
                            return DataAccess.Services.InsertServiceToServicesBillOnlyDetail(SelectedItems[i]._itemID, SelectedItems[i]._count);
                        }
                        catch
                        {
                            return -2;
                        }
                    });
                    if (InsItemToBill == -2) throw new Exception("Không thể kết nối đến server");
                }
                int RowEffected = await Task.Run(() => {
                    try
                    {
                        return DataAccess.Services.PayForServicesOnly();
                    }
                    catch
                    {
                        return -2;
                    }
                });
                if (RowEffected == -2) throw new Exception("Không thể kết nối đến server");
                if (RowEffected > 0)
                {
                    TotalMoney = 0;
                    numOfItemPerPage = 0;
                    countItem = 0;
                    printPreviewDialogBill.Document = bill;
                    printPreviewDialogBill.ShowDialog();
                    pnSelectedServices.Controls.Clear();
                    SelectedItems.Clear();
                }
                StatusLabel.Text = "";
            }
            catch (ArgumentException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StatusLabel.Text = "Thanh toán thất bại";
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
            }
        }

        int TotalMoney = 0;
        int numOfItemPerPage = 0;
        int countItem = 0;
        private void bill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                DTO.RoomServices svc = new DTO.RoomServices();
                DrawBill drawBill = new DrawBill(e.Graphics);
                drawBill.drawBillHeader();
                drawBill.drawServiceInfo();
                for (int i = countItem; i < svc.items.Count; i++)
                {
                    drawBill.drawItem(svc.items[i].Name, svc.items[i].Count, svc.items[i].Price, svc.items[i].IntoMoney);
                    TotalMoney += svc.items[i].Count * svc.items[i].Price;
                    countItem++;
                    if (numOfItemPerPage > 16)
                    {
                        e.HasMorePages = true;
                        numOfItemPerPage = 0;
                        return;
                    }
                    else
                    {
                        e.HasMorePages = false;
                        numOfItemPerPage++;
                    }
                }
                DTO.StaffOverview staff = new DTO.StaffOverview(Username);
                drawBill.drawEndOfBill(staff.Name, TotalMoney, 0);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Lỗi khi kết nối đến server!", "Lỗi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void Form_EatService_Load(object sender, EventArgs e)
        {
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef, new LoadingForm(cts.Token));
                overlay.Show();
                await Init_pnServicesList();
                await Init_cbRoomSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StatusLabel.Text = "Đã xảy ra lỗi";
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
            }
        }

        private void pnServicesList_ControlAdded(object sender, ControlEventArgs e)
        {
            lbListServiceIsEmpty.Hide();
        }

        private void pnServicesList_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (pnServicesList.Controls.Count == 1)
            {
                lbListServiceIsEmpty.Show();
            }
        }

        private void pnSelectedServices_ControlAdded(object sender, ControlEventArgs e)
        {
            lbListSelectedServiceIsEmpty.Hide();
        }

        private void pnSelectedServices_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (pnSelectedServices.Controls.Count == 1)
            {
                lbListSelectedServiceIsEmpty.Show();
            }
        }

        private async void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                pnServicesList.Controls.Clear();
                pnServicesList.Controls.AddRange(serviceList.ToArray());
            }
            else
            {
                pnServicesList.Controls.Clear();
                var temp = await Task.Run(() => SearchForEatingServices(tbSearch.Text));
                pnServicesList.Controls.AddRange(temp.ToArray());
            }
        }
    }
}
