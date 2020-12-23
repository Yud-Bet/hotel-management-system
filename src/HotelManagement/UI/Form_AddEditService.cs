using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    formType = ServiceManagerType.AddEatService;
                    btAddService.Show();
                    this.tbName.PlaceHolderText = "Dịch vụ mới";
                    this.tbPrice.Text = "0";
                    break;
                case ServiceManagerType.EditEatService:
                    formType = ServiceManagerType.EditEatService;
                    btAddService.Hide();
                    this.parentRefItem = parentRefItem;
                    this.tbName.Text = this.parentRefItem._name;
                    this.tbPrice.Text = this.parentRefItem._price.ToString();
                    break;
                case ServiceManagerType.EditWashService:
                    formType = ServiceManagerType.EditWashService;
                    btAddService.Hide();
                    this.tbName.Text = this.parentRefForm.ItemLaundry._name;
                    this.tbPrice.Text = this.parentRefForm.ItemLaundry._price.ToString();
                    break;
                case ServiceManagerType.EditIronService:
                    btAddService.Hide();
                    this.tbName.Text = this.parentRefForm.ItemIron._name;
                    this.tbPrice.Text = this.parentRefForm.ItemIron._price.ToString();
                    break;
                default:

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
            if (!checkValidValue()) return;

            int ef = DataAccess.Manager.AddNewService(ServiceType.Eating, tbName.Text, Convert.ToInt32(tbPrice.Text));
            if (ef > 0)
            {
                DataTable data = DataAccess.Manager.GetServiceIdOfNewService();
                Item_ServiceManager item = new Item_ServiceManager(Convert.ToInt32(data.Rows[0].ItemArray[0]), tbName.Text, Convert.ToInt32(tbPrice.Text), this.parentRefForm);
                this.parentRefForm._pnToAddItem.Controls.Add(item);
                MessageBox.Show("Thêm dịch vụ mới thành công!", "Thông báo!");
                this.Close();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!checkValidValue()) return;
            switch (formType)
            {
                case ServiceManagerType.EditEatService:
                    int ef  = DataAccess.Manager.SetServiceInfo(this.parentRefItem._itemID, tbName.Text, Convert.ToInt32(tbPrice.Text));
                    if (ef > 0)
                    {
                        this.parentRefItem._name = tbName.Text;
                        this.parentRefItem._price = Convert.ToInt32(tbPrice.Text);

                        MessageBox.Show("Sửa thông tin dịch vụ thành công!", "Thông báo!");
                        this.Close();
                    }
                    break;
                case ServiceManagerType.EditWashService:
                    int Ef = DataAccess.Manager.SetServiceInfo(this.parentRefForm.ItemLaundry._itemID, tbName.Text, Convert.ToInt32(tbPrice.Text));
                    if (Ef > 0)
                    {
                        this.parentRefForm.ItemLaundry._name = tbName.Text;
                        this.parentRefForm.LbLaundryName.Text = tbName.Text;

                        this.parentRefForm.ItemLaundry._price = Convert.ToInt32(tbPrice.Text);
                        this.parentRefForm.LbLaundryPrice.Text = tbPrice.Text;

                        MessageBox.Show("Sửa thông tin dịch vụ thành công!", "Thông báo!");
                        this.Close();
                    }
                    break;
                case ServiceManagerType.EditIronService:
                    int EF = DataAccess.Manager.SetServiceInfo(this.parentRefForm.ItemIron._itemID, tbName.Text, Convert.ToInt32(tbPrice.Text));
                    if (EF > 0)
                    {
                        this.parentRefForm.ItemIron._name = tbName.Text;
                        this.parentRefForm.LbIronName.Text = tbName.Text;

                        this.parentRefForm.ItemIron._price = Convert.ToInt32(tbPrice.Text);
                        this.parentRefForm.LbIronPrice.Text = tbPrice.Text;

                        MessageBox.Show("Sửa thông tin dịch vụ thành công!", "Thông báo!");
                        this.Close();
                    }
                    break;
            }

        }

        private bool checkValidValue()
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ.", "Thông Báo");
                tbName.Focus();
                return false;
            }

            if (tbPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá dịch vụ.", "Thông Báo");
                tbPrice.Focus();
                return false;
            }

            if (!Regex.IsMatch(tbPrice.Text, @"^[0-9]{0,}$"))
            {
                MessageBox.Show("Giá dịch vụ là số nguyên", "Thông Báo");
                tbPrice.Focus();
                return false;
            }

            return true;
        }
    }
}
