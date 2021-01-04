using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Threading;

namespace HotelManagement.UI
{
    public partial class Form_RoomInfo : UserControl
    {
        #region Properties
        public Item_Room ParentRef;
        private DTO.FullCustomerInfo Customer;
        private List<DTO.CustomerOverview> Customers;
        private int RoomID;
        private int ClientID = 0;
        private bool flag = true;
        private bool SearchFlag = false;
        private CancellationTokenSource cts;
        int TotalMoney = 0;
        int numOfItemPerPage = 0;
        int countItem = 0;
        private int totalMoneyService;
        public FlowLayoutPanel _pnAddSevice
        {
            get { return pnAddSevice; }
        }

        public int TotalMoneyService
        {
            get => totalMoneyService;
            set 
            {
                totalMoneyService = value;
                this.lbTotalMoney.Text = value.ToString();
            }
        }
        #endregion

        #region Contrustor
        public Form_RoomInfo(Item_Room parent)
        {
            InitializeComponent();
            //
            this.dtpCustomerBirthday.Value = Convert.ToDateTime("2000-01-01");
            this.rbtMale.Checked = true;
            this.lbArrivalDate.Text = DateTime.Now.ToString();
            //
            ParentRef = parent;
            ParentRef.ParentRef._lbRoomID.Show();
            if(ParentRef.ParentRef.ParentRef.StaffPosition != "Quản lý")
            {
                btSettingRoom.Hide();
            }

            dropDownList1.Hide();
            dropDownList1.ChooseItem += delegate
            {
                setCustomerInfoAlreadyExists(dropDownList1.selectedItemName);
            };
            cts = new CancellationTokenSource();

            this.ParentRef.ParentRef.Disposed += delegate { pbArrowBack_Click(this, null); };
            /////
            ///
            DataTable dataTable = DataAccess.Bill.GetBillDetailInfo(0, 0, this.ParentRef._RoomID);

            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string name = dataTable.Rows[i].ItemArray[0].ToString();
                    string count = dataTable.Rows[i].ItemArray[1].ToString();
                    string price = Convert.ToInt32(dataTable.Rows[i].ItemArray[2]).ToString();
                    string ID = dataTable.Rows[i].ItemArray[4].ToString();
                    Item_EatService2 item = new Item_EatService2(this, ID, name, count, price);
                    pnAddSevice.Controls.Add(item);
                    this.TotalMoneyService += Convert.ToInt32(count) * Convert.ToInt32(dataTable.Rows[i].ItemArray[2]);
                    //this.lbTotalMoney.Text = (Convert.ToInt32(lbTotalMoney.Text) + Convert.ToInt32(count) * Convert.ToInt32(dataTable.Rows[i].ItemArray[2])).ToString();
                   
                }
            }


        }
        #endregion

        #region Task
        private async Task LoadAllCustomer()
        {
            Customers = new List<DTO.CustomerOverview>();
            DataTable data = await Task.Run(() =>
            {
                try
                {
                    return DataAccess.Customer.GetAllCustomerInfo();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải thông tin từ server", "Lỗi");
                    return null;
                }
            });
            
            if (data != null)
            {
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
                    item.Addr = Convert.ToString(data.Rows[i].ItemArray[7]);

                    Customers.Add(item);
                }
            }
            else StatusLabel.Text = "Không có kết nối";
        }
        private async Task BackgroundTask()
        {
            try
            {
                StatusLabel.Text = "Đang xử lí...";
                await LoadAllCustomer();
                await Load_Data();
                tbCustomerName.Focus();
                pnVip_Nor.Enabled = false;
                pnSignle_Dou.Enabled = false;
                tbRoomsize.IsEnabled = false;
                tbRoomPrice.IsEnabled = false;
                StatusLabel.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StatusLabel.Text = "Đã xảy ra lỗi";
            }
        }
        private async Task Load_Data()
        {
            RoomID = this.ParentRef._RoomID;
            if (this.ParentRef._RoomStatus == RoomStatus.Empty)
            {
                btPay.Hide();
            }
            else
            {
                btBookRoom.Hide();
            }

            DTO.RoomDetail room = await Task.Run(() => {
                try
                {
                    return new DTO.RoomDetail(RoomID);
                }
                catch
                {
                    return null;
                }
            });
            if (room != null)
            {
                tbRoomsize.Text = room.Size.ToString();
                tbRoomPrice.Text = room.Price.ToString();
                SetValueForControl.SetRoomType(room.Type, rbtNor, rbtVip, rbtSingle, rbtDouble);
            }
            else StatusLabel.Text = "Không có kết nối";

            if (this.ParentRef._RoomStatus == RoomStatus.Rented)
            {
                btSave.Show();
                Customer = await Task.Run(() => { 
                    try
                    {
                        return new DTO.FullCustomerInfo(RoomID);
                    }
                    catch
                    {
                        return null;
                    }
                });
                if (Customer != null)
                {
                    tbCustomerName.Text = Customer.Name;
                    dtpCustomerBirthday.Value = Customer.Birthday;
                    tbCustomerPhoneNum.Text = Customer.PhoneNumber;
                    SetValueForControl.SetSex(Customer.sex, rbtMale, rbtFemale);
                    if (Customer.IDNumber.Length != 0)
                    {
                        if (!cbIDNo.Checked) cbIDNo.Checked = true;
                        tbIDNo.Text = Customer.IDNumber;
                    }
                    else
                    {
                        if (!cbPassport.Checked) cbPassport.Checked = true;
                        tbPassport.Text = Customer.Passport;
                    }
                    tbCustomerAddress.Text = Customer.Addr;
                    tbNote.Text = Customer.Note;
                    //dtpCheckInDate.Value = Customer.CheckInDate;
                    lbArrivalDate.Text = Customer.CheckInDate.ToString();
                }
                else StatusLabel.Text = "Không có kết nối";
            }
            else
            {
                Customer = null;
                btSave.Hide();
            }
            SearchFlag = true;
        }
        #endregion

        #region Procedure
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
                if (!cbIDNo.Checked) cbPassport.Checked = true;
                tbIDNo.Text = Customers[i].IDNumber;
            }
            else
            {
                if (!cbPassport.Checked) cbPassport.Checked = true;
                tbPassport.Text = Customers[i].Passport;
            }
            tbCustomerAddress.Text = Customers[i].Addr;
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
        #endregion

        #region Event
        private async void Form_RoomInfo_Load(object sender, EventArgs e)
        {
            OverlayForm overlay = new OverlayForm(ParentRef.ParentRef.ParentRef, new LoadingForm(cts.Token));
            overlay.Show();
            await BackgroundTask();

            cts.Cancel();
            cts.Dispose();
            cts = new CancellationTokenSource();
        }
        private void pbArrowBack_Click(object sender, EventArgs e)
        {
            this.ParentRef.ParentRef._lbRoomID.Hide();
            this.ParentRef.ParentRef._pnToAddARoomInfo.Controls.Remove(this);
            this.ParentRef.ParentRef._pnToAddARoomInfo.SendToBack();

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
        private async void btBookRoom_Click(object sender, EventArgs e)
        {
            if (!checkValidityOfValue()) return;
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef.ParentRef.ParentRef, new LoadingForm(cts.Token));
                overlay.Show();
                //if (!checkEmptyValue()) return;
                if (MessageBox.Show("Bạn có chắc chắn muốn đặt phòng?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int a = 0;
                    if (tbCustomerName.Text == "")
                    {
                        setCustomerInfoAlreadyExists("1");
                    }
                    if (ClientID <= 0)
                    {
                        a = await Task.Run(() =>
                        {
                            try
                            {
                                return DataAccess.Customer.InsertNewCustomer(tbCustomerName.Text, dtpCustomerBirthday.Value, tbIDNo.Text, tbPassport.Text,
                                        tbCustomerAddress.Text, tbCustomerPhoneNum.Text, rbtMale.Checked ? Sex.Male : Sex.Female);
                            }
                            catch
                            {
                                return -2;
                            }
                        });
                        if (a == -2) throw new Exception("Lỗi khi kết nối đến server");
                    }

                    (int, int, int) bcd = await Task.Run(() =>
                    {
                        try
                        {
                            int b = DataAccess.Room.InsertNewRoomReservation(Convert.ToDateTime(lbArrivalDate.Text), ClientID, ParentRef.ParentRef.Username, 0, tbNote.Text);
                            int c = DataAccess.Room.InsertRoomReservationDetail(0, this.ParentRef._RoomID);
                            int d = DataAccess.Bill.InsertNewBill(0, ParentRef.ParentRef.Username);

                            MessageBox.Show("Bạn đã đặt phòng thành công!", "Thông báo!");
                            return (b, c, d);
                        }
                        catch
                        {
                            return (-2, -2, -2);
                        }
                    });
                    if (bcd == (-2, -2, -2)) throw new Exception("Lỗi khi kết nối đến server");
                    else if (bcd.Item1 > 0 && bcd.Item2 > 0 && bcd.Item3 > 0)
                    {
                        ParentRef.ParentRef.Empty = ParentRef.ParentRef.Empty - 1;
                        ParentRef.ParentRef.Rented = ParentRef.ParentRef.Rented + 1;
                        ParentRef._RoomStatus = RoomStatus.Rented;
                        //MessageBox.Show("Đặt phòng thành công!", "Thông báo");
                        pbArrowBack_Click(sender, e);
                    }
                    else MessageBox.Show("Lỗi khi đặt phòng");
                    StatusLabel.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StatusLabel.Text = "Có lỗi xảy ra";
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
            if (MessageBox.Show("Bạn chắc chắn muốn thanh toán?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    OverlayForm overlay = new OverlayForm(ParentRef.ParentRef.ParentRef, new LoadingForm(cts.Token));
                    overlay.Show();

                    DataTable data = await Task.Run(() =>
                    {
                        try
                        {
                            return DataAccess.Room.GetRoomReservationDetailInfo(0, 0, RoomID);
                        }
                        catch
                        {
                            return null;
                        }
                    });
                    if (data == null) throw new Exception("Lỗi khi kết nối đến server!");

                    int RowEffected = await Task.Run(() =>
                    {
                        try
                        {
                            return DataAccess.Room.Payment(0, 0, RoomID, ParentRef.ParentRef.Username);
                        }
                        catch
                        {
                            return -2;
                        }
                    });
                    if (RowEffected == -2) throw new Exception("Lỗi khi kết nối đến server!");

                    if (RowEffected > 0)
                    {
                        TotalMoney = 0;
                        numOfItemPerPage = 0;
                        countItem = 0;
                        printPreviewDialogBill.Document = bill;
                        printPreviewDialogBill.ShowDialog();
                        int a = await Task.Run(() =>
                        {
                            try
                            {
                                return DataAccess.Room.SetRoomReservationStatus(0, 0, RoomID);
                            }
                            catch
                            {
                                return -2;
                            }
                        });
                        if (a == -2) throw new Exception("Lỗi khi kết nối đến server!");

                        for (int i = 0; i < data.Rows.Count; i++)
                        {
                            for (int j = 0; j < ParentRef.ParentRef.listRoom.Count; j++)
                            {
                                if (ParentRef.ParentRef.listRoom[j]._RoomID == Convert.ToInt32(data.Rows[i].ItemArray[0]))
                                {
                                    ParentRef.ParentRef.listRoom[j]._RoomStatus = RoomStatus.Cleaning;
                                }
                            }
                            int b = await Task.Run(() =>
                            {
                                try
                                {
                                    return DataAccess.Room.SetRoomStatus(Convert.ToInt32(data.Rows[i].ItemArray[0]), RoomStatus.Cleaning);
                                }
                                catch
                                {
                                    return -2;
                                }
                            });
                            if (b == -2) throw new Exception("Lỗi khi kết nối đến server!");
                        }
                        ParentRef.ParentRef.Cleaning += data.Rows.Count;
                        ParentRef.ParentRef.Rented -= data.Rows.Count;
                        pbArrowBack_Click(sender, e);
                        StatusLabel.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán thất bại!", "Lỗi");
                        StatusLabel.Text = "Thanh toán thất bại!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    StatusLabel.Text = "Thanh toán thất bại!";
                }
                finally
                {
                    cts.Cancel();
                    cts.Dispose();
                    cts = new CancellationTokenSource();
                }
            }
        }
        private async void btSettingRoom_Click(object sender, EventArgs e)
        {
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef.ParentRef.ParentRef, new LoadingForm(cts.Token));
                overlay.Show();
                DTO.RoomDetail room = await Task.Run(() => {
                    try
                    {
                        return new DTO.RoomDetail(RoomID);
                    }
                    catch
                    {
                        return null;
                    }
                });
                if (room == null) throw new Exception("Lỗi khi tải thông tin phòng");

                Form_AddEditRoom form_AddEditRoom = new Form_AddEditRoom(room);
                form_AddEditRoom._btAdd.Hide();
                if (form_AddEditRoom.ShowDialog() == DialogResult.OK)
                {
                    tbRoomsize.Text = form_AddEditRoom.RoomSize.ToString();
                    tbRoomPrice.Text = form_AddEditRoom.Price.ToString();
                    SetValueForControl.SetRoomType(form_AddEditRoom.Type, rbtNor, rbtVip, rbtSingle, rbtDouble);
                    this.ParentRef._RoomType = form_AddEditRoom.Type;
                }
                StatusLabel.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            try
            {
                DTO.RoomServices svc = new DTO.RoomServices(0, 0, RoomID);
                DrawBill drawBill = new DrawBill(e.Graphics);
                drawBill.drawBillHeader();
                DataTable roomReservationInfo = DataAccess.Room.GetRoomReservationInfo(0, RoomID);
                drawBill.drawCustomerInfo(Customer.Name, Customer.PhoneNumber, Customer.Addr,
                                            roomReservationInfo.Rows[0].ItemArray[1].ToString(), DateTime.Now.ToString());
                for (int i = countItem; i < svc.items.Count; i++)
                {
                    drawBill.drawItem(svc.items[i].Name, svc.items[i].Count, svc.items[i].Price, svc.items[i].IntoMoney);
                    TotalMoney += svc.items[i].IntoMoney;
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
                DTO.StaffOverview staff = new DTO.StaffOverview(this.ParentRef.ParentRef.Username);
                drawBill.drawEndOfBill(staff.Name, TotalMoney, 0);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Lỗi khi tải thông tin từ server");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tbCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (tbCustomerName.Text != "" && SearchFlag)
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
        private void pnCustomerInfo_Click(object sender, EventArgs e)
        {
            if (dropDownList1.Location.X > MousePosition.X || dropDownList1.Location.X + dropDownList1.Width < MousePosition.X ||
                dropDownList1.Location.Y> MousePosition.Y || dropDownList1.Location.Y+dropDownList1.Height < MousePosition.Y)
            {
                dropDownList1.Hide();
            }
        }
        private async void btSave_Click(object sender, EventArgs e)
        {
            if (!checkValidityOfValue()) return;
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef.ParentRef.ParentRef, new LoadingForm(cts.Token));
                overlay.Show();
                int RowsAffected = await Task.Run(() => {
                    try
                    {
                        return DataAccess.Room.ChangeReservationInfo(RoomID, tbCustomerName.Text, dtpCustomerBirthday.Value, tbCustomerPhoneNum.Text,
                                rbtMale.Checked ? Sex.Male : Sex.Female, tbIDNo.Text, tbPassport.Text, tbCustomerAddress.Text, Convert.ToDateTime(lbArrivalDate.Text), tbNote.Text);
                    }
                    catch
                    {
                        return -2;
                    }
                });

                if (RowsAffected == -2) throw new Exception("Lỗi khi kết nối đến server!");
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Sửa thông tin thành công!", "Thành công");
                    StatusLabel.Text = "";
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Lỗi khi kết nối đến server!", "Lỗi");
                StatusLabel.Text = "Không có kết nối";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StatusLabel.Text = "Có lỗi xảy ra";
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
            }
        }
        #endregion

        private void btSaveSevice_Click(object sender, EventArgs e)
        {
            //int ef = DataAccess.Bill.RemoveBillDetail(0, 0, this.RoomID);
            //foreach(Item_EatService2 item in this.pnAddSevice.Controls.selec)
            //{

            //}
            //for (int i = 0; i < this.pnAddSevice.Controls.Count; i++)
            //{
            //    DataAccess.Bill.InsertServiceToServicesBillOnlyDetail(this.pnAddSevice.)
            //}
        }
    }
}
