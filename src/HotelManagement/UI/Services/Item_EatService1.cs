using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Item_EatService1 : UserControl
    {
        public Item_EatService1(Form_EatService parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        #region Properties
        Form_EatService parent;

        private int itemID;

        public int _itemID
        {
            get { return itemID; }
            set { itemID = value; 
                //
                //get image
                //
                }
        }

        private int price;

        public int _price
        {
            get { return price; }
            set { 
                price = value;
                lbPrice.Text = value.ToString();
            }
        }

        private string name;

        public string _name
        {
            get { return name; }
            set { 
                name = value;
                lbName.MainText = value;
            }
        }


        #endregion

        private Item_EatService2 checkExistsItem2(Item_EatService1 item_EatService1)
        {
            foreach(Item_EatService2 i in this.parent._SelectedItems)
            {
                if (i._itemID == item_EatService1._itemID)
                {
                    return i;
                }
            }
            return null;
        }

        private async void pbImage_Click(object sender, EventArgs e)
        {
            Item_EatService2 temp = checkExistsItem2(this);
            if (temp != null)
            {
                temp._count++;
            }
            else
            {
                temp = new Item_EatService2(this.parent);
                temp._name = this.name;
                temp._price = this.price;
                temp._itemID = this.itemID;

                this.parent._SelectedItems.Add(temp);
                this.parent._pnSelectedServices.Controls.Add(temp);
            }
            await this.parent.calcTotalMoney();
        }

        public void setServiceImage()
        {
            string serviceImageDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\\hotel_management\\serviceimage\\";
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
