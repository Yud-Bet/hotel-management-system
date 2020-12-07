namespace HotelManagement.UI
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkRooms = new System.Windows.Forms.CheckedListBox();
            this.pnCustomerInfo = new System.Windows.Forms.Panel();
            this.tbNote = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbCustomerAddress = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbPassport = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbIDNo = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbCustomerPhoneNum = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbCustomerName = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.cbPassport = new Zeroit.Framework.MaterialDesign.Controls.ZeroitMaterialCheckBox();
            this.cbIDNo = new Zeroit.Framework.MaterialDesign.Controls.ZeroitMaterialCheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.dtpCustomerBirthday = new MetroFramework.Controls.MetroDateTime();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btBookRoom = new XanderUI.XUIButton();
            this.btPay = new XanderUI.XUIButton();
            this.btSettingRoom = new XanderUI.XUIButton();
            this.btDeleteRoom = new XanderUI.XUIButton();
            this.btUpdateInfo = new XanderUI.XUIButton();
            this.pnBookingInfo = new System.Windows.Forms.Panel();
            this.cbCheckOutDate = new Zeroit.Framework.MaterialDesign.Controls.ZeroitMaterialCheckBox();
            this.dtpCheckOutDate = new MetroFramework.Controls.MetroDateTime();
            this.dtpCheckInDate = new MetroFramework.Controls.MetroDateTime();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnCustomerInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.pnBookingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkRooms
            // 
            this.checkRooms.FormattingEnabled = true;
            this.checkRooms.Location = new System.Drawing.Point(795, 26);
            this.checkRooms.Name = "checkRooms";
            this.checkRooms.Size = new System.Drawing.Size(137, 199);
            this.checkRooms.TabIndex = 2;
            // 
            // pnCustomerInfo
            // 
            this.pnCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnCustomerInfo.Controls.Add(this.tbNote);
            this.pnCustomerInfo.Controls.Add(this.tbCustomerAddress);
            this.pnCustomerInfo.Controls.Add(this.tbPassport);
            this.pnCustomerInfo.Controls.Add(this.tbIDNo);
            this.pnCustomerInfo.Controls.Add(this.tbCustomerPhoneNum);
            this.pnCustomerInfo.Controls.Add(this.tbCustomerName);
            this.pnCustomerInfo.Controls.Add(this.cbPassport);
            this.pnCustomerInfo.Controls.Add(this.cbIDNo);
            this.pnCustomerInfo.Controls.Add(this.flowLayoutPanel1);
            this.pnCustomerInfo.Controls.Add(this.dtpCustomerBirthday);
            this.pnCustomerInfo.Controls.Add(this.label10);
            this.pnCustomerInfo.Controls.Add(this.label11);
            this.pnCustomerInfo.Controls.Add(this.label12);
            this.pnCustomerInfo.Controls.Add(this.label13);
            this.pnCustomerInfo.Controls.Add(this.label14);
            this.pnCustomerInfo.Controls.Add(this.label15);
            this.pnCustomerInfo.Controls.Add(this.label16);
            this.pnCustomerInfo.Controls.Add(this.label17);
            this.pnCustomerInfo.Controls.Add(this.label18);
            this.pnCustomerInfo.Controls.Add(this.panel3);
            this.pnCustomerInfo.Location = new System.Drawing.Point(19, 22);
            this.pnCustomerInfo.Name = "pnCustomerInfo";
            this.pnCustomerInfo.Size = new System.Drawing.Size(491, 467);
            this.pnCustomerInfo.TabIndex = 9;
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
            this.tbNote.Location = new System.Drawing.Point(17, 364);
            this.tbNote.MaxLength = 32767;
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.PasswordChar = '\0';
            this.tbNote.Placeholder = true;
            this.tbNote.PlaceHolderText = "";
            this.tbNote.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbNote.ReadOnly = false;
            this.tbNote.Size = new System.Drawing.Size(440, 81);
            this.tbNote.TabIndex = 5;
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
            this.tbCustomerAddress.Location = new System.Drawing.Point(17, 304);
            this.tbCustomerAddress.MaxLength = 32767;
            this.tbCustomerAddress.Multiline = false;
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.PasswordChar = '\0';
            this.tbCustomerAddress.Placeholder = true;
            this.tbCustomerAddress.PlaceHolderText = "";
            this.tbCustomerAddress.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbCustomerAddress.ReadOnly = false;
            this.tbCustomerAddress.Size = new System.Drawing.Size(440, 24);
            this.tbCustomerAddress.TabIndex = 4;
            this.tbCustomerAddress.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCustomerAddress.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbCustomerAddress.UseSystemPasswordChar = false;
            this.tbCustomerAddress.WordWrap = true;
            // 
            // tbPassport
            // 
            this.tbPassport.DisabledStringColor = System.Drawing.Color.Black;
            this.tbPassport.DisabledUnFocusedColor = System.Drawing.Color.Silver;
            this.tbPassport.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassport.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.tbPassport.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbPassport.ForeColor = System.Drawing.Color.Black;
            this.tbPassport.IsEnabled = false;
            this.tbPassport.Location = new System.Drawing.Point(252, 233);
            this.tbPassport.MaxLength = 32767;
            this.tbPassport.Multiline = false;
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.PasswordChar = '\0';
            this.tbPassport.Placeholder = true;
            this.tbPassport.PlaceHolderText = "";
            this.tbPassport.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbPassport.ReadOnly = true;
            this.tbPassport.Size = new System.Drawing.Size(205, 24);
            this.tbPassport.TabIndex = 3;
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
            this.tbIDNo.Location = new System.Drawing.Point(17, 233);
            this.tbIDNo.MaxLength = 32767;
            this.tbIDNo.Multiline = false;
            this.tbIDNo.Name = "tbIDNo";
            this.tbIDNo.PasswordChar = '\0';
            this.tbIDNo.Placeholder = true;
            this.tbIDNo.PlaceHolderText = "";
            this.tbIDNo.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbIDNo.ReadOnly = false;
            this.tbIDNo.Size = new System.Drawing.Size(205, 24);
            this.tbIDNo.TabIndex = 3;
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
            this.tbCustomerPhoneNum.Location = new System.Drawing.Point(17, 156);
            this.tbCustomerPhoneNum.MaxLength = 32767;
            this.tbCustomerPhoneNum.Multiline = false;
            this.tbCustomerPhoneNum.Name = "tbCustomerPhoneNum";
            this.tbCustomerPhoneNum.PasswordChar = '\0';
            this.tbCustomerPhoneNum.Placeholder = true;
            this.tbCustomerPhoneNum.PlaceHolderText = "";
            this.tbCustomerPhoneNum.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbCustomerPhoneNum.ReadOnly = false;
            this.tbCustomerPhoneNum.Size = new System.Drawing.Size(267, 24);
            this.tbCustomerPhoneNum.TabIndex = 2;
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
            this.tbCustomerName.Location = new System.Drawing.Point(17, 77);
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
            // 
            // cbPassport
            // 
            this.cbPassport.AllowTransparency = true;
            this.cbPassport.Checked = false;
            this.cbPassport.Depth = 0;
            this.cbPassport.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbPassport.Location = new System.Drawing.Point(351, 200);
            this.cbPassport.Margin = new System.Windows.Forms.Padding(0);
            this.cbPassport.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbPassport.MouseState = Zeroit.Framework.MaterialDesign.MouseState.HOVER;
            this.cbPassport.Name = "cbPassport";
            this.cbPassport.Ripple = true;
            this.cbPassport.Size = new System.Drawing.Size(27, 23);
            this.cbPassport.TabIndex = 0;
            this.cbPassport.TabStop = false;
            // 
            // cbIDNo
            // 
            this.cbIDNo.AllowTransparency = true;
            this.cbIDNo.Checked = true;
            this.cbIDNo.Depth = 0;
            this.cbIDNo.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbIDNo.Location = new System.Drawing.Point(189, 200);
            this.cbIDNo.Margin = new System.Windows.Forms.Padding(0);
            this.cbIDNo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbIDNo.MouseState = Zeroit.Framework.MaterialDesign.MouseState.HOVER;
            this.cbIDNo.Name = "cbIDNo";
            this.cbIDNo.Ripple = true;
            this.cbIDNo.Size = new System.Drawing.Size(27, 23);
            this.cbIDNo.TabIndex = 0;
            this.cbIDNo.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbtMale);
            this.flowLayoutPanel1.Controls.Add(this.rbtFemale);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(310, 151);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 32);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Depth = 0;
            this.rbtMale.Font = new System.Drawing.Font("Roboto", 10F);
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
            this.rbtFemale.Font = new System.Drawing.Font("Roboto", 10F);
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
            this.dtpCustomerBirthday.Location = new System.Drawing.Point(310, 75);
            this.dtpCustomerBirthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpCustomerBirthday.Name = "dtpCustomerBirthday";
            this.dtpCustomerBirthday.Size = new System.Drawing.Size(162, 29);
            this.dtpCustomerBirthday.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(248, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Số hộ chiếu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Ghi chú";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(3, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "Địa chỉ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(3, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Chứng minh nhân dân";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(3, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 21);
            this.label14.TabIndex = 2;
            this.label14.Text = "Số điện thoại";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(306, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "Giới tính";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(306, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "Ngày sinh";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(3, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 21);
            this.label17.TabIndex = 2;
            this.label17.Text = "Tên khách hàng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(196, 25);
            this.label18.TabIndex = 2;
            this.label18.Text = "Thông tin khách hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(7, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 3);
            this.panel3.TabIndex = 3;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btBookRoom);
            this.flowLayoutPanel4.Controls.Add(this.btPay);
            this.flowLayoutPanel4.Controls.Add(this.btSettingRoom);
            this.flowLayoutPanel4.Controls.Add(this.btDeleteRoom);
            this.flowLayoutPanel4.Controls.Add(this.btUpdateInfo);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(518, 359);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(434, 123);
            this.flowLayoutPanel4.TabIndex = 28;
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
            this.btBookRoom.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btBookRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btBookRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btBookRoom.HoverTextColor = System.Drawing.Color.White;
            this.btBookRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btBookRoom.Location = new System.Drawing.Point(3, 3);
            this.btBookRoom.Name = "btBookRoom";
            this.btBookRoom.Size = new System.Drawing.Size(131, 50);
            this.btBookRoom.TabIndex = 16;
            this.btBookRoom.TextColor = System.Drawing.Color.White;
            this.btBookRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btBookRoom.Click += new System.EventHandler(this.btBookRoom_Click);
            // 
            // btPay
            // 
            this.btPay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btPay.ButtonImage = global::HotelManagement.Properties.Resources.icPayment;
            this.btPay.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btPay.ButtonText = "Thanh Toán";
            this.btPay.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(161)))));
            this.btPay.ClickTextColor = System.Drawing.Color.White;
            this.btPay.CornerRadius = 5;
            this.btPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPay.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btPay.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btPay.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btPay.HoverTextColor = System.Drawing.Color.White;
            this.btPay.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btPay.Location = new System.Drawing.Point(140, 3);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(131, 50);
            this.btPay.TabIndex = 16;
            this.btPay.TextColor = System.Drawing.Color.White;
            this.btPay.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btSettingRoom
            // 
            this.btSettingRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btSettingRoom.ButtonImage = global::HotelManagement.Properties.Resources.icManage1;
            this.btSettingRoom.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btSettingRoom.ButtonText = "Cài Đặt";
            this.btSettingRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btSettingRoom.ClickTextColor = System.Drawing.Color.White;
            this.btSettingRoom.CornerRadius = 5;
            this.btSettingRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSettingRoom.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btSettingRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btSettingRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btSettingRoom.HoverTextColor = System.Drawing.Color.White;
            this.btSettingRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btSettingRoom.Location = new System.Drawing.Point(277, 3);
            this.btSettingRoom.Name = "btSettingRoom";
            this.btSettingRoom.Size = new System.Drawing.Size(131, 50);
            this.btSettingRoom.TabIndex = 17;
            this.btSettingRoom.TextColor = System.Drawing.Color.White;
            this.btSettingRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btDeleteRoom
            // 
            this.btDeleteRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btDeleteRoom.ButtonImage = global::HotelManagement.Properties.Resources.icDelete;
            this.btDeleteRoom.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btDeleteRoom.ButtonText = "Xóa Phòng";
            this.btDeleteRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btDeleteRoom.ClickTextColor = System.Drawing.Color.White;
            this.btDeleteRoom.CornerRadius = 5;
            this.btDeleteRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeleteRoom.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btDeleteRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btDeleteRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btDeleteRoom.HoverTextColor = System.Drawing.Color.White;
            this.btDeleteRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btDeleteRoom.Location = new System.Drawing.Point(3, 59);
            this.btDeleteRoom.Name = "btDeleteRoom";
            this.btDeleteRoom.Size = new System.Drawing.Size(131, 50);
            this.btDeleteRoom.TabIndex = 18;
            this.btDeleteRoom.TextColor = System.Drawing.Color.White;
            this.btDeleteRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btUpdateInfo
            // 
            this.btUpdateInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btUpdateInfo.ButtonImage = global::HotelManagement.Properties.Resources.icYes1;
            this.btUpdateInfo.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btUpdateInfo.ButtonText = "Thay đổi";
            this.btUpdateInfo.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btUpdateInfo.ClickTextColor = System.Drawing.Color.White;
            this.btUpdateInfo.CornerRadius = 5;
            this.btUpdateInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdateInfo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btUpdateInfo.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btUpdateInfo.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btUpdateInfo.HoverTextColor = System.Drawing.Color.White;
            this.btUpdateInfo.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btUpdateInfo.Location = new System.Drawing.Point(140, 59);
            this.btUpdateInfo.Name = "btUpdateInfo";
            this.btUpdateInfo.Size = new System.Drawing.Size(131, 50);
            this.btUpdateInfo.TabIndex = 16;
            this.btUpdateInfo.TextColor = System.Drawing.Color.White;
            this.btUpdateInfo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // pnBookingInfo
            // 
            this.pnBookingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnBookingInfo.Controls.Add(this.cbCheckOutDate);
            this.pnBookingInfo.Controls.Add(this.dtpCheckOutDate);
            this.pnBookingInfo.Controls.Add(this.dtpCheckInDate);
            this.pnBookingInfo.Controls.Add(this.label19);
            this.pnBookingInfo.Controls.Add(this.label20);
            this.pnBookingInfo.Controls.Add(this.label23);
            this.pnBookingInfo.Controls.Add(this.panel7);
            this.pnBookingInfo.Location = new System.Drawing.Point(532, 158);
            this.pnBookingInfo.Name = "pnBookingInfo";
            this.pnBookingInfo.Size = new System.Drawing.Size(257, 183);
            this.pnBookingInfo.TabIndex = 27;
            // 
            // cbCheckOutDate
            // 
            this.cbCheckOutDate.AllowTransparency = true;
            this.cbCheckOutDate.Checked = false;
            this.cbCheckOutDate.Depth = 0;
            this.cbCheckOutDate.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbCheckOutDate.Location = new System.Drawing.Point(95, 117);
            this.cbCheckOutDate.Margin = new System.Windows.Forms.Padding(0);
            this.cbCheckOutDate.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbCheckOutDate.MouseState = Zeroit.Framework.MaterialDesign.MouseState.HOVER;
            this.cbCheckOutDate.Name = "cbCheckOutDate";
            this.cbCheckOutDate.Ripple = true;
            this.cbCheckOutDate.Size = new System.Drawing.Size(27, 23);
            this.cbCheckOutDate.TabIndex = 0;
            this.cbCheckOutDate.TabStop = false;
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Enabled = false;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(27, 144);
            this.dtpCheckOutDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(211, 29);
            this.dtpCheckOutDate.TabIndex = 13;
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Enabled = false;
            this.dtpCheckInDate.Location = new System.Drawing.Point(27, 70);
            this.dtpCheckInDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(211, 29);
            this.dtpCheckInDate.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(23, 117);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 21);
            this.label19.TabIndex = 2;
            this.label19.Text = "Ngày trả";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(23, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 21);
            this.label20.TabIndex = 2;
            this.label20.Text = "Ngày nhận";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 512);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.pnBookingInfo);
            this.Controls.Add(this.pnCustomerInfo);
            this.Controls.Add(this.checkRooms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnCustomerInfo.ResumeLayout(false);
            this.pnCustomerInfo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.pnBookingInfo.ResumeLayout(false);
            this.pnBookingInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkRooms;
        private System.Windows.Forms.Panel pnCustomerInfo;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbNote;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbCustomerAddress;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbPassport;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbIDNo;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbCustomerPhoneNum;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbCustomerName;
        private Zeroit.Framework.MaterialDesign.Controls.ZeroitMaterialCheckBox cbPassport;
        private Zeroit.Framework.MaterialDesign.Controls.ZeroitMaterialCheckBox cbIDNo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialRadioButton rbtMale;
        private MaterialSkin.Controls.MaterialRadioButton rbtFemale;
        private MetroFramework.Controls.MetroDateTime dtpCustomerBirthday;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private XanderUI.XUIButton btBookRoom;
        private XanderUI.XUIButton btPay;
        private XanderUI.XUIButton btSettingRoom;
        private XanderUI.XUIButton btDeleteRoom;
        private XanderUI.XUIButton btUpdateInfo;
        private System.Windows.Forms.Panel pnBookingInfo;
        private Zeroit.Framework.MaterialDesign.Controls.ZeroitMaterialCheckBox cbCheckOutDate;
        private MetroFramework.Controls.MetroDateTime dtpCheckOutDate;
        private MetroFramework.Controls.MetroDateTime dtpCheckInDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel7;
    }
}