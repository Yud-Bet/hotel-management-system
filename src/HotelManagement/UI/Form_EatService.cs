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
            DTO.ServicesInfo services = await Task.Run(() => new DTO.ServicesInfo(ServiceType.Eating));
            serviceList = new Services();
            for (int i = 0; i < services.Items.Count; i++)
            {
                Item_EatService1 item = new Item_EatService1(this);
                item._itemID = services.Items[i].ServiceID;
                item._name = services.Items[i].Name;
                item._price = services.Items[i].Price;
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
            rooms = await Task.Run(() => new DTO.RoomOverview());
            cbRoomSelection.Items.Add("None");
            for (int i = 0; i < rooms.Items.Length; i++)
            {
                cbRoomSelection.Items.Add(rooms.Items[i].ID);
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
                lbTotalPayable.Text = (totalMoney - ((float)totalMoney * discount / 100)).ToString();
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
                    await Task.Run(() => DataAccess.Services.InsertServicetoBillDetail(RoomID, SelectedItems[i]._itemID, SelectedItems[i]._count));
                }
                MessageBox.Show("Thêm thành công!", "Thông báo");
                StatusLabel.Text = "";
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Không thể kết nối đến server", "Lỗi");
                StatusLabel.Text = "Thêm thất bại";
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

                await Task.Run(() => DataAccess.Services.InsertNewServicesBillOnly(Username));
                for (int i = 0; i < SelectedItems.Count; i++)
                {
                    await Task.Run(() => DataAccess.Services.InsertServiceToServicesBillOnlyDetail(SelectedItems[i]._itemID, SelectedItems[i]._count));
                }
                int RowEffected = await Task.Run(() => DataAccess.Services.PayForServicesOnly());
                if (RowEffected > 0)
                {
                    printPreviewDialogBill.Document = bill;
                    printPreviewDialogBill.ShowDialog();
                }
                StatusLabel.Text = "";
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Không thể kết nối đến server", "Lỗi");
                StatusLabel.Text = "Thanh toán thất bại";
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

        private void bill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DTO.RoomServices svc = new DTO.RoomServices();
            DrawBill drawBill = new DrawBill(e.Graphics);
            drawBill.drawBillHeader();
            drawBill.drawServiceInfo();
            int TotalMoney = 0;
            for (int i = 0; i < svc.items.Count; i++)
            {
                drawBill.drawItem(svc.items[i].Name, svc.items[i].Count, svc.items[i].Price, svc.items[i].IntoMoney);
                TotalMoney += svc.items[i].Count * svc.items[i].Price;
            }
            DTO.StaffOverview staff = new DTO.StaffOverview(Username);
            drawBill.drawEndOfBill(staff.Name, TotalMoney, 0);
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
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Không thể kết nối đến server", "Lỗi");
                StatusLabel.Text = "Không có kết nối";
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
