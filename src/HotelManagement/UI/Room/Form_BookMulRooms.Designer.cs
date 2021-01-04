using System;

namespace HotelManagement.UI
{
    partial class Form_BookMulRooms
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BookMulRooms));
            this.pbArrowBack = new System.Windows.Forms.PictureBox();
            this.pnCustomerInfo = new System.Windows.Forms.Panel();
            this.tbNote = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbCustomerAddress = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbPassport = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbIDNo = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbCustomerPhoneNum = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbCustomerName = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.cbPassport = new Zeroit.Framework.MaterialDesign.Controls.ZeroitMaterialCheckBox();
            this.cbIDNo = new Zeroit.Framework.MaterialDesign.Controls.ZeroitMaterialCheckBox();
            this.pnSex = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.dtpCustomerBirthday = new MetroFramework.Controls.MetroDateTime();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnToBookRoom = new System.Windows.Forms.Panel();
            this.PanelList = new Zeroit.Framework.MiscControls.ZeroitProPanelList();
            this.pnRoomList = new Zeroit.Framework.MiscControls.XPanderPanel();
            this.pnToSelectRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.lbListEmptyRoomIsEmpty = new System.Windows.Forms.Label();
            this.xPanderPanel2 = new Zeroit.Framework.MiscControls.XPanderPanel();
            this.pnSeletedRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.lbListSelectedRoomIsEmpty = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnBookingInfo = new System.Windows.Forms.Panel();
            this.btBookRoom = new XanderUI.XUIButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.StatusLabel = new Zeroit.Framework.MiscControls.ZeroitLabel();
            this.lbArrivalDate = new System.Windows.Forms.Label();
            this.dropDownList1 = new HotelManagement.UI.DropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrowBack)).BeginInit();
            this.pnCustomerInfo.SuspendLayout();
            this.pnSex.SuspendLayout();
            this.pnToBookRoom.SuspendLayout();
            this.PanelList.SuspendLayout();
            this.pnRoomList.SuspendLayout();
            this.pnToSelectRoom.SuspendLayout();
            this.xPanderPanel2.SuspendLayout();
            this.pnSeletedRoom.SuspendLayout();
            this.pnBookingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbArrowBack
            // 
            this.pbArrowBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbArrowBack.Image = ((System.Drawing.Image)(resources.GetObject("pbArrowBack.Image")));
            this.pbArrowBack.Location = new System.Drawing.Point(916, -1);
            this.pbArrowBack.Name = "pbArrowBack";
            this.pbArrowBack.Size = new System.Drawing.Size(33, 37);
            this.pbArrowBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArrowBack.TabIndex = 26;
            this.pbArrowBack.TabStop = false;
            this.pbArrowBack.Click += new System.EventHandler(this.pbArrowBack_Click);
            // 
            // pnCustomerInfo
            // 
            this.pnCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnCustomerInfo.Controls.Add(this.dropDownList1);
            this.pnCustomerInfo.Controls.Add(this.tbNote);
            this.pnCustomerInfo.Controls.Add(this.tbCustomerAddress);
            this.pnCustomerInfo.Controls.Add(this.tbPassport);
            this.pnCustomerInfo.Controls.Add(this.tbIDNo);
            this.pnCustomerInfo.Controls.Add(this.tbCustomerPhoneNum);
            this.pnCustomerInfo.Controls.Add(this.tbCustomerName);
            this.pnCustomerInfo.Controls.Add(this.cbPassport);
            this.pnCustomerInfo.Controls.Add(this.cbIDNo);
            this.pnCustomerInfo.Controls.Add(this.pnSex);
            this.pnCustomerInfo.Controls.Add(this.dtpCustomerBirthday);
            this.pnCustomerInfo.Controls.Add(this.label8);
            this.pnCustomerInfo.Controls.Add(this.label10);
            this.pnCustomerInfo.Controls.Add(this.label9);
            this.pnCustomerInfo.Controls.Add(this.label7);
            this.pnCustomerInfo.Controls.Add(this.label6);
            this.pnCustomerInfo.Controls.Add(this.label5);
            this.pnCustomerInfo.Controls.Add(this.label4);
            this.pnCustomerInfo.Controls.Add(this.label3);
            this.pnCustomerInfo.Controls.Add(this.label1);
            this.pnCustomerInfo.Controls.Add(this.panel3);
            this.pnCustomerInfo.Location = new System.Drawing.Point(11, 69);
            this.pnCustomerInfo.Name = "pnCustomerInfo";
            this.pnCustomerInfo.Size = new System.Drawing.Size(473, 467);
            this.pnCustomerInfo.TabIndex = 27;
            this.pnCustomerInfo.Click += new System.EventHandler(this.pnCustomerInfo_Click);
            // 
            // tbNote
            // 
            this.tbNote.DisabledStringColor = System.Drawing.Color.Black;
            this.tbNote.DisabledUnFocusedColor = System.Drawing.Color.Silver;
            this.tbNote.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNote.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.tbNote.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbNote.ForeColor = System.Drawing.Color.Black;
            this.tbNote.IsEnabled = true;
            this.tbNote.Location = new System.Drawing.Point(8, 364);
            this.tbNote.MaxLength = 32767;
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.PasswordChar = '\0';
            this.tbNote.Placeholder = true;
            this.tbNote.PlaceHolderText = "";
            this.tbNote.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbNote.ReadOnly = false;
            this.tbNote.Size = new System.Drawing.Size(440, 81);
            this.tbNote.TabIndex = 7;
            this.tbNote.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNote.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbNote.UseSystemPasswordChar = false;
            this.tbNote.WordWrap = true;
            // 
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.DisabledStringColor = System.Drawing.Color.Black;
            this.tbCustomerAddress.DisabledUnFocusedColor = System.Drawing.Color.Silver;
            this.tbCustomerAddress.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCustomerAddress.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.tbCustomerAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbCustomerAddress.ForeColor = System.Drawing.Color.Black;
            this.tbCustomerAddress.IsEnabled = true;
            this.tbCustomerAddress.Location = new System.Drawing.Point(8, 304);
            this.tbCustomerAddress.MaxLength = 32767;
            this.tbCustomerAddress.Multiline = false;
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.PasswordChar = '\0';
            this.tbCustomerAddress.Placeholder = true;
            this.tbCustomerAddress.PlaceHolderText = "";
            this.tbCustomerAddress.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbCustomerAddress.ReadOnly = false;
            this.tbCustomerAddress.Size = new System.Drawing.Size(440, 24);
            this.tbCustomerAddress.TabIndex = 6;
            this.tbCustomerAddress.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCustomerAddress.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbCustomerAddress.UseSystemPasswordChar = false;
            this.tbCustomerAddress.WordWrap = true;
            // 
            // tbPassport
            // 
            this.tbPassport.DisabledStringColor = System.Drawing.Color.Black;
            this.tbPassport.DisabledUnFocusedColor = System.Drawing.Color.Silver;
            this.tbPassport.Enabled = false;
            this.tbPassport.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassport.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.tbPassport.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbPassport.ForeColor = System.Drawing.Color.Black;
            this.tbPassport.IsEnabled = false;
            this.tbPassport.Location = new System.Drawing.Point(238, 233);
            this.tbPassport.MaxLength = 32767;
            this.tbPassport.Multiline = false;
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.PasswordChar = '\0';
            this.tbPassport.Placeholder = true;
            this.tbPassport.PlaceHolderText = "";
            this.tbPassport.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbPassport.ReadOnly = true;
            this.tbPassport.Size = new System.Drawing.Size(205, 24);
            this.tbPassport.TabIndex = 5;
            this.tbPassport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassport.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbPassport.UseSystemPasswordChar = false;
            this.tbPassport.WordWrap = true;
            // 
            // tbIDNo
            // 
            this.tbIDNo.DisabledStringColor = System.Drawing.Color.Black;
            this.tbIDNo.DisabledUnFocusedColor = System.Drawing.Color.Silver;
            this.tbIDNo.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbIDNo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.tbIDNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbIDNo.ForeColor = System.Drawing.Color.Black;
            this.tbIDNo.IsEnabled = true;
            this.tbIDNo.Location = new System.Drawing.Point(8, 233);
            this.tbIDNo.MaxLength = 32767;
            this.tbIDNo.Multiline = false;
            this.tbIDNo.Name = "tbIDNo";
            this.tbIDNo.PasswordChar = '\0';
            this.tbIDNo.Placeholder = true;
            this.tbIDNo.PlaceHolderText = "";
            this.tbIDNo.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbIDNo.ReadOnly = false;
            this.tbIDNo.Size = new System.Drawing.Size(205, 24);
            this.tbIDNo.TabIndex = 4;
            this.tbIDNo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbIDNo.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbIDNo.UseSystemPasswordChar = false;
            this.tbIDNo.WordWrap = true;
            // 
            // tbCustomerPhoneNum
            // 
            this.tbCustomerPhoneNum.DisabledStringColor = System.Drawing.Color.Black;
            this.tbCustomerPhoneNum.DisabledUnFocusedColor = System.Drawing.Color.Silver;
            this.tbCustomerPhoneNum.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCustomerPhoneNum.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.tbCustomerPhoneNum.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbCustomerPhoneNum.ForeColor = System.Drawing.Color.Black;
            this.tbCustomerPhoneNum.IsEnabled = true;
            this.tbCustomerPhoneNum.Location = new System.Drawing.Point(8, 156);
            this.tbCustomerPhoneNum.MaxLength = 32767;
            this.tbCustomerPhoneNum.Multiline = false;
            this.tbCustomerPhoneNum.Name = "tbCustomerPhoneNum";
            this.tbCustomerPhoneNum.PasswordChar = '\0';
            this.tbCustomerPhoneNum.Placeholder = true;
            this.tbCustomerPhoneNum.PlaceHolderText = "";
            this.tbCustomerPhoneNum.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbCustomerPhoneNum.ReadOnly = false;
            this.tbCustomerPhoneNum.Size = new System.Drawing.Size(267, 24);
            this.tbCustomerPhoneNum.TabIndex = 3;
            this.tbCustomerPhoneNum.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCustomerPhoneNum.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbCustomerPhoneNum.UseSystemPasswordChar = false;
            this.tbCustomerPhoneNum.WordWrap = true;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.DisabledStringColor = System.Drawing.Color.Black;
            this.tbCustomerName.DisabledUnFocusedColor = System.Drawing.Color.Silver;
            this.tbCustomerName.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCustomerName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.tbCustomerName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbCustomerName.ForeColor = System.Drawing.Color.Black;
            this.tbCustomerName.IsEnabled = true;
            this.tbCustomerName.Location = new System.Drawing.Point(8, 77);
            this.tbCustomerName.MaxLength = 32767;
            this.tbCustomerName.Multiline = false;
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.PasswordChar = '\0';
            this.tbCustomerName.Placeholder = true;
            this.tbCustomerName.PlaceHolderText = "";
            this.tbCustomerName.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbCustomerName.ReadOnly = false;
            this.tbCustomerName.Size = new System.Drawing.Size(267, 24);
            this.tbCustomerName.TabIndex = 1;
            this.tbCustomerName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCustomerName.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbCustomerName.UseSystemPasswordChar = false;
            this.tbCustomerName.WordWrap = true;
            this.tbCustomerName.TextChanged += new System.EventHandler(this.tbCustomerName_TextChanged);
            // 
            // cbPassport
            // 
            this.cbPassport.AllowTransparency = true;
            this.cbPassport.Checked = false;
            this.cbPassport.Depth = 0;
            this.cbPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPassport.Location = new System.Drawing.Point(337, 200);
            this.cbPassport.Margin = new System.Windows.Forms.Padding(0);
            this.cbPassport.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbPassport.MouseState = Zeroit.Framework.MaterialDesign.MouseState.HOVER;
            this.cbPassport.Name = "cbPassport";
            this.cbPassport.Ripple = true;
            this.cbPassport.Size = new System.Drawing.Size(27, 23);
            this.cbPassport.TabIndex = 0;
            this.cbPassport.TabStop = false;
            this.cbPassport.CheckedChanged += new System.EventHandler(this.cbPassport_CheckedChanged);
            // 
            // cbIDNo
            // 
            this.cbIDNo.AllowTransparency = true;
            this.cbIDNo.Checked = true;
            this.cbIDNo.Depth = 0;
            this.cbIDNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbIDNo.Location = new System.Drawing.Point(189, 200);
            this.cbIDNo.Margin = new System.Windows.Forms.Padding(0);
            this.cbIDNo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbIDNo.MouseState = Zeroit.Framework.MaterialDesign.MouseState.HOVER;
            this.cbIDNo.Name = "cbIDNo";
            this.cbIDNo.Ripple = true;
            this.cbIDNo.Size = new System.Drawing.Size(27, 23);
            this.cbIDNo.TabIndex = 0;
            this.cbIDNo.TabStop = false;
            this.cbIDNo.CheckedChanged += new System.EventHandler(this.cbIDNo_CheckedChanged);
            // 
            // pnSex
            // 
            this.pnSex.Controls.Add(this.rbtMale);
            this.pnSex.Controls.Add(this.rbtFemale);
            this.pnSex.Location = new System.Drawing.Point(289, 151);
            this.pnSex.Name = "pnSex";
            this.pnSex.Size = new System.Drawing.Size(163, 32);
            this.pnSex.TabIndex = 8;
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Depth = 0;
            this.rbtMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtMale.Location = new System.Drawing.Point(0, 0);
            this.rbtMale.Margin = new System.Windows.Forms.Padding(0);
            this.rbtMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Ripple = true;
            this.rbtMale.Size = new System.Drawing.Size(58, 30);
            this.rbtMale.TabIndex = 6;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Nam";
            this.rbtMale.UseVisualStyleBackColor = true;
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Depth = 0;
            this.rbtFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtFemale.Location = new System.Drawing.Point(58, 0);
            this.rbtFemale.Margin = new System.Windows.Forms.Padding(0);
            this.rbtFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Ripple = true;
            this.rbtFemale.Size = new System.Drawing.Size(47, 30);
            this.rbtFemale.TabIndex = 6;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "Nữ";
            this.rbtFemale.UseVisualStyleBackColor = true;
            // 
            // dtpCustomerBirthday
            // 
            this.dtpCustomerBirthday.CalendarForeColor = System.Drawing.Color.Coral;
            this.dtpCustomerBirthday.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dtpCustomerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCustomerBirthday.Location = new System.Drawing.Point(290, 75);
            this.dtpCustomerBirthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpCustomerBirthday.Name = "dtpCustomerBirthday";
            this.dtpCustomerBirthday.Size = new System.Drawing.Size(162, 29);
            this.dtpCustomerBirthday.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(234, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số hộ chiếu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ghi chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Chứng minh nhân dân";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(285, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(286, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(7, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 3);
            this.panel3.TabIndex = 3;
            // 
            // pnToBookRoom
            // 
            this.pnToBookRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnToBookRoom.Controls.Add(this.PanelList);
            this.pnToBookRoom.Controls.Add(this.label19);
            this.pnToBookRoom.Controls.Add(this.panel1);
            this.pnToBookRoom.Location = new System.Drawing.Point(490, 42);
            this.pnToBookRoom.Name = "pnToBookRoom";
            this.pnToBookRoom.Size = new System.Drawing.Size(468, 401);
            this.pnToBookRoom.TabIndex = 28;
            // 
            // PanelList
            // 
            this.PanelList.CaptionStyle = Zeroit.Framework.MiscControls.CaptionStyle.Flat;
            this.PanelList.Controls.Add(this.pnRoomList);
            this.PanelList.Controls.Add(this.xPanderPanel2);
            this.PanelList.GradientBackground = System.Drawing.Color.Empty;
            this.PanelList.Location = new System.Drawing.Point(0, 36);
            this.PanelList.Name = "PanelList";
            this.PanelList.PanelColors = null;
            this.PanelList.ShowBorder = false;
            this.PanelList.Size = new System.Drawing.Size(468, 365);
            this.PanelList.TabIndex = 4;
            this.PanelList.Text = "zeroitProPanelList1";
            // 
            // pnRoomList
            // 
            this.pnRoomList.CaptionFont = new System.Drawing.Font("Segoe UI", 13F);
            this.pnRoomList.Controls.Add(this.pnToSelectRoom);
            this.pnRoomList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnRoomList.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.pnRoomList.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pnRoomList.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.pnRoomList.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.pnRoomList.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.pnRoomList.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.pnRoomList.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.pnRoomList.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnRoomList.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.pnRoomList.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnRoomList.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.pnRoomList.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.pnRoomList.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.pnRoomList.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.pnRoomList.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.pnRoomList.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.pnRoomList.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.pnRoomList.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.pnRoomList.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnRoomList.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnRoomList.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.pnRoomList.Expand = true;
            this.pnRoomList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnRoomList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnRoomList.Image = null;
            this.pnRoomList.Name = "pnRoomList";
            this.pnRoomList.Size = new System.Drawing.Size(468, 340);
            this.pnRoomList.TabIndex = 0;
            this.pnRoomList.Text = "Danh sách phòng trống";
            this.pnRoomList.ToolTipTextCloseIcon = null;
            this.pnRoomList.ToolTipTextExpandIconPanelCollapsed = null;
            this.pnRoomList.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // pnToSelectRoom
            // 
            this.pnToSelectRoom.AutoScroll = true;
            this.pnToSelectRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnToSelectRoom.Controls.Add(this.lbListEmptyRoomIsEmpty);
            this.pnToSelectRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnToSelectRoom.Location = new System.Drawing.Point(1, 25);
            this.pnToSelectRoom.Name = "pnToSelectRoom";
            this.pnToSelectRoom.Size = new System.Drawing.Size(466, 315);
            this.pnToSelectRoom.TabIndex = 0;
            this.pnToSelectRoom.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnToSelectRoom_ControlAdded);
            this.pnToSelectRoom.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnToSelectRoom_ControlRemoved);
            // 
            // lbListEmptyRoomIsEmpty
            // 
            this.lbListEmptyRoomIsEmpty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListEmptyRoomIsEmpty.Location = new System.Drawing.Point(3, 0);
            this.lbListEmptyRoomIsEmpty.Name = "lbListEmptyRoomIsEmpty";
            this.lbListEmptyRoomIsEmpty.Size = new System.Drawing.Size(455, 44);
            this.lbListEmptyRoomIsEmpty.TabIndex = 3;
            this.lbListEmptyRoomIsEmpty.Text = "Không có phòng nào trống!";
            this.lbListEmptyRoomIsEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xPanderPanel2
            // 
            this.xPanderPanel2.CaptionFont = new System.Drawing.Font("Segoe UI", 13F);
            this.xPanderPanel2.Controls.Add(this.pnSeletedRoom);
            this.xPanderPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xPanderPanel2.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xPanderPanel2.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.xPanderPanel2.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.xPanderPanel2.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.xPanderPanel2.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.xPanderPanel2.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPanel2.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.xPanderPanel2.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPanel2.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.xPanderPanel2.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.xPanderPanel2.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPanel2.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPanel2.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.xPanderPanel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPanderPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.Image = null;
            this.xPanderPanel2.Name = "xPanderPanel2";
            this.xPanderPanel2.Size = new System.Drawing.Size(468, 25);
            this.xPanderPanel2.TabIndex = 1;
            this.xPanderPanel2.Text = "Danh sách phòng đã chọn";
            this.xPanderPanel2.ToolTipTextCloseIcon = null;
            this.xPanderPanel2.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPanel2.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // pnSeletedRoom
            // 
            this.pnSeletedRoom.AutoScroll = true;
            this.pnSeletedRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnSeletedRoom.Controls.Add(this.lbListSelectedRoomIsEmpty);
            this.pnSeletedRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSeletedRoom.Location = new System.Drawing.Point(1, 25);
            this.pnSeletedRoom.Name = "pnSeletedRoom";
            this.pnSeletedRoom.Size = new System.Drawing.Size(466, 0);
            this.pnSeletedRoom.TabIndex = 1;
            this.pnSeletedRoom.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnSeletedRoom_ControlAdded);
            this.pnSeletedRoom.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnSeletedRoom_ControlRemoved);
            // 
            // lbListSelectedRoomIsEmpty
            // 
            this.lbListSelectedRoomIsEmpty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListSelectedRoomIsEmpty.Location = new System.Drawing.Point(3, 0);
            this.lbListSelectedRoomIsEmpty.Name = "lbListSelectedRoomIsEmpty";
            this.lbListSelectedRoomIsEmpty.Size = new System.Drawing.Size(460, 44);
            this.lbListSelectedRoomIsEmpty.TabIndex = 4;
            this.lbListSelectedRoomIsEmpty.Text = "Chưa có phòng nào được chọn!";
            this.lbListSelectedRoomIsEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(207, 25);
            this.label19.TabIndex = 2;
            this.label19.Text = "Danh sách chọn phòng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(7, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 3);
            this.panel1.TabIndex = 3;
            // 
            // pnBookingInfo
            // 
            this.pnBookingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnBookingInfo.Controls.Add(this.btBookRoom);
            this.pnBookingInfo.Controls.Add(this.lbArrivalDate);
            this.pnBookingInfo.Controls.Add(this.label16);
            this.pnBookingInfo.Controls.Add(this.label23);
            this.pnBookingInfo.Controls.Add(this.panel7);
            this.pnBookingInfo.Location = new System.Drawing.Point(490, 449);
            this.pnBookingInfo.Name = "pnBookingInfo";
            this.pnBookingInfo.Size = new System.Drawing.Size(467, 108);
            this.pnBookingInfo.TabIndex = 29;
            // 
            // btBookRoom
            // 
            this.btBookRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btBookRoom.ButtonImage = global::HotelManagement.Properties.Resources.icYes1;
            this.btBookRoom.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btBookRoom.ButtonText = "Đặt Phòng";
            this.btBookRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btBookRoom.ClickTextColor = System.Drawing.Color.White;
            this.btBookRoom.CornerRadius = 5;
            this.btBookRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBookRoom.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btBookRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btBookRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btBookRoom.HoverTextColor = System.Drawing.Color.White;
            this.btBookRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btBookRoom.Location = new System.Drawing.Point(330, 62);
            this.btBookRoom.Name = "btBookRoom";
            this.btBookRoom.Size = new System.Drawing.Size(129, 37);
            this.btBookRoom.TabIndex = 17;
            this.btBookRoom.TextColor = System.Drawing.Color.White;
            this.btBookRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btBookRoom.Click += new System.EventHandler(this.btBookRoom_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(10, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "Ngày nhận:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(3, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(185, 25);
            this.label23.TabIndex = 2;
            this.label23.Text = "Thông tin đặt phòng";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.panel7.Location = new System.Drawing.Point(7, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 3);
            this.panel7.TabIndex = 3;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.StatusLabel.Location = new System.Drawing.Point(11, 547);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 30;
            // 
            // lbArrivalDate
            // 
            this.lbArrivalDate.AutoSize = true;
            this.lbArrivalDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbArrivalDate.ForeColor = System.Drawing.Color.Black;
            this.lbArrivalDate.Location = new System.Drawing.Point(105, 43);
            this.lbArrivalDate.Name = "lbArrivalDate";
            this.lbArrivalDate.Size = new System.Drawing.Size(86, 21);
            this.lbArrivalDate.TabIndex = 2;
            this.lbArrivalDate.Text = "Ngày nhận";
            // 
            // dropDownList1
            // 
            this.dropDownList1.AutoScroll = true;
            this.dropDownList1.AutoSize = true;
            this.dropDownList1.BackColor = System.Drawing.Color.White;
            this.dropDownList1.Location = new System.Drawing.Point(17, 102);
            this.dropDownList1.MaximumSize = new System.Drawing.Size(300, 300);
            this.dropDownList1.Name = "dropDownList1";
            this.dropDownList1.Size = new System.Drawing.Size(273, 25);
            this.dropDownList1.TabIndex = 9;
            // 
            // Form_BookMulRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.pnBookingInfo);
            this.Controls.Add(this.pnToBookRoom);
            this.Controls.Add(this.pnCustomerInfo);
            this.Controls.Add(this.pbArrowBack);
            this.DoubleBuffered = true;
            this.Name = "Form_BookMulRooms";
            this.Size = new System.Drawing.Size(968, 575);
            this.Load += new System.EventHandler(this.Form_BookMulRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArrowBack)).EndInit();
            this.pnCustomerInfo.ResumeLayout(false);
            this.pnCustomerInfo.PerformLayout();
            this.pnSex.ResumeLayout(false);
            this.pnSex.PerformLayout();
            this.pnToBookRoom.ResumeLayout(false);
            this.pnToBookRoom.PerformLayout();
            this.PanelList.ResumeLayout(false);
            this.pnRoomList.ResumeLayout(false);
            this.pnToSelectRoom.ResumeLayout(false);
            this.xPanderPanel2.ResumeLayout(false);
            this.pnSeletedRoom.ResumeLayout(false);
            this.pnBookingInfo.ResumeLayout(false);
            this.pnBookingInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArrowBack;
        private System.Windows.Forms.Panel pnCustomerInfo;
        private DropDownList dropDownList1;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbNote;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbCustomerAddress;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbPassport;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbIDNo;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbCustomerPhoneNum;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbCustomerName;
        private Zeroit.Framework.MaterialDesign.Controls.ZeroitMaterialCheckBox cbPassport;
        private Zeroit.Framework.MaterialDesign.Controls.ZeroitMaterialCheckBox cbIDNo;
        private System.Windows.Forms.FlowLayoutPanel pnSex;
        private MaterialSkin.Controls.MaterialRadioButton rbtMale;
        private MaterialSkin.Controls.MaterialRadioButton rbtFemale;
        private MetroFramework.Controls.MetroDateTime dtpCustomerBirthday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnToBookRoom;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnBookingInfo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel7;
        private XanderUI.XUIButton btBookRoom;
        private Zeroit.Framework.MiscControls.ZeroitProPanelList PanelList;
        private Zeroit.Framework.MiscControls.XPanderPanel pnRoomList;
        private System.Windows.Forms.FlowLayoutPanel pnToSelectRoom;
        private Zeroit.Framework.MiscControls.XPanderPanel xPanderPanel2;
        private System.Windows.Forms.FlowLayoutPanel pnSeletedRoom;
        private Zeroit.Framework.MiscControls.ZeroitLabel StatusLabel;
        private System.Windows.Forms.Label lbListEmptyRoomIsEmpty;
        private System.Windows.Forms.Label lbListSelectedRoomIsEmpty;
        private System.Windows.Forms.Label lbArrivalDate;
    }
}
