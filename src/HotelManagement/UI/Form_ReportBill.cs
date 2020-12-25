using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HotelManagement.UI
{
    public partial class Form_ReportBill : UserControl
    {
        public Form_Main ParentRef;
        private CancellationTokenSource cts;
        public Form_ReportBill(Form_Main ParentRef)
        {
            InitializeComponent();
            this.ParentRef = ParentRef;
            cts = new CancellationTokenSource();
        }

        private async Task LoadStaffData()
        {
            DataTable dataStaff = await Task.Run(() => {
                try
                {
                    return DataAccess.Report.GetAllStaffInfo(-1);
                }
                catch
                {
                    return null;
                }
            });
            if (dataStaff == null) throw new Exception("Đã xảy ra lỗi khi tải thông tin từ server");
            for (int i = 0; i < dataStaff.Rows.Count; i++)
            {
                cbStaff.Items.Add(dataStaff.Rows[i].ItemArray[0].ToString() + " | " + dataStaff.Rows[i].ItemArray[2].ToString());
            }
        }
        private async Task LoadRoomNSvcsBillInfo()
        {
            try
            {
                while (pnAddItem.Controls.Count > 0) pnAddItem.Controls[0].Dispose();
                GC.Collect();

                DateTime Start = dtStart.Value;
                DateTime End = dtEnd.Value;
                int SelectedStaff = cbStaff.SelectedIndex;
                int SelectedSort = cbSort.SelectedIndex;
                DataTable dataBillInfo = await Task.Run(() => {
                    try
                    {
                        return DataAccess.Report.GetAllBillInfo(Start, End, SelectedStaff, SelectedSort);
                    }
                    catch
                    {
                        return null;
                    }
                });
                if (dataBillInfo == null) throw new Exception("Đã xảy ra lỗi khi tải thông tin từ server");
                for (int i = 0; i < dataBillInfo.Rows.Count; i++)
                {
                    Item_ReportBill itemBillInfo = new Item_ReportBill(this,
                        Convert.ToInt32(dataBillInfo.Rows[i].ItemArray[0]),
                        Convert.ToDateTime(dataBillInfo.Rows[i].ItemArray[1].ToString()).ToShortDateString(),
                        Convert.ToInt32(dataBillInfo.Rows[i].ItemArray[2]),
                        dataBillInfo.Rows[i].ItemArray[3].ToString(),
                        Convert.ToInt32(dataBillInfo.Rows[i].ItemArray[4]),
                        Convert.ToInt32(dataBillInfo.Rows[i].ItemArray[5]),
                        Convert.ToInt32(dataBillInfo.Rows[i].ItemArray[6]),
                        //Convert.ToInt32(dataBillInfo.Rows[i].ItemArray[7]),
                        0,
                        true
                        );
                    itemBillInfo.billType = BillType.RoomNSvcs;
                    pnAddItem.Controls.Add(itemBillInfo);
                }

                if (pnAddItem.Controls.Count == 0)
                {
                    createlbEmptyBillList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void createlbEmptyBillList()
        {
            this.lbListBillIsEmpty = new Label();
            this.pnAddItem.Controls.Add(lbListBillIsEmpty);
            this.lbListBillIsEmpty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListBillIsEmpty.Location = new System.Drawing.Point(3, 0);
            this.lbListBillIsEmpty.Name = "lbEmptyBillList";
            this.lbListBillIsEmpty.Size = new System.Drawing.Size(915, 44);
            this.lbListBillIsEmpty.TabIndex = 2;
            this.lbListBillIsEmpty.Text = "Chưa có hóa đơn nào!";
            this.lbListBillIsEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        private async Task LoadServicesBillInfo()
        {
            try
            {
                while (pnAddItem.Controls.Count > 0) pnAddItem.Controls[0].Dispose();
                GC.Collect();

                DateTime Start = dtStart.Value;
                DateTime End = dtEnd.Value;
                int SelectedStaff = cbStaff.SelectedIndex;
                int SelectedSort = cbSort.SelectedIndex;
                DataTable dataSVBillInfo = await Task.Run(() => {
                    try
                    {
                        return DataAccess.Report.GetAllServicesBillOnlyInfo(Start, End, SelectedStaff, SelectedSort);
                    }
                    catch
                    {
                        return null;
                    }
                });
                if (dataSVBillInfo == null) throw new Exception("Đã xảy ra lỗi khi tải thông tin từ server");
                for (int i = 0; i < dataSVBillInfo.Rows.Count; i++)
                {
                    Item_ReportBill itemSVBillInfo = new Item_ReportBill(this,
                        Convert.ToInt32(dataSVBillInfo.Rows[i].ItemArray[0]),
                        Convert.ToDateTime(dataSVBillInfo.Rows[i].ItemArray[1].ToString()).ToShortDateString(),
                        Convert.ToInt32(dataSVBillInfo.Rows[i].ItemArray[2]),
                        dataSVBillInfo.Rows[i].ItemArray[3].ToString(),
                        Convert.ToInt32(dataSVBillInfo.Rows[i].ItemArray[4]),
                        Convert.ToInt32(dataSVBillInfo.Rows[i].ItemArray[5]),
                        Convert.ToInt32(dataSVBillInfo.Rows[i].ItemArray[6]),
                        //Convert.ToInt32(dataBillInfo.Rows[i].ItemArray[7]),
                        0,
                        true
                        );
                    itemSVBillInfo.billType = BillType.Services;
                    pnAddItem.Controls.Add(itemSVBillInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef, new LoadingForm(cts.Token));
                overlay.Show();

                if (!cbBillorServicesBill.Checked)
                {
                    await LoadRoomNSvcsBillInfo();
                }
                else
                {
                    await LoadServicesBillInfo();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải thông tin từ server");
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

        private async void cbBillorServicesBill_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef, new LoadingForm(cts.Token));
                overlay.Show();

                if (!cbBillorServicesBill.Checked)
                {
                    await LoadRoomNSvcsBillInfo();
                }
                else
                {
                    await LoadServicesBillInfo();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải thông tin từ server");
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

        private async void Form_ReportBill_Load(object sender, EventArgs e)
        {
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef, new LoadingForm(cts.Token));
                overlay.Show();
                await LoadStaffData();
                await LoadRoomNSvcsBillInfo();
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
    }
}
