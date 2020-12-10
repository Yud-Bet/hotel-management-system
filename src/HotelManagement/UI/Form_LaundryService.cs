using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Form_LaundryService : UserControl
    {
        DTO.RoomOverview rooms;
        private bool IsProcessing = false;
        public Form_LaundryService()
        {
            InitializeComponent();

            this._discount = 0;
        }

        private async Task Init_Services()
        {
            DTO.ServicesInfo services = await Task.Run(() => new DTO.ServicesInfo(ServiceType.Laundry));
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
            rooms = await Task.Run(() => new DTO.RoomOverview());
            for (int i = 0; i < rooms.Items.Length; i++)
            {
                cbRoomSelection.Items.Add(rooms.Items[i].ID);
            }
        }

        public void calcTotalMoney()
        {
            int sum = 0;
            foreach (Item_LaundryService i in SelectedItems)
            {
                sum += (i._count * i._price);
            }
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
                await Init_Services();
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
        }

        private void btItemIron_Click(object sender, EventArgs e)
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
            calcTotalMoney();
        }

        private void btItemLaundry_Click(object sender, EventArgs e)
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
            calcTotalMoney();
        }

        private async void btAdd_Click(object sender, EventArgs e)
        {
            if (!IsProcessing)
            {
                IsProcessing = true;
                if (SelectedItems.Count == 0)
                {
                    MessageBox.Show("Mời chọn ít nhất 1 sản phẩm!", "Lỗi");
                    return;
                }
                if (cbRoomSelection.SelectedIndex == -1)
                {
                    MessageBox.Show("Mời chọn phòng!", "Lỗi");
                    return;
                }
                if (rooms.Items[cbRoomSelection.SelectedIndex].Status != RoomStatus.Rented)
                {
                    MessageBox.Show("Phòng này chưa được thuê!", "Lỗi");
                    return;
                }
                try
                {
                    for (int i = 0; i < SelectedItems.Count; i++)
                    {
                        int RoomID = rooms.Items[cbRoomSelection.SelectedIndex].ID;
                        await Task.Run(() => DataAccess.Services.InsertServicetoBillDetail(RoomID, SelectedItems[i]._itemID, SelectedItems[i]._count));
                    }
                    MessageBox.Show("Thêm thành công!", "Thông báo");
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
                    IsProcessing = false;
                }
            }
            else MessageBox.Show("Từ từ đừng vội~");
        }

    }
}
