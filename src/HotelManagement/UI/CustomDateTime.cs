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
    public partial class CustomDateTime : UserControl
    {
        public CustomDateTime()
        {
            InitializeComponent();
            setTypeDate();
            
        }

        #region properties
        private DateTime minDate;

        private int type;

        public int _type
        {
            get { return type; }
            set { 
                type = value;
                switch (value)
                {
                    case 1:
                        setTypeDate();
                        break;
                    case 2:
                        setTypeMonth();
                        break;
                    case 3:
                        setTypeQuarter();
                        break;
                    case 4:
                        setTypeYear();
                        break;
                    default:
                        setTypeDate();
                        break;
                }
            }
        }

        #endregion

        void setTypeDate()
        {
            dateTime.Show();
            pnMonth.Hide();
            pnQuarter.Hide();
            pnYear.Hide();
        }

        void setTypeMonth()
        {
            dateTime.Hide();
            pnMonth.Show();
            pnQuarter.Hide();
            pnYear.Show();
        }

        void setTypeQuarter()
        {
            dateTime.Hide();
            pnMonth.Hide();
            pnQuarter.Show();
            pnYear.Show();
        }

        void setTypeYear()
        {
            dateTime.Hide();
            pnMonth.Hide();
            pnQuarter.Hide();
            pnYear.Show();
        }
    }
}
