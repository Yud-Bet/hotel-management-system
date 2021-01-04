using System;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Item_EatService2 : UserControl
    {
        public Item_EatService2(Form_RoomInfo isForm, string ID, string name, string count, string price)
        {
            InitializeComponent();
            this.isOK = false;
            this.isForm = isForm;
            this._itemID = Convert.ToInt32(ID);
            this._name = name;
            this._price = Convert.ToInt32(price); 
            this._count = Convert.ToInt32(count);
            //this.Name = name;
            //this.count = Convert.ToInt32(count);
            //this.price = Convert.ToInt32(price);
            //this.lbName.MainText = name.ToString();
            //this.lbPrice.Text = price.ToString();
            //this.tbCount.Text = count.ToString();

        }
        public Item_EatService2(Form_EatService parent)
        {
            InitializeComponent();
            this.isOK = true;
            this.parent = parent;
            tbCount.LostFocus += TbCount_LostFocus;
            if (isOK)
            {
                this.parent.Disposed += delegate { removeItem(); };
            }
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
        bool isOK = true;
        Form_EatService parent;
        Form_RoomInfo isForm;

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
            if (!isOK)
            //    this.parent._totalMoney += this.price;
            //else
                this.isForm.TotalMoneyService += this.price;
        }

        private void removeItem()
        {
            if (isOK)
            {
                for (int i = 0; i < this.parent._SelectedItems.Count; i++)
                {
                    if (isOK)
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
            }
            else
            {
                this.isForm.TotalMoneyService -= this.count * this.price; 
                this.isForm._pnAddSevice.Controls.Remove(this);
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
            if (!isOK)
            //    this.parent._totalMoney -= this.price;
            //else
                this.isForm.TotalMoneyService -= this.price;
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

        private async void lbRemove_Click(object sender, EventArgs e)
        {
            removeItem();
            if (isOK)
                await this.parent.calcTotalMoney();
        }

        private async void tbCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (tbCount.Text == "")
                {
                    this._count = 1;
                    if (isOK)
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
            if (this.isOK && tbCount.Text != "")
            {
                this._count = Convert.ToInt32(tbCount.Text);
                if (isOK)
                    await this.parent.calcTotalMoney();
            }
        }
    }
}
