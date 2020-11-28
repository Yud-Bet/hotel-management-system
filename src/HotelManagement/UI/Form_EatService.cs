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
    public partial class Form_EatService : UserControl
    {
        public Form_EatService()
        {
            InitializeComponent();
            Item_EatService1 temp = new Item_EatService1(this);
            temp._itemID = 10;
            temp._name = "cola";
            temp._price = 10;
            this.pnItem1.Controls.Add(temp);
            Item_EatService1 temp1 = new Item_EatService1(this);
            temp1._itemID = 104;
            temp1._name = "pessi";
            temp1._price = 40;
            this.pnItem1.Controls.Add(temp1);
            Item_EatService1 temp2 = new Item_EatService1(this);
            temp2._itemID = 50;
            temp2._name = "Bánh mì";
            temp2._price = 50;
            this.pnItem1.Controls.Add(temp2);
        }

        public void calcTotalMoney()
        {
            int sum = 0;
            foreach (Item_EatService2 i in this._item_EatService2s)
            {
                sum += (i._count * i._price);
            }
            this._totalMoney = sum;
        }

        #region properties
        public FlowLayoutPanel _panelItem1
        {
            get { return this.pnItem1; }
        }

        public FlowLayoutPanel _panelItem2
        {
            get { return this.pnItem2; }
        }

        private List<Item_EatService2> item_EatService2s= new List<Item_EatService2>();

        public List<Item_EatService2> _item_EatService2s
        {
            get { return item_EatService2s; }
            set { item_EatService2s = value; }
        }

        private int totalMoney;

        public int _totalMoney
        {
            get { return totalMoney; }
            set { 
                totalMoney = value;
                lbTotalMoney.Text = value.ToString();
            }
        }

        #endregion

    }
}
