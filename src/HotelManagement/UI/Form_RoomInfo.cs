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
        private DTO.FullCustomerInfo Customer;
        private List<DTO.CustomerOverview> Customers;
        private int RoomID;
        private int ClientID = 0;
        private bool flag = true;
        private bool SearchFlag = false;
        private CancellationTokenSource cts;
        public Form_RoomInfo(Item_Room parent)
        {
            InitializeComponent();
            ParentRef = parent;
            ParentRef.ParentRef._lbRoomID.Show();

            dropDownList1.Hide();
            dropDownList1.ChooseItem += delegate
            {
                setCustomerInfoAlreadyExists(dropDownList1.selectedItemName);
            };
            cts = new CancellationTokenSource();

            this.ParentRef.ParentRef.Disposed += delegate { pbArrowBack_Click(this, null); };
        }
        private async Task LoadAllCustomer()
        {
            Customers = new List<DTO.CustomerOverview>();
            DataTable data = await Task.Run(() => DataAccess.ExecuteQuery.ExecuteReader("QLKS_GetAllCustomerInfo"));
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

        #region Properties
        public Item_Room ParentRef;
        #endregion

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
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải thông tin từ server", "Lỗi");
                StatusLabel.Text = "Không có kết nối";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StatusLabel.Text = "Đã xảy ra lỗi";
            }
        }

        private async void Form_RoomInfo_Load(object sender, EventArgs e)
        {
            OverlayForm overlay = new OverlayForm(ParentRef.ParentRef.ParentRef, new LoadingForm(cts.Token));
            overlay.Show();
            await BackgroundTask();

            cts.Cancel();
            cts.Dispose();
            cts = new CancellationTokenSource();
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

            DTO.RoomDetail room = await Task.Run(() => new DTO.RoomDetail(RoomID));
            tbRoomsize.Text = room.Size.ToString();
            tbRoomPrice.Text = room.Price.ToString();
            SetValueForControl.SetRoomType(room.Type, rbtNor, rbtVip, rbtSingle, rbtDouble);

            if (this.ParentRef._RoomStatus == RoomStatus.Rented)
            {
                btSave.Show();
                Customer = await Task.Run(() => new DTO.FullCustomerInfo(RoomID));
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
                dtpCheckInDate.Value = Customer.CheckInDate;
            }
            else
            {
                Customer = null;
                btSave.Hide();
            }
            SearchFlag = true;
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

        private void cbCheckOutDate_Click(object sender, EventArgs e)
        {
            if (cbCheckOutDate.Checked == true)
            {
                dtpCheckOutDate.Enabled = true;
            }
            else
            {
                dtpCheckOutDate.Enabled = false;
            }
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

        private void btBookRoom_Click(object sender, EventArgs e)
        {
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef.ParentRef.ParentRef, new LoadingForm(cts.Token));
                overlay.Show();
                //if (!checkEmptyValue()) return;
                if (!checkValidityOfValue()) return;
                int a = 0;
                if (ClientID <= 0)
                {
                    a = DataAccess.CustomerDA.InsertNewCustomer(tbCustomerName.Text, dtpCustomerBirthday.Value, tbIDNo.Text, tbPassport.Text,
                        tbCustomerAddress.Text, tbCustomerPhoneNum.Text, rbtMale.Checked ? Sex.Male : Sex.Female);
                }
                int b = DataAccess.CustomerDA.InsertNewRoomReservation(dtpCheckInDate.Value, ClientID, ParentRef.ParentRef.Username, 0, tbNote.Text);
                int c = DataAccess.CustomerDA.InsertRoomReservationDetail(0, this.ParentRef._RoomID);
                int d = DataAccess.CustomerDA.InsertNewBill(0, ParentRef.ParentRef.Username);
                if (b > 0 && c > 0 && d > 0)
                {
                    ParentRef.ParentRef.Empty = ParentRef.ParentRef.Empty - 1;
                    ParentRef.ParentRef.Rented = ParentRef.ParentRef.Rented + 1;
                    ParentRef._RoomStatus = RoomStatus.Rented;
                    MessageBox.Show("Đặt phòng thành công!", "Thông báo");
                    pbArrowBack_Click(sender, e);
                }
                else MessageBox.Show("Lỗi khi đặt phòng");
                StatusLabel.Text = "";
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

            if (!Regex.IsMatch(tbIDNo.Text, @"^$|^[0-9]{9}$") && cbIDNo.Checked==true)
            {
                MessageBox.Show("CMNN gồm chỉ gồm 9 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbIDNo.Focus();
                return false;
            }

            return true;
        }

        private async void btPay_Click(object sender, EventArgs e)
        {
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef.ParentRef.ParentRef, new LoadingForm(cts.Token));
                overlay.Show();
                DataTable data = await Task.Run(() => DataAccess.CustomerDA.GetRoomReservationDetailInfo(0, 0, RoomID));
                int RowEffected = await Task.Run(() => DataAccess.CustomerDA.Payment(0, 0, RoomID, ParentRef.ParentRef.Username));
                if (RowEffected > 0)
                {
                    printPreviewDialogBill.Document = bill;
                    printPreviewDialogBill.ShowDialog();
                    await Task.Run(() => DataAccess.CustomerDA.SetRoomReservationStatus(0, 0, RoomID));
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        for (int j = 0; j < ParentRef.ParentRef.listRoom.Count; j++)
                        {
                            if (ParentRef.ParentRef.listRoom[j]._RoomID == Convert.ToInt32(data.Rows[i].ItemArray[0]))
                            {
                                ParentRef.ParentRef.listRoom[j]._RoomStatus = RoomStatus.Cleaning;
                            }
                        }
                        await Task.Run(() => DataAccess.RoomDA.SetRoomStatus(Convert.ToInt32(data.Rows[i].ItemArray[0]), RoomStatus.Cleaning));
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
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Lỗi khi kết nối đến server!", "Lỗi");
                StatusLabel.Text = "Thanh toán thất bại!";
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

        private async void btSettingRoom_Click(object sender, EventArgs e)
        {
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef.ParentRef.ParentRef, new LoadingForm(cts.Token));
                overlay.Show();
                DTO.RoomDetail room = await Task.Run(() => new DTO.RoomDetail(RoomID));
                Form_AddEditRoom form_AddEditRoom = new Form_AddEditRoom(room);
                form_AddEditRoom._btAdd.Hide();
                if (form_AddEditRoom.ShowDialog() == DialogResult.OK)
                {
                    tbRoomsize.Text = form_AddEditRoom.RoomSize.ToString();
                    tbRoomPrice.Text = form_AddEditRoom.Price.ToString();
                    SetValueForControl.SetRoomType(form_AddEditRoom.Type, rbtNor, rbtVip, rbtSingle, rbtDouble);
                }
                StatusLabel.Text = "";
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Lỗi khi kết nối đến server!", "Lỗi");
                StatusLabel.Text = "Không thể lấy thông tin phòng...";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StatusLabel.Text = "Không thể lấy thông tin phòng...";
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
                this.Focus();
            }
        }

        private void bill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DTO.RoomServices svc = new DTO.RoomServices(0, 0, RoomID);
            DrawBill drawBill = new DrawBill(e.Graphics);
            drawBill.drawBillHeader();
            drawBill.drawCustomerInfo(Customer.Name, Customer.PhoneNumber, Customer.Addr,
                dtpCheckInDate.Text, dtpCheckOutDate.Text);
            int TotalMoney = 0;
            for (int i = 0; i < svc.items.Count; i++)
            {
                drawBill.drawItem(svc.items[i].Name, svc.items[i].Count, svc.items[i].Price, svc.items[i].IntoMoney);
                TotalMoney += svc.items[i].IntoMoney;
            }
            DTO.StaffOverview staff = new DTO.StaffOverview(this.ParentRef.ParentRef.Username);
            drawBill.drawEndOfBill(staff.Name, TotalMoney, 0);
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
                dropDownList1.Location.Y> MousePosition.Y || dropDownList1.Location.Y+dropDownList1.Height < MousePosition.Y)
            {
                dropDownList1.Hide();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef.ParentRef.ParentRef, new LoadingForm(cts.Token));
                overlay.Show();
                int RowsAffected = DataAccess.CustomerDA.ChangeReservationInfo(RoomID, tbCustomerName.Text, dtpCustomerBirthday.Value, tbCustomerPhoneNum.Text,
                                    rbtMale.Checked ? Sex.Male : Sex.Female, tbIDNo.Text, tbPassport.Text, tbCustomerAddress.Text, dtpCheckInDate.Value, tbNote.Text);
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
    }
}
