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
    public partial class Item_LaundryService : UserControl
    {
        public Item_LaundryService(Form_LaundryService parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        #region properties
        Form_LaundryService parent;

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
                lbName.Text = value;
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
                tbCount.Text = value.ToString();
            }
        }


        #endregion

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            zeroitUltraTextBox1.Focus();
        }

        private void tbCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbCount.Text != "")
                {
                    this._count = Convert.ToInt32(tbCount.Text);
                    this.parent.calcTotalMoney();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chỉ nhập số");
                tbCount.Text = this.count.ToString();
            }
        }

        private void tbCount_MouseLeave(object sender, EventArgs e)
        {
            if (tbCount.Text == "")
            {
                tbCount.Text = this.count.ToString();
            }
        }
    }
}
