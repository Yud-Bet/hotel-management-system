using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Form_EatService : UserControl
    {
        DTO.RoomOverview rooms;
        string Username;
        private bool IsProcessing = false;
        public Form_EatService(string Username)
        {
            InitializeComponent();

            this.Username = Username;

            lbDiscount.Text = discount.ToString();
        }

        private async Task Init_pnServicesList()
        {
            DTO.ServicesInfo services = await Task.Run(() => new DTO.ServicesInfo(ServiceType.Eating));
            for (int i = 0; i < services.Items.Count; i++)
            {
                Item_EatService1 item = new Item_EatService1(this);
                item._itemID = services.Items[i].ServiceID;
                item._name = services.Items[i].Name;
                item._price = services.Items[i].Price;
                pnServicesList.Controls.Add(item);
            }
        }

        private async Task Init_cbRoomSelection()
        {
            rooms = await Task.Run(() => new DTO.RoomOverview());
            cbRoomSelection.Items.Add("None");
            for (int i = 0; i < rooms.Items.Length; i++)
            {
                cbRoomSelection.Items.Add(rooms.Items[i].ID);
            }
        }
        public void calcTotalMoney()
        {
            int sum = 0;
            foreach (Item_EatService2 i in this._SelectedItems)
            {
                sum += (i._count * i._price);
            }
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
            if (!IsProcessing)
            {
                IsProcessing = true;
                StatusLabel.Text = "Đang xử lí...";
                if (SelectedItems.Count == 0)
                {
                    MessageBox.Show("Mời chọn ít nhất 1 sản phẩm!", "Lỗi");
                    IsProcessing = false;
                    return;
                }
                if (cbRoomSelection.SelectedIndex == -1 || cbRoomSelection.SelectedIndex == 0)
                {
                    MessageBox.Show("Mời chọn phòng!", "Lỗi");
                    IsProcessing = false;
                    return;
                }
                if (rooms.Items[cbRoomSelection.SelectedIndex - 1].Status != RoomStatus.Rented)
                {
                    MessageBox.Show("Phòng này chưa được thuê!", "Lỗi");
                    IsProcessing = false;
                    return;
                }
                try
                {
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    StatusLabel.Text = "Thêm thất bại";
                }
                finally
                {
                    IsProcessing = false;
                }
            }
            else MessageBox.Show("Từ từ đừng vội~");
        }

        private async void btPay_Click(object sender, EventArgs e)
        {
            if (!IsProcessing)
            {
                IsProcessing = true;
                StatusLabel.Text = "Đang xử lí...";
                if (SelectedItems.Count == 0)
                {
                    MessageBox.Show("Mời chọn ít nhất 1 sản phẩm!", "Lỗi");
                    return;
                }
                if (cbRoomSelection.SelectedIndex != -1 && cbRoomSelection.SelectedIndex != 0)
                {
                    MessageBox.Show("Thanh toán trực tiếp, vui lòng không chọn phòng!", "Lỗi");
                    return;
                }
                try
                {
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    StatusLabel.Text = "Thanh toán thất bại";
                }
                finally
                {
                    IsProcessing = false;
                }
            }
            else MessageBox.Show("Từ từ đừng vội~");
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
                StatusLabel.Text = "Đang xử lí...";
                await Init_pnServicesList();
                await Init_cbRoomSelection();
                StatusLabel.Text = "";
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
        }
    }
}
