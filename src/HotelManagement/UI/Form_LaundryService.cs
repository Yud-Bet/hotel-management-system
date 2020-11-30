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
    public partial class Form_LaundryService : UserControl
    {
        DTO.RoomOverview rooms;
        public Form_LaundryService()
        {
            InitializeComponent();

            this._discount = 10;
            DTO.ServicesInfo services = new DTO.ServicesInfo(ServiceType.Laundry);
            //label1.Text = services.Items[0].Name.ToString();
            lbLaundryPrice.Text = services.Items[0].Price.ToString();
            laundryID = services.Items[0].ServiceID;
            laundryPrice = services.Items[0].Price;
            //label2.Text = services.Items[1].Name.ToString();
            lbIronPrice.Text = services.Items[1].Price.ToString();
            ironPrice = services.Items[1].Price;
            ironID = services.Items[1].ServiceID;
            Init_cbRoomSelection();
        }

        #region properties
        private int laundryPrice, ironPrice, laundryID, ironID;
        private List<Item_LaundryService> item_LaundryServices = new List<Item_LaundryService>();

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

        #endregion
        private void Init_cbRoomSelection()
        {
            rooms = new DTO.RoomOverview();
            for (int i = 0; i < rooms.Items.Length; i++)
            {
                cbRoomSelection.Items.Add(rooms.Items[i].ID);
            }
        }

        public void calcTotalMoney()
        {
            int sum = 0;
            foreach (Item_LaundryService i in item_LaundryServices)
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
            if (item_LaundryServices.Count > 0)
            {
                for(int i=0; i<item_LaundryServices.Count; i++)
                {
                    if (item_LaundryServices[i]._itemID == ID)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        private void btItemIron_Click(object sender, EventArgs e)
        {
            int check = checkExistsItem(ironID);
            if (check == -1)
            {
                item_LaundryServices.Add(createItemLaundry(ironID, "Ủi", ironPrice));
                pnItem.Controls.Add(item_LaundryServices[item_LaundryServices.Count - 1]);
            }
            else
            {
                pnItem.Controls.Remove(item_LaundryServices[check]);
                item_LaundryServices.RemoveAt(check);
            }
            calcTotalMoney();
        }

        private void btItemLaundry_Click(object sender, EventArgs e)
        {
            int check = checkExistsItem(laundryID);
            if (check == -1)
            {
                item_LaundryServices.Add(createItemLaundry(laundryID, "Giặt", laundryPrice));
                pnItem.Controls.Add(item_LaundryServices[item_LaundryServices.Count - 1]);
            }
            else
            {
                pnItem.Controls.Remove(item_LaundryServices[check]);
                item_LaundryServices.RemoveAt(check);
            }
            calcTotalMoney();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            if (item_LaundryServices.Count == 0)
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
            for (int i = 0; i < item_LaundryServices.Count; i++)
            {
                int RoomID = rooms.Items[cbRoomSelection.SelectedIndex].ID;
                DataAccess.Services.InsertServicetoBillDetail(RoomID, item_LaundryServices[i]._itemID, item_LaundryServices[i]._count);
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
        }

    }
}
