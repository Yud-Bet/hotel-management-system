namespace HotelManagement.UI
{
    partial class Form_AddEditStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddEditStaff));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbCam = new HotelManagement.UI.CirclePictureBox();
            this.staffImage = new HotelManagement.UI.CirclePictureBox();
            this.pnButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btAddStaff = new XanderUI.XUIButton();
            this.btCancel = new XanderUI.XUIButton();
            this.btSave = new XanderUI.XUIButton();
            this.pnPosition = new System.Windows.Forms.FlowLayoutPanel();
            this.rbNorStaff = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbManager = new MaterialSkin.Controls.MaterialRadioButton();
            this.pnSex = new System.Windows.Forms.FlowLayoutPanel();
            this.rbMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.dtStartDate = new MetroFramework.Controls.MetroDateTime();
            this.dtBirthdate = new MetroFramework.Controls.MetroDateTime();
            this.tbName = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbIDNo = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbSalary = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbPhonenum = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbAddress = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbID = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.xuiButton7 = new XanderUI.XUIButton();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.xuiButton5 = new XanderUI.XUIButton();
            this.xuiButton8 = new XanderUI.XUIButton();
            this.xuiButton6 = new XanderUI.XUIButton();
            this.xuiButton4 = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.xuiButton10 = new XanderUI.XUIButton();
            this.btBookRoom = new XanderUI.XUIButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffImage)).BeginInit();
            this.pnButton.SuspendLayout();
            this.pnPosition.SuspendLayout();
            this.pnSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.pbCam);
            this.panel3.Controls.Add(this.staffImage);
            this.panel3.Controls.Add(this.pnButton);
            this.panel3.Controls.Add(this.pnPosition);
            this.panel3.Controls.Add(this.pnSex);
            this.panel3.Controls.Add(this.dtStartDate);
            this.panel3.Controls.Add(this.dtBirthdate);
            this.panel3.Controls.Add(this.tbName);
            this.panel3.Controls.Add(this.tbIDNo);
            this.panel3.Controls.Add(this.tbSalary);
            this.panel3.Controls.Add(this.tbPhonenum);
            this.panel3.Controls.Add(this.tbAddress);
            this.panel3.Controls.Add(this.tbID);
            this.panel3.Controls.Add(this.xuiButton7);
            this.panel3.Controls.Add(this.xuiButton3);
            this.panel3.Controls.Add(this.xuiButton5);
            this.panel3.Controls.Add(this.xuiButton8);
            this.panel3.Controls.Add(this.xuiButton6);
            this.panel3.Controls.Add(this.xuiButton4);
            this.panel3.Controls.Add(this.xuiButton2);
            this.panel3.Controls.Add(this.xuiButton1);
            this.panel3.Controls.Add(this.xuiButton10);
            this.panel3.Controls.Add(this.btBookRoom);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(4, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(652, 571);
            this.panel3.TabIndex = 8;
            // 
            // pbCam
            // 
            this.pbCam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCam.Image = ((System.Drawing.Image)(resources.GetObject("pbCam.Image")));
            this.pbCam.Location = new System.Drawing.Point(358, 105);
            this.pbCam.Name = "pbCam";
            this.pbCam.Size = new System.Drawing.Size(40, 40);
            this.pbCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCam.TabIndex = 24;
            this.pbCam.TabStop = false;
            this.pbCam.Click += new System.EventHandler(this.staffImage_Click);
            // 
            // staffImage
            // 
            this.staffImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffImage.Image = ((System.Drawing.Image)(resources.GetObject("staffImage.Image")));
            this.staffImage.Location = new System.Drawing.Point(253, 0);
            this.staffImage.Name = "staffImage";
            this.staffImage.Size = new System.Drawing.Size(145, 145);
            this.staffImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staffImage.TabIndex = 23;
            this.staffImage.TabStop = false;
            this.staffImage.Click += new System.EventHandler(this.staffImage_Click);
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.btAddStaff);
            this.pnButton.Controls.Add(this.btCancel);
            this.pnButton.Controls.Add(this.btSave);
            this.pnButton.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnButton.Location = new System.Drawing.Point(368, 528);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(253, 36);
            this.pnButton.TabIndex = 22;
            // 
            // btAddStaff
            // 
            this.btAddStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btAddStaff.ButtonImage = global::HotelManagement.Properties.Resources.icAddRoom2;
            this.btAddStaff.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btAddStaff.ButtonText = "Thêm nhân viên";
            this.btAddStaff.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btAddStaff.ClickTextColor = System.Drawing.Color.White;
            this.btAddStaff.CornerRadius = 5;
            this.btAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddStaff.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btAddStaff.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btAddStaff.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btAddStaff.HoverTextColor = System.Drawing.Color.White;
            this.btAddStaff.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btAddStaff.Location = new System.Drawing.Point(74, 3);
            this.btAddStaff.Name = "btAddStaff";
            this.btAddStaff.Size = new System.Drawing.Size(176, 29);
            this.btAddStaff.TabIndex = 0;
            this.btAddStaff.TabStop = false;
            this.btAddStaff.TextColor = System.Drawing.Color.White;
            this.btAddStaff.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btAddStaff.Click += new System.EventHandler(this.btAddStaff_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btCancel.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btCancel.ButtonImage")));
            this.btCancel.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btCancel.ButtonText = "Thoát";
            this.btCancel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btCancel.ClickTextColor = System.Drawing.Color.White;
            this.btCancel.CornerRadius = 5;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btCancel.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btCancel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btCancel.HoverTextColor = System.Drawing.Color.White;
            this.btCancel.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btCancel.Location = new System.Drawing.Point(151, 38);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(99, 29);
            this.btCancel.TabIndex = 0;
            this.btCancel.TabStop = false;
            this.btCancel.TextColor = System.Drawing.Color.White;
            this.btCancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btSave.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btSave.ButtonImage")));
            this.btSave.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btSave.ButtonText = "Lưu";
            this.btSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btSave.ClickTextColor = System.Drawing.Color.White;
            this.btSave.CornerRadius = 5;
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btSave.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btSave.HoverTextColor = System.Drawing.Color.White;
            this.btSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btSave.Location = new System.Drawing.Point(46, 38);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(99, 29);
            this.btSave.TabIndex = 0;
            this.btSave.TextColor = System.Drawing.Color.White;
            this.btSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // pnPosition
            // 
            this.pnPosition.Controls.Add(this.rbNorStaff);
            this.pnPosition.Controls.Add(this.rbManager);
            this.pnPosition.Location = new System.Drawing.Point(393, 176);
            this.pnPosition.Name = "pnPosition";
            this.pnPosition.Size = new System.Drawing.Size(178, 32);
            this.pnPosition.TabIndex = 1;
            // 
            // rbNorStaff
            // 
            this.rbNorStaff.AutoSize = true;
            this.rbNorStaff.Depth = 0;
            this.rbNorStaff.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbNorStaff.Location = new System.Drawing.Point(0, 0);
            this.rbNorStaff.Margin = new System.Windows.Forms.Padding(0);
            this.rbNorStaff.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbNorStaff.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbNorStaff.Name = "rbNorStaff";
            this.rbNorStaff.Ripple = true;
            this.rbNorStaff.Size = new System.Drawing.Size(90, 30);
            this.rbNorStaff.TabIndex = 6;
            this.rbNorStaff.Text = "Nhân viên";
            this.rbNorStaff.UseVisualStyleBackColor = true;
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Depth = 0;
            this.rbManager.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbManager.Location = new System.Drawing.Point(90, 0);
            this.rbManager.Margin = new System.Windows.Forms.Padding(0);
            this.rbManager.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbManager.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbManager.Name = "rbManager";
            this.rbManager.Ripple = true;
            this.rbManager.Size = new System.Drawing.Size(75, 30);
            this.rbManager.TabIndex = 6;
            this.rbManager.Text = "Quản lý";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // pnSex
            // 
            this.pnSex.Controls.Add(this.rbMale);
            this.pnSex.Controls.Add(this.rbFemale);
            this.pnSex.Location = new System.Drawing.Point(393, 330);
            this.pnSex.Name = "pnSex";
            this.pnSex.Size = new System.Drawing.Size(178, 32);
            this.pnSex.TabIndex = 5;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Depth = 0;
            this.rbMale.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbMale.Location = new System.Drawing.Point(0, 0);
            this.rbMale.Margin = new System.Windows.Forms.Padding(0);
            this.rbMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMale.Name = "rbMale";
            this.rbMale.Ripple = true;
            this.rbMale.Size = new System.Drawing.Size(58, 30);
            this.rbMale.TabIndex = 6;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Depth = 0;
            this.rbFemale.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbFemale.Location = new System.Drawing.Point(58, 0);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(0);
            this.rbFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Ripple = true;
            this.rbFemale.Size = new System.Drawing.Size(47, 30);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(91, 487);
            this.dtStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(116, 29);
            this.dtStartDate.TabIndex = 8;
            this.dtStartDate.TabStop = false;
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthdate.Location = new System.Drawing.Point(91, 333);
            this.dtBirthdate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(116, 29);
            this.dtBirthdate.TabIndex = 4;
            this.dtBirthdate.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.DisabledStringColor = System.Drawing.Color.Black;
            this.tbName.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tbName.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.IsEnabled = true;
            this.tbName.Location = new System.Drawing.Point(91, 261);
            this.tbName.MaxLength = 32767;
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.Placeholder = true;
            this.tbName.PlaceHolderText = "";
            this.tbName.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbName.ReadOnly = false;
            this.tbName.Size = new System.Drawing.Size(224, 24);
            this.tbName.TabIndex = 1;
            this.tbName.Tag = "";
            this.tbName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbName.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbName.UseSystemPasswordChar = false;
            this.tbName.WordWrap = true;
            // 
            // tbIDNo
            // 
            this.tbIDNo.DisabledStringColor = System.Drawing.Color.Black;
            this.tbIDNo.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tbIDNo.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbIDNo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.tbIDNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbIDNo.ForeColor = System.Drawing.Color.Black;
            this.tbIDNo.IsEnabled = true;
            this.tbIDNo.Location = new System.Drawing.Point(393, 257);
            this.tbIDNo.MaxLength = 32767;
            this.tbIDNo.Multiline = false;
            this.tbIDNo.Name = "tbIDNo";
            this.tbIDNo.PasswordChar = '\0';
            this.tbIDNo.Placeholder = true;
            this.tbIDNo.PlaceHolderText = "";
            this.tbIDNo.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbIDNo.ReadOnly = false;
            this.tbIDNo.Size = new System.Drawing.Size(224, 24);
            this.tbIDNo.TabIndex = 2;
            this.tbIDNo.Tag = "";
            this.tbIDNo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbIDNo.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbIDNo.UseSystemPasswordChar = false;
            this.tbIDNo.WordWrap = true;
            // 
            // tbSalary
            // 
            this.tbSalary.DisabledStringColor = System.Drawing.Color.Black;
            this.tbSalary.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tbSalary.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbSalary.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.tbSalary.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbSalary.ForeColor = System.Drawing.Color.Black;
            this.tbSalary.IsEnabled = true;
            this.tbSalary.Location = new System.Drawing.Point(393, 492);
            this.tbSalary.MaxLength = 32767;
            this.tbSalary.Multiline = false;
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.PasswordChar = '\0';
            this.tbSalary.Placeholder = true;
            this.tbSalary.PlaceHolderText = "";
            this.tbSalary.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbSalary.ReadOnly = false;
            this.tbSalary.Size = new System.Drawing.Size(224, 24);
            this.tbSalary.TabIndex = 5;
            this.tbSalary.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSalary.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbSalary.UseSystemPasswordChar = false;
            this.tbSalary.WordWrap = true;
            // 
            // tbPhonenum
            // 
            this.tbPhonenum.DisabledStringColor = System.Drawing.Color.Black;
            this.tbPhonenum.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tbPhonenum.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbPhonenum.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.tbPhonenum.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbPhonenum.ForeColor = System.Drawing.Color.Black;
            this.tbPhonenum.IsEnabled = true;
            this.tbPhonenum.Location = new System.Drawing.Point(393, 415);
            this.tbPhonenum.MaxLength = 32767;
            this.tbPhonenum.Multiline = false;
            this.tbPhonenum.Name = "tbPhonenum";
            this.tbPhonenum.PasswordChar = '\0';
            this.tbPhonenum.Placeholder = true;
            this.tbPhonenum.PlaceHolderText = "";
            this.tbPhonenum.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbPhonenum.ReadOnly = false;
            this.tbPhonenum.Size = new System.Drawing.Size(224, 24);
            this.tbPhonenum.TabIndex = 4;
            this.tbPhonenum.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPhonenum.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbPhonenum.UseSystemPasswordChar = false;
            this.tbPhonenum.WordWrap = true;
            // 
            // tbAddress
            // 
            this.tbAddress.DisabledStringColor = System.Drawing.Color.Black;
            this.tbAddress.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tbAddress.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbAddress.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbAddress.ForeColor = System.Drawing.Color.Black;
            this.tbAddress.IsEnabled = true;
            this.tbAddress.Location = new System.Drawing.Point(91, 415);
            this.tbAddress.MaxLength = 32767;
            this.tbAddress.Multiline = false;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PasswordChar = '\0';
            this.tbAddress.Placeholder = true;
            this.tbAddress.PlaceHolderText = "";
            this.tbAddress.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbAddress.ReadOnly = false;
            this.tbAddress.Size = new System.Drawing.Size(224, 24);
            this.tbAddress.TabIndex = 3;
            this.tbAddress.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAddress.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbAddress.UseSystemPasswordChar = false;
            this.tbAddress.WordWrap = true;
            // 
            // tbID
            // 
            this.tbID.DisabledStringColor = System.Drawing.Color.Black;
            this.tbID.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tbID.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbID.ForeColor = System.Drawing.Color.Black;
            this.tbID.IsEnabled = false;
            this.tbID.Location = new System.Drawing.Point(91, 184);
            this.tbID.MaxLength = 32767;
            this.tbID.Multiline = false;
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.Placeholder = true;
            this.tbID.PlaceHolderText = "";
            this.tbID.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(224, 24);
            this.tbID.TabIndex = 0;
            this.tbID.TabStop = false;
            this.tbID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbID.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbID.UseSystemPasswordChar = false;
            this.tbID.WordWrap = true;
            // 
            // xuiButton7
            // 
            this.xuiButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton7.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton7.ButtonImage")));
            this.xuiButton7.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton7.ButtonText = "";
            this.xuiButton7.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton7.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton7.CornerRadius = 5;
            this.xuiButton7.Cursor = System.Windows.Forms.Cursors.Default;
            this.xuiButton7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.xuiButton7.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.xuiButton7.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton7.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton7.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton7.Location = new System.Drawing.Point(332, 235);
            this.xuiButton7.Name = "xuiButton7";
            this.xuiButton7.Size = new System.Drawing.Size(51, 50);
            this.xuiButton7.TabIndex = 17;
            this.xuiButton7.TabStop = false;
            this.xuiButton7.TextColor = System.Drawing.Color.White;
            this.xuiButton7.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton3.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton3.ButtonImage")));
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton3.ButtonText = "";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton3.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton3.CornerRadius = 5;
            this.xuiButton3.Cursor = System.Windows.Forms.Cursors.Default;
            this.xuiButton3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton3.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(332, 312);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(51, 50);
            this.xuiButton3.TabIndex = 17;
            this.xuiButton3.TabStop = false;
            this.xuiButton3.TextColor = System.Drawing.Color.White;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton5
            // 
            this.xuiButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton5.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton5.ButtonImage")));
            this.xuiButton5.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton5.ButtonText = "";
            this.xuiButton5.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton5.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton5.CornerRadius = 5;
            this.xuiButton5.Cursor = System.Windows.Forms.Cursors.Default;
            this.xuiButton5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.xuiButton5.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.xuiButton5.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton5.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton5.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton5.Location = new System.Drawing.Point(332, 466);
            this.xuiButton5.Name = "xuiButton5";
            this.xuiButton5.Size = new System.Drawing.Size(51, 50);
            this.xuiButton5.TabIndex = 17;
            this.xuiButton5.TabStop = false;
            this.xuiButton5.TextColor = System.Drawing.Color.White;
            this.xuiButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton8
            // 
            this.xuiButton8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton8.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton8.ButtonImage")));
            this.xuiButton8.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton8.ButtonText = "";
            this.xuiButton8.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton8.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton8.CornerRadius = 5;
            this.xuiButton8.Cursor = System.Windows.Forms.Cursors.Default;
            this.xuiButton8.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.xuiButton8.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.xuiButton8.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton8.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton8.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton8.Location = new System.Drawing.Point(332, 389);
            this.xuiButton8.Name = "xuiButton8";
            this.xuiButton8.Size = new System.Drawing.Size(51, 50);
            this.xuiButton8.TabIndex = 17;
            this.xuiButton8.TabStop = false;
            this.xuiButton8.TextColor = System.Drawing.Color.White;
            this.xuiButton8.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton6
            // 
            this.xuiButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton6.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton6.ButtonImage")));
            this.xuiButton6.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton6.ButtonText = "";
            this.xuiButton6.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton6.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton6.CornerRadius = 5;
            this.xuiButton6.Cursor = System.Windows.Forms.Cursors.Default;
            this.xuiButton6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.xuiButton6.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.xuiButton6.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton6.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton6.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton6.Location = new System.Drawing.Point(34, 389);
            this.xuiButton6.Name = "xuiButton6";
            this.xuiButton6.Size = new System.Drawing.Size(51, 50);
            this.xuiButton6.TabIndex = 17;
            this.xuiButton6.TabStop = false;
            this.xuiButton6.TextColor = System.Drawing.Color.White;
            this.xuiButton6.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton4
            // 
            this.xuiButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton4.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton4.ButtonImage")));
            this.xuiButton4.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton4.ButtonText = "";
            this.xuiButton4.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton4.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton4.CornerRadius = 5;
            this.xuiButton4.Cursor = System.Windows.Forms.Cursors.Default;
            this.xuiButton4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.xuiButton4.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.xuiButton4.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton4.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton4.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton4.Location = new System.Drawing.Point(34, 466);
            this.xuiButton4.Name = "xuiButton4";
            this.xuiButton4.Size = new System.Drawing.Size(51, 50);
            this.xuiButton4.TabIndex = 17;
            this.xuiButton4.TabStop = false;
            this.xuiButton4.TextColor = System.Drawing.Color.White;
            this.xuiButton4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton2.ButtonImage")));
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.xuiButton2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(34, 312);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(51, 50);
            this.xuiButton2.TabIndex = 17;
            this.xuiButton2.TabStop = false;
            this.xuiButton2.TextColor = System.Drawing.Color.White;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.xuiButton1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(34, 235);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(51, 50);
            this.xuiButton1.TabIndex = 17;
            this.xuiButton1.TabStop = false;
            this.xuiButton1.TextColor = System.Drawing.Color.White;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton10
            // 
            this.xuiButton10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton10.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton10.ButtonImage")));
            this.xuiButton10.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton10.ButtonText = "";
            this.xuiButton10.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton10.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton10.CornerRadius = 5;
            this.xuiButton10.Cursor = System.Windows.Forms.Cursors.Default;
            this.xuiButton10.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.xuiButton10.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.xuiButton10.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiButton10.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton10.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton10.Location = new System.Drawing.Point(332, 158);
            this.xuiButton10.Name = "xuiButton10";
            this.xuiButton10.Size = new System.Drawing.Size(51, 50);
            this.xuiButton10.TabIndex = 17;
            this.xuiButton10.TabStop = false;
            this.xuiButton10.TextColor = System.Drawing.Color.White;
            this.xuiButton10.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btBookRoom
            // 
            this.btBookRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btBookRoom.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btBookRoom.ButtonImage")));
            this.btBookRoom.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btBookRoom.ButtonText = "";
            this.btBookRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btBookRoom.ClickTextColor = System.Drawing.Color.White;
            this.btBookRoom.CornerRadius = 5;
            this.btBookRoom.Cursor = System.Windows.Forms.Cursors.Default;
            this.btBookRoom.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btBookRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btBookRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btBookRoom.HoverTextColor = System.Drawing.Color.White;
            this.btBookRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btBookRoom.Location = new System.Drawing.Point(34, 158);
            this.btBookRoom.Name = "btBookRoom";
            this.btBookRoom.Size = new System.Drawing.Size(51, 50);
            this.btBookRoom.TabIndex = 17;
            this.btBookRoom.TabStop = false;
            this.btBookRoom.TextColor = System.Drawing.Color.White;
            this.btBookRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(389, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Lương";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(389, 389);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "Số điện thoại";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(389, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "CMND";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(91, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giới tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(91, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày vào làm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(389, 158);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 19);
            this.label20.TabIndex = 0;
            this.label20.Text = "Chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // Form_AddEditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 607);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.Name = "Form_AddEditStaff";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AddEditStaff_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffImage)).EndInit();
            this.pnButton.ResumeLayout(false);
            this.pnPosition.ResumeLayout(false);
            this.pnPosition.PerformLayout();
            this.pnSex.ResumeLayout(false);
            this.pnSex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private XanderUI.XUIButton xuiButton7;
        private XanderUI.XUIButton xuiButton3;
        private XanderUI.XUIButton xuiButton5;
        private XanderUI.XUIButton xuiButton8;
        private XanderUI.XUIButton xuiButton6;
        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton xuiButton1;
        private XanderUI.XUIButton xuiButton10;
        private XanderUI.XUIButton btBookRoom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime dtStartDate;
        private MetroFramework.Controls.MetroDateTime dtBirthdate;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbName;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbAddress;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbID;
        private XanderUI.XUIButton xuiButton4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel pnPosition;
        private MaterialSkin.Controls.MaterialRadioButton rbNorStaff;
        private MaterialSkin.Controls.MaterialRadioButton rbManager;
        private System.Windows.Forms.FlowLayoutPanel pnSex;
        private MaterialSkin.Controls.MaterialRadioButton rbMale;
        private MaterialSkin.Controls.MaterialRadioButton rbFemale;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbIDNo;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbSalary;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbPhonenum;
        private System.Windows.Forms.FlowLayoutPanel pnButton;
        private XanderUI.XUIButton btAddStaff;
        private XanderUI.XUIButton btCancel;
        private XanderUI.XUIButton btSave;
        private CirclePictureBox staffImage;
        private CirclePictureBox pbCam;
    }
}