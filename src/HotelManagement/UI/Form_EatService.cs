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
                pnServicesList.Controls.Add(item);
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
        #region Properties
        public Room ParentRef;
        #endregion
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
            }
            MessageBox.Show("Thêm thành công!", "Thông báo");
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            if (SelectedItems.Count == 0)
            {
                MessageBox.Show("Mời chọn ít nhất 1 sản phẩm!", "Lỗi");
                return;
            }
            if (cbRoomSelection.SelectedIndex != -1)
            {
                MessageBox.Show("Thanh toán trực tiếp, vui lòng không chọn phòng!", "Lỗi");
                return;
            }
            DataAccess.Services.InsertNewBillServiceOnly("a");
            for (int i = 0; i < SelectedItems.Count; i++)
            {
                DataAccess.Services.InsertServiceIntoBillServiceOnlyDetail(SelectedItems[i]._itemID, SelectedItems[i]._count);
            }
            int RowEffected = DataAccess.Services.PaymentBillServiceOnly();
            if (RowEffected > 0)
            {
                printPreviewDialogBill.Document = bill;
                printPreviewDialogBill.ShowDialog();
            }
            //MessageBox.Show("Thêm thành công!", "Thông báo");
        }

        private void bill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DTO.RoomServices svc = new DTO.RoomServices();
            DrawBill drawBill = new DrawBill(e.Graphics);
            drawBill.drawBillHeader();
            drawBill.drawServiceInfo();
            //drawBill.drawCustomerInfo(Customer.Name, RoomID, Customer.PhoneNumber, Customer.Addr,
            //    dtpCheckInDate.Text, dtpCheckOutDate.Text);
            //drawBill.drawItem("Phòng", (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days, Convert.ToInt32(tbRoomPrice.Text));
            //int TotalMoney = Convert.ToInt32(tbRoomPrice.Text) * (dtpCheckOutDate.Value - dtpCheckInDate.Value).Days;
            int TotalMoney = 0;
            for (int i = 0; i < svc.services.Count; i++)
            {
                drawBill.drawItem(svc.services[i].Name, svc.services[i].Count, svc.services[i].Price);
                TotalMoney += svc.services[i].Count * svc.services[i].Price;
            }
            DTO.StaffOverview staff = new DTO.StaffOverview("a");
            drawBill.drawEndOfBill(staff.Name, TotalMoney, 0);
        }
    }
}
