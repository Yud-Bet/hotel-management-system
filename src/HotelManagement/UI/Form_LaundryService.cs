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
    public partial class Form_LaundryService : UserControl
    {
        public Form_LaundryService()
        {
            InitializeComponent();
        }

        #region properties
        private int laundryPrice = 50, ironPrice = 50, laundryID = 1, ironID = 2;
        private List<Item_LaundryService> item_LaundryServices = new List<Item_LaundryService>();

        private int discount = 0;

        private int totalMoney;

        public int _totalMoney
        {
            get { return totalMoney; }
            set
            {
                totalMoney = value;
                lbTotalMoney.Text = value.ToString();
                lbTotalPayable.Text = (totalMoney - ((float)totalMoney * discount / 100)).ToString();
            }
        }

        #endregion

        public void calcTotalMoney()
        {
            int sum = 0;
            foreach (Item_LaundryService i in item_LaundryServices)
            {
                sum += (i._count * i._price);
            }
            this._totalMoney = sum;
        }

        Item_LaundryService createItemLaundry(int ID, string name, int price)
        {
            Item_LaundryService temp = new Item_LaundryService(this);
            temp._itemID = ID;
            temp._name = name;
            temp._price = price;

            return temp;
        }

        int checkExistsItem(int ID)
        {
            if (item_LaundryServices.Count > 0)
            {
                for(int i=0; i<item_LaundryServices.Count; i++)
                {
                    if (item_LaundryServices[i]._itemID == ID)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        private void btItemIron_Click(object sender, EventArgs e)
        {
            int check = checkExistsItem(ironID);
            if (check == -1)
            {
                item_LaundryServices.Add(createItemLaundry(ironID, "Ủi", ironPrice));
                pnItem.Controls.Add(item_LaundryServices[item_LaundryServices.Count - 1]);
            }
            else
            {
                pnItem.Controls.Remove(item_LaundryServices[check]);
                item_LaundryServices.RemoveAt(check);
            }
            calcTotalMoney();
        }

        private void btItemLaundry_Click(object sender, EventArgs e)
        {
            int check = checkExistsItem(laundryID);
            if (check == -1)
            {
                item_LaundryServices.Add(createItemLaundry(laundryID, "Giặt", laundryPrice));
                pnItem.Controls.Add(item_LaundryServices[item_LaundryServices.Count - 1]);
            }
            else
            {
                pnItem.Controls.Remove(item_LaundryServices[check]);
                item_LaundryServices.RemoveAt(check);
            }
            calcTotalMoney();
        }

    }
}
