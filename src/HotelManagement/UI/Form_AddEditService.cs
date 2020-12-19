using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Form_AddEditService : MetroFramework.Forms.MetroForm
    {
        public Form_AddEditService(Item_ServiceManager parentRefItem, Form_ServiceManager parentRefForm, ServiceManagerType type)
        {
            InitializeComponent();
            this.parentRefForm = parentRefForm;
            this.formType = type;
            switch (type)
            {
                case ServiceManagerType.AddEatService:
                    btAddService.Show();
                    break;
                case ServiceManagerType.EditEatService:
                    btAddService.Hide();
                    this.parentRefItem = parentRefItem;
                    break;
                default:
                    tbName.IsEnabled = false;
                    btAddService.Hide();
                    break;
            }
        }

        #region properties
        ServiceManagerType formType;
        Item_ServiceManager parentRefItem;
        Form_ServiceManager parentRefForm;
        #endregion

        private void btAddService_Click(object sender, EventArgs e)
        {
            
        }
    }
}
