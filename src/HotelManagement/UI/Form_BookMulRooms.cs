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
    public partial class Form_BookMulRooms : UserControl
    {
        List<Item_RoomOfFormBookMulRoom> items = new List<Item_RoomOfFormBookMulRoom>();
        public Form_BookMulRooms(Form_Room parentRef)
        {
            InitializeComponent();
            ParentRef = parentRef;
            loadData();
        }

        void loadData()
        {
            foreach(var i in ParentRef.listRoom)
            {
                if((int)i._RoomStatus==1 || (int)i._RoomStatus == 3)
                {
                    Item_RoomOfFormBookMulRoom newItem = new Item_RoomOfFormBookMulRoom(i, this);
                    items.Add(newItem);
                    pnToSelectRoom.Controls.Add(newItem);
                }
            }
            emtyCount = items.Count();
            PanelList.XPanderPanels[0].Text = "Danh sách phòng trống: " + emtyCount.ToString() + " phòng";
            PanelList.XPanderPanels[1].Text = "Danh sách phòng đã chọn: " + selectedCount.ToString() + " phòng";
        }

        #region Properties
        public Form_Room ParentRef;
        public int emtyCount, selectedCount = 0;

        public int _emtyCount
        {
            get { return emtyCount; }
            set { 
                emtyCount = value;
                PanelList.XPanderPanels[0].Text = "Danh sách phòng trống: " + emtyCount.ToString() + " phòng";
            }
        }

        public int _selectedCount
        {
            get { return selectedCount; }
            set
            {
                selectedCount = value;
                PanelList.XPanderPanels[1].Text = "Danh sách phòng đã chọn: " + selectedCount.ToString() + " phòng";
            }
        }

        public FlowLayoutPanel _pnToSelectRoom
        {
            get { return pnToSelectRoom; }
        }

        public FlowLayoutPanel _pnSeletedRoom
        {
            get { return pnSeletedRoom; }
        }

        public Zeroit.Framework.MiscControls.ZeroitProPanelList _panelList
        {
            get { return PanelList; }
        }
        #endregion

        private void btBookRoom_Click(object sender, EventArgs e)
        {
            foreach (Item_RoomOfFormBookMulRoom item in items)
            {
            }
            if (checkRooms.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng!", "Lỗi!");
                return;
            }
            List<int> listRoomRent = new List<int>();
            for (int i = 0; i < checkRooms.CheckedItems.Count; i++)
            {
                int roomID = Convert.ToInt32(checkRooms.CheckedItems[i].ToString());
                DataTable roomInfo = DataAccess.RoomDA.GetRoomInfo(roomID);
                int roomStatus = Convert.ToInt32(roomInfo.Rows[0].ItemArray[3].ToString());
                if (roomStatus == Convert.ToInt32(RoomStatus.Empty))
                {
                    listRoomRent.Add(roomID);
                    //if (!roomOk)
                    //{
                    //    int a = DataAccess.CustomerDA.InsertNewClient(tbCustomerName.Text, dtpCustomerBirthday.Value, tbIDNo.Text, tbPassport.Text,
                    //    tbCustomerAddress.Text, tbCustomerPhoneNum.Text, rbtMale.Checked ? Sex.Male : Sex.Female);
                    //    int b = DataAccess.CustomerDA.InsertNewRoomReservation(dtpCheckInDate.Value, 0, 0, tbNote.Text);
                    //    roomOk = true;
                    //}
                    //int c = DataAccess.CustomerDA.InsertRoomReservationDetail(roomID);
                }
                else if (roomStatus == Convert.ToInt32(RoomStatus.Cleaning))
                {
                    DialogResult result = MessageBox.Show("Phòng " + roomID.ToString() + " đang dọn. \nBạn có muốn tiếp tục đặt phòng này không?", "Thông báo!", MessageBoxButtons.YesNo);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            listRoomRent.Add(roomID);
                            break;
                        case DialogResult.No:
                            break;
                        default:
                            break;
                    }
                }
                else if (roomStatus == Convert.ToInt32(RoomStatus.Repairing))
                {
                    DialogResult result = MessageBox.Show("Phòng " + roomID.ToString() + " đang sửa. \nBạn có muốn tiếp tục đặt phòng này không?", "Thông báo!", MessageBoxButtons.YesNo);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            listRoomRent.Add(roomID);
                            //if (!roomOk)
                            //{
                            //    int a = DataAccess.CustomerDA.InsertNewClient(tbCustomerName.Text, dtpCustomerBirthday.Value, tbIDNo.Text, tbPassport.Text,
                            //    tbCustomerAddress.Text, tbCustomerPhoneNum.Text, rbtMale.Checked ? Sex.Male : Sex.Female);
                            //    int b = DataAccess.CustomerDA.InsertNewRoomReservation(dtpCheckInDate.Value, 0, 0, tbNote.Text);
                            //    roomOk = true;
                            //}
                            //int c = DataAccess.CustomerDA.InsertRoomReservationDetail(roomID);
                            break;
                        case DialogResult.No:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Phòng " + roomID.ToString() + " đang được thuê bởi một khách hàng khác. \nBạn không thể đặt phòng này!", "Lỗi", MessageBoxButtons.YesNo);
                }
            }
            if (listRoomRent.Count > 0)
            {

                int a = DataAccess.CustomerDA.InsertNewClient(tbCustomerName.Text, dtpCustomerBirthday.Value, tbIDNo.Text, tbPassport.Text,
                tbCustomerAddress.Text, tbCustomerPhoneNum.Text, rbtMale.Checked ? Sex.Male : Sex.Female);
                int b = DataAccess.CustomerDA.InsertNewRoomReservation(dtpCheckInDate.Value, 0, "a", 0, tbNote.Text);
                int d = DataAccess.CustomerDA.InsertNewBill(0, "a");
                foreach (int rID in listRoomRent)
                {
                    int c = DataAccess.CustomerDA.InsertRoomReservationDetail(0, rID);
                }
                MessageBox.Show("Bạn đã đặt phòng thành công!", "Thông báo!");
            }
            //this.Parent.Refresh();
            this.Hide();
            //if (a > 0 && b > 0)
            //{
            //    this.ParentRef._lbNumberOfEmptyRoom.Text = (Convert.ToInt32(this.ParentRef._lbNumberOfEmptyRoom.Text) - 1).ToString();
            //    this.ParentRef._lbNumberOfRentedRoom.Text = (Convert.ToInt32(this.ParentRef._lbNumberOfRentedRoom.Text) + 1).ToString();
            //    this.ParentRef._RoomStatus = RoomStatus.Rented;
            //    pbArrowBack_Click(sender, e);

            //}
            //else MessageBox.Show("Lỗi khi đặt phòng");
        }


        private void pbArrowBack_Click(object sender, EventArgs e)
        {
            this.ParentRef._lbRoomID.Hide();
            this.ParentRef._pnToAddARoomInfo.Controls.Remove(this);
            this.ParentRef._pnToAddARoomInfo.SendToBack();
        }
    }
}
