using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;

namespace HotelManagement.UI
{
    public partial class Form_BookMulRooms : UserControl
    {
        bool flag = true;
        List<Item_RoomOfFormBookMulRoom> RoomList = new List<Item_RoomOfFormBookMulRoom>();
        private List<DTO.CustomerOverview> Customers;
        private int ClientID = -1;
        private CancellationTokenSource cts;

        public Form_BookMulRooms(Form_Room parentRef)
        {
            InitializeComponent();
            this.dtpCustomerBirthday.Value = Convert.ToDateTime("2000-01-01");
            this.rbtMale.Checked = true;

            ParentRef = parentRef;

            dropDownList1.Hide();
            dropDownList1.ChooseItem += delegate
            {
                setCustomerInfoAlreadyExists(dropDownList1.selectedItemName);
            };
            cts = new CancellationTokenSource();

            this.ParentRef.Disposed += delegate { pbArrowBack_Click(this, null); };
        }

        private async Task LoadAllCustomer()
        {
            try
            {
                Customers = new List<DTO.CustomerOverview>();
                DataTable data = await Task.Run(() => {
                    try
                    {
                        return DataAccess.ExecuteQuery.ExecuteReader("QLKS_GetAllCustomerInfo");
                    }
                    catch
                    {
                        return null;
                    }
                });
                if (data == null) throw new Exception("Đã xảy ra lỗi khi tải thông tin từ server");
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    var item = new DTO.CustomerOverview();
                    item.ID = Convert.ToInt32(data.Rows[i].ItemArray[0]);
                    item.Name = Convert.ToString(data.Rows[i].ItemArray[1]);
                    item.Birthday = Convert.ToDateTime(data.Rows[i].ItemArray[2]);
                    item.PhoneNumber = Convert.ToString(data.Rows[i].ItemArray[3]);
                    item.sex = (Sex)Convert.ToInt32(data.Rows[i].ItemArray[4]);
                    item.IDNumber = Convert.ToString(data.Rows[i].ItemArray[5]);
                    item.Passport = Convert.ToString(data.Rows[i].ItemArray[6]);
                    item.Addr = Convert.ToString(data.Rows[0].ItemArray[7]);

                    Customers.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StatusLabel.Text = "Đã xảy ra lỗi";
            }
        }

        private void setCustomerInfoAlreadyExists(string selectedItemName)
        {
            int i;
            for (i = 0; i < Customers.Count
                && (selectedItemName != Customers[i].ID.ToString()); i++) { }
            ClientID = Customers[i].ID;
            if (i >= Customers.Count) return;
            tbCustomerName.Text = Customers[i].Name;
            dtpCustomerBirthday.Value = Customers[i].Birthday;
            tbCustomerPhoneNum.Text = Customers[i].PhoneNumber;
            SetValueForControl.SetSex(Customers[i].sex, rbtMale, rbtFemale);
            if (Customers[i].IDNumber.Length != 0)
            {
                if (!cbIDNo.Checked) cbIDNo.Checked = true;
                tbIDNo.Text = Customers[i].IDNumber;
            }
            else
            {
                if (!cbPassport.Checked) cbPassport.Checked = true;
                tbPassport.Text = Customers[i].Passport;
            }
            tbCustomerAddress.Text = Customers[i].Addr;
        }

        private void tbCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (tbCustomerName.Text != "")
            {
                if (TakeCustomerAlreadyExistsToMenuItems(tbCustomerName.Text))
                {
                    dropDownList1.Show();
                }
                else dropDownList1.Hide();
            }
            else
            {
                dropDownList1.Hide();
            }
        }

        private bool TakeCustomerAlreadyExistsToMenuItems(string customerName)
        {
            dropDownList1.clear();
            bool IsExist = false;
            foreach (var i in Customers)
            {
                string AdditionalInfo = (i.IDNumber.Length != 0) ? i.IDNumber : i.Passport;
                if (i.Name.ToLower().Contains(customerName.ToLower()))
                {
                    dropDownList1.addItem(i.Name + " | " + AdditionalInfo, i.ID.ToString());
                    IsExist = true;
                }
            }
            return IsExist;
        }

        private void pnCustomerInfo_Click(object sender, EventArgs e)
        {
            if (dropDownList1.Location.X > MousePosition.X || dropDownList1.Location.X + dropDownList1.Width < MousePosition.X ||
                dropDownList1.Location.Y > MousePosition.Y || dropDownList1.Location.Y + dropDownList1.Height < MousePosition.Y)
            {
                dropDownList1.Hide();
            }
        }

        async Task LoadRoomsData()
        {
            await Task.Run(() => {
                foreach (var i in ParentRef.listRoom)
                {
                    if (i._RoomStatus == RoomStatus.Empty || i._RoomStatus == RoomStatus.Cleaning)
                    {
                        Item_RoomOfFormBookMulRoom newItem = new Item_RoomOfFormBookMulRoom(i, this);
                        RoomList.Add(newItem);
                    }
                }
            });

            pnToSelectRoom.Controls.AddRange(RoomList.ToArray());
            emtyCount = RoomList.Count();
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

        private async void btBookRoom_Click(object sender, EventArgs e)
        {
            if (!checkValidityOfValue()) return;
            if (MessageBox.Show("Bạn có chắc chắn muốn đặt phòng?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    OverlayForm overlay = new OverlayForm(ParentRef.ParentRef, new LoadingForm(cts.Token));
                    overlay.Show();
                    List<Item_RoomOfFormBookMulRoom> listRoomID = new List<Item_RoomOfFormBookMulRoom>();
                    foreach (Item_RoomOfFormBookMulRoom item in RoomList)
                    {
                        if (item.isChoose)
                        {
                            listRoomID.Add(item);
                        }
                    }
                    if (listRoomID.Count > 0)
                    {
                        if (tbCustomerName.Text == "")
                        {
                            setCustomerInfoAlreadyExists("1");
                        }
                        if (ClientID <= 0)
                        {
                            int a = await Task.Run(() =>
                            {
                                try
                                {
                                    return DataAccess.CustomerDA.InsertNewCustomer(tbCustomerName.Text, dtpCustomerBirthday.Value,
                                        tbIDNo.Text, tbPassport.Text, tbCustomerAddress.Text, tbCustomerPhoneNum.Text, rbtMale.Checked ? Sex.Male : Sex.Female);
                                }
                                catch
                                {
                                    return -2;
                                }
                            });
                            if (a == -2) throw new Exception("Đã xảy ra lỗi khi tải thông tin từ server");
                        }
                        (int, int) bd = await Task.Run(() =>
                        {
                            try
                            {
                                int b = DataAccess.CustomerDA.InsertNewRoomReservation(dtpCheckInDate.Value, ClientID, ParentRef.Username, 0, tbNote.Text);
                                int d = DataAccess.CustomerDA.InsertNewBill(0, ParentRef.Username);
                                return (b, d);
                            }
                            catch
                            {
                                return (-2, -2);
                            }
                        });
                        if (bd == (-2, -2)) throw new Exception("Đã xảy ra lỗi khi tải thông tin từ server");
                        else 

                        foreach (Item_RoomOfFormBookMulRoom item in listRoomID)
                        {

                            int c = await Task.Run(() =>
                            {
                                try
                                {
                                    return DataAccess.CustomerDA.InsertRoomReservationDetail(0, item._RoomID);
                                }
                                catch
                                {
                                    return -2;
                                }
                            });
                            if (c == -2) throw new Exception("Đã xảy ra lỗi khi tải thông tin từ server");
                            item.ParentRefItemRoom._RoomStatus = RoomStatus.Rented;
                        }
                        ParentRef.Empty -= listRoomID.Count;
                        ParentRef.Rented += listRoomID.Count;
                        pbArrowBack_Click(sender, e);
                    }
                    else MessageBox.Show("Vui lòng chọn phòng!", "Thông báo!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    StatusLabel.Text = "Đặt phòng không thành công";
                }
                finally
                {
                    cts.Cancel();
                    cts.Dispose();
                    cts = new CancellationTokenSource();
                }
            }
        }


        private void pbArrowBack_Click(object sender, EventArgs e)
        {
            this.ParentRef._lbRoomID.Hide();
            this.ParentRef._pnToAddARoomInfo.Controls.Remove(this);
            this.ParentRef._pnToAddARoomInfo.SendToBack();

            tbCustomerName.TextChanged -= tbCustomerName_TextChanged;
            pnCustomerInfo.Click -= pnCustomerInfo_Click;
            this.Dispose();

            GC.Collect();
            GC.WaitForFullGCComplete();
        }

        private void cbPassport_CheckedChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                if (cbPassport.Checked == true)
                {
                    if (cbIDNo.Checked)
                    {
                        flag = false;
                        cbIDNo.Checked = false;
                    }
                    tbIDNo.Text = "";
                    tbIDNo.Enabled = false;
                    tbIDNo.IsEnabled = false;

                    tbPassport.Enabled = true;
                    tbPassport.IsEnabled = true;
                    tbPassport.Focus();
                }
                else cbIDNo.Checked = true;
            }
            else flag = true;
        }

        private void cbIDNo_CheckedChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                if (cbIDNo.Checked == true)
                {
                    if (cbPassport.Checked)
                    {
                        flag = false;
                        cbPassport.Checked = false;
                    }
                    tbPassport.Text = "";
                    tbPassport.Enabled = false;
                    tbPassport.IsEnabled = false;

                    tbIDNo.Enabled = true;
                    tbIDNo.IsEnabled = true;
                    tbIDNo.Focus();
                }
                else cbPassport.Checked = true;
            }
            else flag = true;
        }

        private async void Form_BookMulRooms_Load(object sender, EventArgs e)
        {
            OverlayForm overlay = new OverlayForm(ParentRef.ParentRef, new LoadingForm(cts.Token));
            overlay.Show();
            await LoadAllCustomer();
            await LoadRoomsData();
            cts.Cancel();
            cts.Dispose();
            cts = new CancellationTokenSource();
            this.Focus();
        }


        bool checkValidityOfValue()
        {
            if (!Regex.IsMatch(tbCustomerName.Text, @"^$|^([\p{L}]+( [\p{L}]+){0,})$"))
            {
                MessageBox.Show("Tên không được chứa ký tự đặt biệt và không chứa số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCustomerName.Focus();
                return false;
            }

            if (!Regex.IsMatch(tbCustomerPhoneNum.Text, @"^$|^[0-9]{10}$"))
            {
                MessageBox.Show("Số điện thoại gồm chỉ gồm 10 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCustomerPhoneNum.Focus();
                return false;
            }

            if (!Regex.IsMatch(tbIDNo.Text, @"^$|^[0-9]{9}$") && cbIDNo.Checked == true)
            {
                MessageBox.Show("CMNN gồm chỉ gồm 9 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbIDNo.Focus();
                return false;
            }

            return true;
        }

        private void pnToSelectRoom_ControlAdded(object sender, ControlEventArgs e)
        {
            lbListEmptyRoomIsEmpty.Hide();
        }

        private void pnToSelectRoom_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (pnToSelectRoom.Controls.Count == 1)
            {
                lbListEmptyRoomIsEmpty.Show();
            }
        }

        private void pnSeletedRoom_ControlAdded(object sender, ControlEventArgs e)
        {
            lbListSelectedRoomIsEmpty.Hide();
        }

        private void pnSeletedRoom_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (pnSeletedRoom.Controls.Count == 1)
            {
                lbListSelectedRoomIsEmpty.Show();
            }
        }
    }
}
