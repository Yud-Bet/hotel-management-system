using System;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Item_EatService2 : UserControl
    {
        public Item_EatService2(Form_EatService parent)
        {
            InitializeComponent();
            this.parent = parent;
            tbCount.LostFocus += TbCount_LostFocus;

            this.parent.Disposed += delegate { removeItem(); };
        }

        private void TbCount_LostFocus(object sender, EventArgs e)
        {
            if (tbCount.Text == "")
            {
                this._count = 1;
                return;
            }

            if (tbCount.Text == "0")
            {
                removeItem();
                return;
            }
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
                tbCount.Text = value.ToString();
            }
        }


        #endregion


        private void btPlus_Click(object sender, EventArgs e)
        {
            count++;
            tbCount.Text = count.ToString();
            this.parent._totalMoney += this.price;
        }

        private void removeItem()
        {
            for (int i = 0; i < this.parent._SelectedItems.Count; i++)
            {
                if (this.parent._SelectedItems[i] == this)
                {
                    this.parent._SelectedItems.RemoveAt(i);
                    this.parent._pnSelectedServices.Controls.Remove(this);
                    zeroitUltraTextBox1.MouseMove -= Item_EatService2_MouseMove;

                    this.Dispose();
                    GC.Collect();
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
            tbCount.Text = count.ToString();
            this.parent._totalMoney -= this.price;
        }

        private void Item_EatService2_MouseMove(object sender, MouseEventArgs e)
        {
            if (tbCount.Focused == false)
            {
                zeroitUltraTextBox1.IsEnabled = true;
                zeroitUltraTextBox1.Focus();
            }

            GC.Collect();
        }

        private async void label1_Click(object sender, EventArgs e)
        {
            removeItem();
            await this.parent.calcTotalMoney();
        }

        private async void tbCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (tbCount.Text == "")
                {
                    this._count = 1;
                    await this.parent.calcTotalMoney();
                }
                zeroitUltraTextBox1.Focus();
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void tbCount_TextChanged(object sender, EventArgs e)
        {
            if (tbCount.Text != "")
            {
                this._count = Convert.ToInt32(tbCount.Text);
                await this.parent.calcTotalMoney();
            }
        }
    }
}
