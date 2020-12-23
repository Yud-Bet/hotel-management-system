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
                    this.tbName.Text = "Dịch vụ mới";
                    this.tbPrice.Text = "20000";
                    break;
                case ServiceManagerType.EditEatService:
                    btAddService.Hide();
                    this.parentRefItem = parentRefItem;
                    this.tbName.Text = this.parentRefItem._name;
                    this.tbPrice.Text = this.parentRefItem._price.ToString();
                    break;
                case ServiceManagerType.EditWashService:
                    btAddService.Hide();
                    this.tbName.Text = this.parentRefForm.ItemLaundry._name;
                    this.tbPrice.Text = this.parentRefForm.ItemIron._price.ToString();
                    break;
                default:
                    btAddService.Hide();
                    this.tbName.Text = this.parentRefForm.ItemLaundry._name;
                    this.tbPrice.Text = this.parentRefForm.ItemIron._price.ToString();

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
            int ef = DataAccess.Manager.AddNewService(ServiceType.Eating, tbName.Text, Convert.ToInt32(tbPrice.Text));
            if (ef > 0)
            {
                DataTable data = DataAccess.Manager.GetServiceIdOfNewService();
                Item_ServiceManager item = new Item_ServiceManager(Convert.ToInt32(data.Rows[0].ItemArray[0]), tbName.Text, Convert.ToInt32(tbPrice.Text), this.parentRefForm);
                this.parentRefForm._pnToAddItem.Controls.Add(item);
                MessageBox.Show("Thêm dịch vụ mới thành công!", "Thông báo!");
                //this.parentRefItem._name = tbName.Text;
                //this.parentRefItem._price = Convert.ToInt32(tbPrice.Text);
                this.Close();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            int ef  = DataAccess.Manager.SetServiceInfo(this.parentRefItem._itemID, tbName.Text, Convert.ToInt32(tbPrice.Text));
            if (ef > 0)
            {
                MessageBox.Show("Sửa thông tin dịch vụ thành công!", "Thông báo!");
                this.parentRefItem._name = tbName.Text;
                this.parentRefItem._price = Convert.ToInt32(tbPrice.Text);
                this.Close();
            }

        }
    }
}
