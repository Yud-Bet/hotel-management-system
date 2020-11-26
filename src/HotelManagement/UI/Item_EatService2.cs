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
    public partial class Item_EatService2 : UserControl
    {
        public Item_EatService2(Form_EatService parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        #region properties
        Form_EatService parent;

        private int itemID;

        public int _itemID
        {
            get { return itemID; }
            set { itemID = value; }
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

        private int count = 1;

        public int _count
        {
            get { return count; }
            set
            {
                count = value;
                lbCount.Text = value.ToString();
            }
        }


        #endregion

        private void btPlus_Click(object sender, EventArgs e)
        {
            count++;
            lbCount.Text = count.ToString();
        }

        private void removeItem()
        {
            for (int i = 0; i < this.parent._item_EatService2s.Count; i++)
            {
                if (this.parent._item_EatService2s[i] == this)
                {
                    this.parent._item_EatService2s.RemoveAt(i);
                    this.parent._panelItem2.Controls.Remove(this);
                    return;
                }
            }
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                this.removeItem();
            }
            count--;
            lbCount.Text = count.ToString();
        }

        private void Item_EatService2_MouseMove(object sender, MouseEventArgs e)
        {
            zeroitUltraTextBox1.IsEnabled = true;
            zeroitUltraTextBox1.Focus();
        }
    }
}
