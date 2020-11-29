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
    public partial class Form_EatService : UserControl
    {
        DTO.RoomOverview rooms;
        public Form_EatService()
        {
            InitializeComponent();

            lbDiscount.Text = discount.ToString();

            DTO.ServicesInfo services = new DTO.ServicesInfo(ServiceType.Eating);
            for (int i = 0; i < services.Items.Count; i++)
            {
                Item_EatService1 item = new Item_EatService1(this);
                item._itemID = services.Items[i].ServiceID;
                item._name = services.Items[i].Name;
                item._price = services.Items[i].Price;
                pnItem1.Controls.Add(item);
            }
            Init_cbRoomSelection();
        }
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
            foreach (Item_EatService2 i in this._item_EatService2s)
            {
                sum += (i._count * i._price);
            }
            this._totalMoney = sum;
        }

        #region properties

        int discount = 0;

        public FlowLayoutPanel _panelItem1
        {
            get { return this.pnItem1; }
        }

        public FlowLayoutPanel _panelItem2
        {
            get { return this.pnItem2; }
        }

        private List<Item_EatService2> SelectedItems= new List<Item_EatService2>();

        public List<Item_EatService2> _item_EatService2s
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

        private void btAdd_Click(object sender, EventArgs e)
        {
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
            for (int i = 0; i < SelectedItems.Count; i++)
            {
                int RoomID = rooms.Items[cbRoomSelection.SelectedIndex].ID;
                DataAccess.Services.InsertServicetoBillDetail(RoomID, SelectedItems[i]._itemID, SelectedItems[i]._count);
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
        }
    }
}
