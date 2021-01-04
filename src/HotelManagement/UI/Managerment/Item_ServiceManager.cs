using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace HotelManagement.UI
{
    public partial class Item_ServiceManager : UserControl
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        string serviceImageDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\\hotel_management\\serviceimage\\";

        public Item_ServiceManager(int id, string name, int price, Form_ServiceManager parentRef)
        {
            InitializeComponent();
            this._itemID = id;
            this._name = name;
            this._price = price;
            this.parentRef = parentRef;
            setServiceImage();
        }

        #region Properties
        Form_ServiceManager parentRef;

        private int itemID;

        public int _itemID
        {
            get { return itemID; }
            set
            {
                itemID = value;
                //
                //get image
                //
            }
        }

        private int price;

        public int _price
        {
            get { return price; }
            set
            {
                price = value;
                lbPrice.Text = value.ToString();
            }
        }

        private string name;

        public string _name
        {
            get { return name; }
            set
            {
                name = value;
                lbName.MainText = value;
            }
        }


        #endregion

        private async void pbRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không?", "Thông báo!", MessageBoxButtons.YesNo);
            try
            {
                OverlayForm overlay = new OverlayForm(parentRef.ParentRef, new LoadingForm(cts.Token));
                overlay.Show();

                if (result == DialogResult.Yes)
                {
                    int ef = await Task.Run(() => {
                        try
                        {
                            return DataAccess.Service.RemoveService(this._itemID);
                        }
                        catch
                        {
                            return -2;
                        }
                    });
                    if (ef == -2) throw new Exception("Lỗi khi kết nối đến server");
                    else if (ef > 0)
                    {
                        this.parentRef._pnToAddItem.Controls.Remove(this);
                        this.parentRef.Services.Remove(this);

                        try
                        {
                            string[] staffImageFiles = Directory.GetFiles(serviceImageDirectory, name + "*");

                            foreach (string i in staffImageFiles)
                            {
                                File.Delete(i);
                            }
                        }
                        catch { }
                    }
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

        private void pbImage_Click(object sender, EventArgs e)
        {
            (new Form_AddEditService(this, this.parentRef, ServiceManagerType.EditEatService)).ShowDialog();
        }

        public void setServiceImage()
        {
            try
            {
                string[] staffImageFiles = Directory.GetFiles(serviceImageDirectory, name + "*");
                Image image;
                using (Stream stream = File.OpenRead(staffImageFiles[0]))
                {
                    image = System.Drawing.Image.FromStream(stream);
                }
                pbImage.Image = image;
            }
            catch { }
        }
    }
}
