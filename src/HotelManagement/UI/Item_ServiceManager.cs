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
    public partial class Item_ServiceManager : UserControl
    {
        public Item_ServiceManager(Form_ServiceManager parentRef)
        {
            InitializeComponent();
            this.parentRef = parentRef;
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

        private void pbRemove_Click(object sender, EventArgs e)
        {
            this.parentRef._pnToAddItem.Controls.Remove(this);
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            (new Form_AddEditService(this, this.parentRef, ServiceManagerType.AddEatService)).ShowDialog();
        }
    }
}
