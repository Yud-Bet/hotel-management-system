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
            DTO.ServicesInfo services = new DTO.ServicesInfo(ServiceType.Eating);
            for (int i = 0; i < services.Items.Count; i++)
            {
                Item_EatService1 item = new Item_EatService1(this);
                item._itemID = services.Items[i].ServiceID;
                item._name = services.Items[i].Name;
                item._price = services.Items[i].Price;
                pnItem1.Controls.Add(item);
            }
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
