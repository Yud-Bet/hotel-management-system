using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HotelManagement.UI
{
    public partial class Form_AddEditRoom : MetroFramework.Forms.MetroForm
    {
        private int RoomID;

        public XanderUI.XUIButton _btAdd
        {
            get { return btAddRoom; }
        }

        public XanderUI.XUIButton _btSave
        {
            get { return btSave; }
        }

        public Form_AddEditRoom(int RoomID)
        {
            InitializeComponent();
            this.RoomID = RoomID;
            loadData();
        }

        void loadData()
        {
            DTO.RoomDetail room = new DTO.RoomDetail(RoomID);
            tbRoomID.Text = RoomID.ToString();
            tbRoomSize.Text = room.Size;
            tbRoomPrice.Text = room.Price;
            SetValueForControl.SetRoomType(room.Type, rbtNor, rbtVip, rbtSingle, rbtDouble);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!checkEmptyValue()) return;
            if (!checkValidityOfValue()) return;

            DataAccess.RoomDA.EditRoomInfo(Convert.ToInt32(tbRoomID.Text), GetValueOfControl.GetRoomType(rbtNor, rbtVip, rbtSingle, rbtDouble),
                Convert.ToInt32(tbRoomSize.Text), Convert.ToInt32(tbRoomPrice.Text));
            DialogResult = DialogResult.OK;

            this.Close();
        }

        bool checkEmptyValue()
        {
            if (tbRoomID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbRoomID.Focus();
                return false;
            }

            if(!rbtVip.Checked && !rbtNor.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại phòng Vip hoặc Thường.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!rbtSingle.Checked && !rbtDouble.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại phòng Đơn hoặc Đôi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (tbRoomSize.Text == "")
            {
                MessageBox.Show("Vui lòng nhập diện tích phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbRoomSize.Focus();
                return false;
            }

            if (tbRoomPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbRoomPrice.Focus();
                return false;
            }

            return true;
        }

        bool checkValidityOfValue()
        {
            if(!Regex.IsMatch(tbRoomID.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Mã phòng là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbRoomID.Focus();
                return false;
            }

            if (!Regex.IsMatch(tbRoomSize.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Diện tích phòng là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbRoomSize.Focus();
                return false;
            }

            if (!Regex.IsMatch(tbRoomPrice.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Giá phòng là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbRoomPrice.Focus();
                return false;
            }

            return true;
        }
    }
}
