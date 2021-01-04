using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HotelManagement.UI
{
    public partial class Form_LaundryService : UserControl
    {
        private DTO.RoomOverview rooms;
        private CancellationTokenSource cts;
        private Form ParentRef;

        public Form_LaundryService(Form ParentRef)
        {
            InitializeComponent();
            cts = new CancellationTokenSource();
            this._discount = 0;
            this.ParentRef = ParentRef;
        }

        private async Task Init_Services()
        {
            DTO.ServicesInfo services = await Task.Run(() => {
                try
                {
                    return new DTO.ServicesInfo(ServiceType.Laundry);
                }
                catch
                {
                    return null;
                }
            });
            if (services == null) throw new Exception("Không thể kết nối đến server");
            //label1.Text = services.Items[0].Name.ToString();
            lbLaundryPrice.Text = services.Items[0].Price.ToString();
            laundryID = services.Items[0].ServiceID;
            laundryPrice = services.Items[0].Price;
            //label2.Text = services.Items[1].Name.ToString();
            lbIronPrice.Text = services.Items[1].Price.ToString();
            ironPrice = services.Items[1].Price;
            ironID = services.Items[1].ServiceID;
        }

        #region properties
        private int laundryPrice, ironPrice, laundryID, ironID;
        private List<Item_LaundryService> SelectedItems = new List<Item_LaundryService>();

        private int discount;

        public int _discount
        {
            get { return discount; }
            set
            {
                discount = value;
                lbDiscount.Text = discount.ToString();
            }
        }

        private int totalMoney;

        public int _totalMoney
        {
            get { return totalMoney; }
            set
            {
                totalMoney = value;
                lbTotalMoney.Text = value.ToString();
                lbTotalPayable.Text = (totalMoney - ((float)totalMoney * discount / 100)).ToString();
            }
        }

        public FlowLayoutPanel _pnItem
        {
            get { return pnItem; }
        }

        #endregion
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
                foreach (Item_LaundryService i in SelectedItems)
                {
                    sum += (i._count * i._price);
                }
            });
            this._totalMoney = sum;
        }

        Item_LaundryService createItemLaundry(int ID, string name, int price)
        {
            Item_LaundryService temp = new Item_LaundryService(this);
            temp._itemID = ID;
            temp._name = name;
            temp._price = price;

            return temp;
        }

        int checkExistsItem(int ID)
        {
            if (SelectedItems.Count > 0)
            {
                for(int i=0; i<SelectedItems.Count; i++)
                {
                    if (SelectedItems[i]._itemID == ID)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        private async void Form_LaundryService_Load(object sender, EventArgs e)
        {
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef, new LoadingForm(cts.Token));
                overlay.Show();
                await Init_Services();
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

        private async void btItemIron_Click(object sender, EventArgs e)
        {
            int check = checkExistsItem(ironID);
            if (check == -1)
            {
                SelectedItems.Add(createItemLaundry(ironID, "Ủi", ironPrice));
                pnItem.Controls.Add(SelectedItems[SelectedItems.Count - 1]);
            }
            else
            {
                pnItem.Controls.Remove(SelectedItems[check]);
                SelectedItems.RemoveAt(check);
            }
            await calcTotalMoney();
        }

        private async void btItemLaundry_Click(object sender, EventArgs e)
        {
            int check = checkExistsItem(laundryID);
            if (check == -1)
            {
                SelectedItems.Add(createItemLaundry(laundryID, "Giặt", laundryPrice));
                pnItem.Controls.Add(SelectedItems[SelectedItems.Count - 1]);
            }
            else
            {
                pnItem.Controls.Remove(SelectedItems[check]);
                SelectedItems.RemoveAt(check);
            }
            await calcTotalMoney();
        }

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
                if (MessageBox.Show("Bạn có chắc chắn muốn thêm những dịch vụ này không?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    OverlayForm overlay = new OverlayForm(ParentRef, new LoadingForm(cts.Token));
                    overlay.Show();

                    for (int i = 0; i < SelectedItems.Count; i++)
                    {
                        int RoomID = rooms.Items[cbRoomSelection.SelectedIndex - 1].ID;
                        int a = await Task.Run(() =>
                        {
                            try
                            {
                                return DataAccess.Bill.InsertServicetoBillDetail(RoomID, SelectedItems[i]._itemID, SelectedItems[i]._count);
                            }
                            catch
                            {
                                return -2;
                            }
                        });
                        if (a == -2) throw new Exception("Không thể kết nối đến server");
                    }
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
            }
            catch (ArgumentException) { }
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

    }
}
