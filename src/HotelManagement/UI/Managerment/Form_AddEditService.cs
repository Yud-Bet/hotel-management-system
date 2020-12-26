using HotelManagement.Properties;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HotelManagement.UI
{
    public partial class Form_AddEditService : MetroFramework.Forms.MetroForm
    {
        OpenFileDialog open = new OpenFileDialog();
        CancellationTokenSource cts = new CancellationTokenSource();
        #region Icon
        private static Bitmap Washing = Resources.washing;
        private static Bitmap Iron = Resources.iron;
        #endregion

        public Form_AddEditService(Item_ServiceManager parentRefItem, Form_ServiceManager parentRefForm, ServiceManagerType type)
        {
            InitializeComponent();
            this.parentRefForm = parentRefForm;
            this.formType = type;
            switch (type)
            {
                case ServiceManagerType.AddEatService:
                    formType = ServiceManagerType.AddEatService;
                    btAddService.Show();
                    this.tbName.PlaceHolderText = "Dịch vụ mới";
                    this.tbPrice.Text = "0";
                    break;
                case ServiceManagerType.EditEatService:
                    formType = ServiceManagerType.EditEatService;
                    btAddService.Hide();
                    this.parentRefItem = parentRefItem;
                    this.tbName.Text = this.parentRefItem._name;
                    this.tbPrice.Text = this.parentRefItem._price.ToString();
                    try
                    {
                        string[] staffImageFiles = Directory.GetFiles(@".\\serviceimage", parentRefItem._name + "*");
                        Image image;
                        using (Stream stream = File.OpenRead(staffImageFiles[0]))
                        {
                            image = System.Drawing.Image.FromStream(stream);
                        }
                        pbServiceImage.Image = image;
                    }
                    catch { }
                    break;
                case ServiceManagerType.EditWashService:
                    formType = ServiceManagerType.EditWashService;
                    btAddService.Hide();
                    this.tbName.Enabled = false;
                    this.tbName.Text = this.parentRefForm.ItemLaundry._name;
                    this.tbPrice.Text = this.parentRefForm.ItemLaundry._price.ToString();
                    pbServiceImage.Image = Washing;
                    btAddServiceImage.Hide();
                    break;
                case ServiceManagerType.EditIronService:
                    btAddService.Hide();
                    this.tbName.Enabled = false;
                    this.tbName.Text = this.parentRefForm.ItemIron._name;
                    this.tbPrice.Text = this.parentRefForm.ItemIron._price.ToString();
                    pbServiceImage.Image = Iron;
                    btAddServiceImage.Hide();
                    break;
                default:

                    break;
            }
        }

        #region properties
        ServiceManagerType formType;
        Item_ServiceManager parentRefItem;
        Form_ServiceManager parentRefForm;
        #endregion

        private async void btAddService_Click(object sender, EventArgs e)
        {
            if (!checkValidValue()) return;

            try
            {
                OverlayForm overlay = new OverlayForm(this, new LoadingForm(cts.Token));
                overlay.Show();

                string ItemName = tbName.Text;
                int Price = Convert.ToInt32(tbPrice.Text);
                int ef = await Task.Run(()=> {
                    try
                    {
                        return DataAccess.Manager.AddNewService(ServiceType.Eating, ItemName, Price);
                    }
                    catch
                    {
                        return -2;
                    }
                });
                if (ef == -2) throw new Exception("Lỗi khi kết nối đến server");
                else if (ef > 0)
                {
                    DataTable data = await Task.Run(()=> {
                        try
                        {
                            return DataAccess.Manager.GetServiceIdOfNewService();
                        }
                        catch
                        {
                            return null;
                        }
                    });
                    if (data == null) throw new Exception("Lỗi khi kết nối đến server");
                    Item_ServiceManager item = new Item_ServiceManager(Convert.ToInt32(data.Rows[0].ItemArray[0]), tbName.Text, Convert.ToInt32(tbPrice.Text), this.parentRefForm);
                    this.parentRefForm._pnToAddItem.Controls.Add(item);
                    this.parentRefForm.Services.Add(item);

                    try
                    {
                        if (open.FileName != "")
                        {
                            if (!Directory.Exists(@".\\serviceimage"))
                            {
                                Directory.CreateDirectory(@".\\serviceimage");
                            }

                            string[] staffImageFiles = Directory.GetFiles(@".\\serviceimage", item._name + "*");

                            foreach (string i in staffImageFiles)
                            {
                                File.Delete(i);
                            }

                            File.Copy(open.FileName, @".\\serviceimage\\" + item._name + Path.GetExtension(open.FileName));
                            item.setServiceImage();
                        }
                    }
                    catch { }

                    MessageBox.Show("Thêm dịch vụ mới thành công!", "Thông báo!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
            }
        }

        private async void btSave_Click(object sender, EventArgs e)
        {
            if (!checkValidValue()) return;
            try
            {
                OverlayForm overlay = new OverlayForm(this, new LoadingForm(cts.Token));
                overlay.Show();

                string ItemName = tbName.Text;
                int Price = Convert.ToInt32(tbPrice.Text);
                switch (formType)
                {
                    case ServiceManagerType.EditEatService:
                        int ItemID = this.parentRefItem._itemID;
                        int ef = await Task.Run(() => {
                        try
                        {
                            return DataAccess.Manager.SetServiceInfo(ItemID, ItemName, Price);
                        }
                        catch
                        {
                            return -2;
                        }
                        });
                        if (ef == -2) throw new Exception("Lỗi khi kết nối đến server");
                        else if (ef > 0)
                        {
                            this.parentRefItem._name = tbName.Text;
                            this.parentRefItem._price = Convert.ToInt32(tbPrice.Text);

                            try
                            {
                                if (open.FileName != "")
                                {
                                    if (!Directory.Exists(@".\\serviceimage"))
                                    {
                                        Directory.CreateDirectory(@".\\serviceimage");
                                    }

                                    string[] staffImageFiles = Directory.GetFiles(@".\\serviceimage", parentRefItem._name + "*");

                                    foreach (string i in staffImageFiles)
                                    {
                                        File.Delete(i);
                                    }

                                    File.Copy(open.FileName, @".\\serviceimage\\" + parentRefItem._name + Path.GetExtension(open.FileName));
                                    parentRefItem.setServiceImage();
                                }
                            }
                            catch { }

                            MessageBox.Show("Sửa thông tin dịch vụ thành công!", "Thông báo!");
                            this.Close();
                        }
                        break;
                    case ServiceManagerType.EditWashService:
                        int WashID = this.parentRefForm.ItemLaundry._itemID;
                        int Ef = await Task.Run(()=> {
                            try
                            {
                                return DataAccess.Manager.SetServiceInfo(WashID, ItemName, Price);
                            }
                            catch
                            {
                                return -2;
                            }
                        });
                        if (Ef == -2) throw new Exception("Lỗi khi kết nối đến server");
                        else if (Ef > 0)
                        {
                            this.parentRefForm.ItemLaundry._name = tbName.Text;
                            this.parentRefForm.LbLaundryName.Text = tbName.Text;

                            this.parentRefForm.ItemLaundry._price = Convert.ToInt32(tbPrice.Text);
                            this.parentRefForm.LbLaundryPrice.Text = tbPrice.Text;

                            MessageBox.Show("Sửa thông tin dịch vụ thành công!", "Thông báo!");
                            this.Close();
                        }
                        break;
                    case ServiceManagerType.EditIronService:
                        int IronID = this.parentRefForm.ItemIron._itemID;
                        int EF = await Task.Run(()=> {
                            try
                            {
                                return DataAccess.Manager.SetServiceInfo(IronID, ItemName, Price);
                            }
                            catch
                            {
                                return -2;
                            }
                        });
                        if (EF == -2) throw new Exception("Lỗi khi kết nối đến server");
                        if (EF > 0)
                        {
                            this.parentRefForm.ItemIron._name = tbName.Text;
                            this.parentRefForm.LbIronName.Text = tbName.Text;

                            this.parentRefForm.ItemIron._price = Convert.ToInt32(tbPrice.Text);
                            this.parentRefForm.LbIronPrice.Text = tbPrice.Text;

                            MessageBox.Show("Sửa thông tin dịch vụ thành công!", "Thông báo!");
                            this.Close();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
            }
        }

        private bool checkValidValue()
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ.", "Thông Báo");
                tbName.Focus();
                return false;
            }

            if (tbPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá dịch vụ.", "Thông Báo");
                tbPrice.Focus();
                return false;
            }

            if (!Regex.IsMatch(tbPrice.Text, @"^[0-9]{0,}$"))
            {
                MessageBox.Show("Giá dịch vụ là số nguyên", "Thông Báo");
                tbPrice.Focus();
                return false;
            }

            return true;
        }

        private void btAddServiceImage_Click(object sender, EventArgs e)
        {
            try
            {
                open.Title = "Select a File";
                open.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|"
                            + "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    pbServiceImage.Image = new Bitmap(open.FileName);
                }
            }
            catch
            {

            }
        }
    }
}
