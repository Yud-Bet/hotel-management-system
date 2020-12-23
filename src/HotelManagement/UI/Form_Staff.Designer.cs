namespace HotelManagement.UI
{
    partial class Form_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Staff));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnToAddItem = new System.Windows.Forms.FlowLayoutPanel();
            this.lbListStaffIsEmpty = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.staffImage = new HotelManagement.UI.CirclePictureBox();
            this.btAccount = new XanderUI.XUIButton();
            this.btChangeStaffInfo = new XanderUI.XUIButton();
            this.lbAddress = new Zeroit.Framework.Labels.ZeroitMultiFormatLabel();
            this.xuiButton7 = new XanderUI.XUIButton();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.xuiButton5 = new XanderUI.XUIButton();
            this.xuiButton8 = new XanderUI.XUIButton();
            this.xuiButton6 = new XanderUI.XUIButton();
            this.xuiButton4 = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbPhonenum = new System.Windows.Forms.Label();
            this.lbIDNo = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.lbBirthdate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xuiButton10 = new XanderUI.XUIButton();
            this.btBookRoom = new XanderUI.XUIButton();
            this.lbPosition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btAddStaff = new XanderUI.XUIButton();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.tbSearch = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.cbSort = new MetroFramework.Controls.MetroComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.pnToAddItem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffImage)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 61);
            this.panel2.TabIndex = 5;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(3, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(244, 61);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Nhân Viên";
            // 
            // pnToAddItem
            // 
            this.pnToAddItem.AutoScroll = true;
            this.pnToAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnToAddItem.Controls.Add(this.lbListStaffIsEmpty);
            this.pnToAddItem.Location = new System.Drawing.Point(16, 3);
            this.pnToAddItem.Name = "pnToAddItem";
            this.pnToAddItem.Size = new System.Drawing.Size(478, 500);
            this.pnToAddItem.TabIndex = 6;
            this.pnToAddItem.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnToAddItem_ControlAdded);
            this.pnToAddItem.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnToAddItem_ControlRemoved);
            // 
            // lbListStaffIsEmpty
            // 
            this.lbListStaffIsEmpty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListStaffIsEmpty.Location = new System.Drawing.Point(3, 0);
            this.lbListStaffIsEmpty.Name = "lbListStaffIsEmpty";
            this.lbListStaffIsEmpty.Size = new System.Drawing.Size(470, 44);
            this.lbListStaffIsEmpty.TabIndex = 3;
            this.lbListStaffIsEmpty.Text = "Chưa có hóa đơn nào!";
            this.lbListStaffIsEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.pnToAddItem);
            this.panel1.Location = new System.Drawing.Point(4, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 503);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.staffImage);
            this.panel3.Controls.Add(this.btAccount);
            this.panel3.Controls.Add(this.btChangeStaffInfo);
            this.panel3.Controls.Add(this.lbAddress);
            this.panel3.Controls.Add(this.xuiButton7);
            this.panel3.Controls.Add(this.xuiButton3);
            this.panel3.Controls.Add(this.xuiButton5);
            this.panel3.Controls.Add(this.xuiButton8);
            this.panel3.Controls.Add(this.xuiButton6);
            this.panel3.Controls.Add(this.xuiButton4);
            this.panel3.Controls.Add(this.xuiButton2);
            this.panel3.Controls.Add(this.lbSalary);
            this.panel3.Controls.Add(this.lbPhonenum);
            this.panel3.Controls.Add(this.lbIDNo);
            this.panel3.Controls.Add(this.lbSex);
            this.panel3.Controls.Add(this.lbStartDate);
            this.panel3.Controls.Add(this.xuiButton1);
            this.panel3.Controls.Add(this.lbBirthdate);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lbName);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.xuiButton10);
            this.panel3.Controls.Add(this.btBookRoom);
            this.panel3.Controls.Add(this.lbPosition);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.lbID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(505, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 503);
            this.panel3.TabIndex = 7;
            // 
            // staffImage
            // 
            this.staffImage.Image = ((System.Drawing.Image)(resources.GetObject("staffImage.Image")));
            this.staffImage.Location = new System.Drawing.Point(34, 8);
            this.staffImage.Name = "staffImage";
            this.staffImage.Size = new System.Drawing.Size(110, 110);
            this.staffImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staffImage.TabIndex = 32;
            this.staffImage.TabStop = false;
            // 
            // btAccount
            // 
            this.btAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btAccount.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btAccount.ButtonImage")));
            this.btAccount.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btAccount.ButtonText = "Tài khoản";
            this.btAccount.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btAccount.ClickTextColor = System.Drawing.Color.White;
            this.btAccount.CornerRadius = 5;
            this.btAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAccount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btAccount.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btAccount.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btAccount.HoverTextColor = System.Drawing.Color.White;
            this.btAccount.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btAccount.Location = new System.Drawing.Point(294, 43);
            this.btAccount.Name = "btAccount";
            this.btAccount.Size = new System.Drawing.Size(156, 29);
            this.btAccount.TabIndex = 31;
            this.btAccount.TextColor = System.Drawing.Color.White;
            this.btAccount.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btAccount.Click += new System.EventHandler(this.btAccount_Click);
            // 
            // btChangeStaffInfo
            // 
            this.btChangeStaffInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btChangeStaffInfo.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btChangeStaffInfo.ButtonImage")));
            this.btChangeStaffInfo.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btChangeStaffInfo.ButtonText = "Sửa thông tin";
            this.btChangeStaffInfo.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btChangeStaffInfo.ClickTextColor = System.Drawing.Color.White;
            this.btChangeStaffInfo.CornerRadius = 5;
            this.btChangeStaffInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btChangeStaffInfo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btChangeStaffInfo.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btChangeStaffInfo.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btChangeStaffInfo.HoverTextColor = System.Drawing.Color.White;
            this.btChangeStaffInfo.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btChangeStaffInfo.Location = new System.Drawing.Point(294, 8);
            this.btChangeStaffInfo.Name = "btChangeStaffInfo";
            this.btChangeStaffInfo.Size = new System.Drawing.Size(156, 29);
            this.btChangeStaffInfo.TabIndex = 31;
            this.btChangeStaffInfo.TextColor = System.Drawing.Color.White;
            this.btChangeStaffInfo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btChangeStaffInfo.Click += new System.EventHandler(this.btChangeStaffInfo_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AllowTransparency = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAddress.Location = new System.Drawing.Point(95, 382);
            this.lbAddress.MainText = "";
            this.lbAddress.MainTextPadding = new System.Windows.Forms.Padding(0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(152, 28);
            this.lbAddress.TabIndex = 19;
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
            this.xuiButton7.Location = new System.Drawing.Point(268, 206);
            this.xuiButton7.Name = "xuiButton7";
            this.xuiButton7.Size = new System.Drawing.Size(51, 50);
            this.xuiButton7.TabIndex = 17;
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
            this.xuiButton3.Location = new System.Drawing.Point(268, 283);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(51, 50);
            this.xuiButton3.TabIndex = 17;
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
            this.xuiButton5.Location = new System.Drawing.Point(268, 437);
            this.xuiButton5.Name = "xuiButton5";
            this.xuiButton5.Size = new System.Drawing.Size(51, 50);
            this.xuiButton5.TabIndex = 17;
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
            this.xuiButton8.Location = new System.Drawing.Point(268, 360);
            this.xuiButton8.Name = "xuiButton8";
            this.xuiButton8.Size = new System.Drawing.Size(51, 50);
            this.xuiButton8.TabIndex = 17;
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
            this.xuiButton6.Location = new System.Drawing.Point(34, 360);
            this.xuiButton6.Name = "xuiButton6";
            this.xuiButton6.Size = new System.Drawing.Size(51, 50);
            this.xuiButton6.TabIndex = 17;
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
            this.xuiButton4.Location = new System.Drawing.Point(34, 437);
            this.xuiButton4.Name = "xuiButton4";
            this.xuiButton4.Size = new System.Drawing.Size(51, 50);
            this.xuiButton4.TabIndex = 17;
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
            this.xuiButton2.Location = new System.Drawing.Point(34, 283);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(51, 50);
            this.xuiButton2.TabIndex = 17;
            this.xuiButton2.TextColor = System.Drawing.Color.White;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.Location = new System.Drawing.Point(324, 462);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(0, 25);
            this.lbSalary.TabIndex = 0;
            // 
            // lbPhonenum
            // 
            this.lbPhonenum.AutoSize = true;
            this.lbPhonenum.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhonenum.Location = new System.Drawing.Point(324, 385);
            this.lbPhonenum.Name = "lbPhonenum";
            this.lbPhonenum.Size = new System.Drawing.Size(0, 25);
            this.lbPhonenum.TabIndex = 0;
            // 
            // lbIDNo
            // 
            this.lbIDNo.AutoSize = true;
            this.lbIDNo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDNo.Location = new System.Drawing.Point(324, 231);
            this.lbIDNo.Name = "lbIDNo";
            this.lbIDNo.Size = new System.Drawing.Size(0, 25);
            this.lbIDNo.TabIndex = 0;
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Location = new System.Drawing.Point(324, 308);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(0, 25);
            this.lbSex.TabIndex = 0;
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.Location = new System.Drawing.Point(90, 462);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(0, 25);
            this.lbStartDate.TabIndex = 0;
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
            this.xuiButton1.Location = new System.Drawing.Point(34, 206);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(51, 50);
            this.xuiButton1.TabIndex = 17;
            this.xuiButton1.TextColor = System.Drawing.Color.White;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbBirthdate
            // 
            this.lbBirthdate.AutoSize = true;
            this.lbBirthdate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthdate.Location = new System.Drawing.Point(90, 308);
            this.lbBirthdate.Name = "lbBirthdate";
            this.lbBirthdate.Size = new System.Drawing.Size(0, 25);
            this.lbBirthdate.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(325, 437);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Lương";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(325, 360);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "Số điện thoại";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(325, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "CMND";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(91, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(325, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giới tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(91, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày vào làm";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(90, 231);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 25);
            this.lbName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh";
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
            this.xuiButton10.Location = new System.Drawing.Point(268, 129);
            this.xuiButton10.Name = "xuiButton10";
            this.xuiButton10.Size = new System.Drawing.Size(51, 50);
            this.xuiButton10.TabIndex = 17;
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
            this.btBookRoom.Location = new System.Drawing.Point(34, 129);
            this.btBookRoom.Name = "btBookRoom";
            this.btBookRoom.Size = new System.Drawing.Size(51, 50);
            this.btBookRoom.TabIndex = 17;
            this.btBookRoom.TextColor = System.Drawing.Color.White;
            this.btBookRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.Location = new System.Drawing.Point(324, 154);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(0, 25);
            this.lbPosition.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(325, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 19);
            this.label20.TabIndex = 0;
            this.label20.Text = "Chức vụ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(90, 154);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 25);
            this.lbID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel4.Controls.Add(this.btAddStaff);
            this.panel4.Controls.Add(this.pbSearch);
            this.panel4.Controls.Add(this.tbSearch);
            this.panel4.Controls.Add(this.cbSort);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Location = new System.Drawing.Point(4, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(959, 46);
            this.panel4.TabIndex = 11;
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
            this.btAddStaff.Location = new System.Drawing.Point(774, 9);
            this.btAddStaff.Name = "btAddStaff";
            this.btAddStaff.Size = new System.Drawing.Size(177, 29);
            this.btAddStaff.TabIndex = 31;
            this.btAddStaff.TextColor = System.Drawing.Color.White;
            this.btAddStaff.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btAddStaff.Click += new System.EventHandler(this.btAddStaff_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::HotelManagement.Properties.Resources.icSearch;
            this.pbSearch.Location = new System.Drawing.Point(10, 6);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(35, 32);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 29;
            this.pbSearch.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.tbSearch.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tbSearch.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbSearch.IsEnabled = true;
            this.tbSearch.Location = new System.Drawing.Point(50, 13);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Multiline = false;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.Placeholder = true;
            this.tbSearch.PlaceHolderText = "Tìm kiếm";
            this.tbSearch.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbSearch.ReadOnly = false;
            this.tbSearch.Size = new System.Drawing.Size(183, 24);
            this.tbSearch.TabIndex = 30;
            this.tbSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearch.TextBackgroundColor = System.Drawing.SystemColors.Control;
            this.tbSearch.UseSystemPasswordChar = false;
            this.tbSearch.WordWrap = true;
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.ItemHeight = 23;
            this.cbSort.Items.AddRange(new object[] {
            "Lương tăng",
            "Lương giảm",
            "Thâm niên tăng",
            "Thâm niên giảm",
            "Quản lý",
            "Nhân viên"});
            this.cbSort.Location = new System.Drawing.Point(323, 10);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(171, 29);
            this.cbSort.TabIndex = 5;
            this.cbSort.UseSelectable = true;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.panel7.Location = new System.Drawing.Point(244, 9);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 30);
            this.panel7.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(253, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 21);
            this.label19.TabIndex = 1;
            this.label19.Text = "Sắp xếp";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form_Staff";
            this.Size = new System.Drawing.Size(968, 666);
            this.pnToAddItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffImage)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.FlowLayoutPanel pnToAddItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btBookRoom;
        private XanderUI.XUIButton xuiButton3;
        private XanderUI.XUIButton xuiButton2;
        private System.Windows.Forms.Label lbSex;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.Label lbBirthdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIButton xuiButton5;
        private XanderUI.XUIButton xuiButton6;
        private XanderUI.XUIButton xuiButton4;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private XanderUI.XUIButton xuiButton7;
        private XanderUI.XUIButton xuiButton8;
        private System.Windows.Forms.Label lbPhonenum;
        private System.Windows.Forms.Label lbIDNo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroComboBox cbSort;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pbSearch;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbSearch;
        private XanderUI.XUIButton btAddStaff;
        private XanderUI.XUIButton xuiButton10;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label label20;
        private Zeroit.Framework.Labels.ZeroitMultiFormatLabel lbAddress;
        private XanderUI.XUIButton btAccount;
        private XanderUI.XUIButton btChangeStaffInfo;
        private CirclePictureBox staffImage;
        private System.Windows.Forms.Label lbListStaffIsEmpty;
    }
}
