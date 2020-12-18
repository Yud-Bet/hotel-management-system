namespace HotelManagement.UI
{
    partial class Item_Customer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_Customer));
            this.zeroitUltraTextBox1 = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.lbPhonenum = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbIDNO = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.xuiButton6 = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.zeroitShadowPanel1 = new Zeroit.Framework.MiscControls.ZeroitShadowPanel();
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.timerHide = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbBirthdate = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // zeroitUltraTextBox1
            // 
            this.zeroitUltraTextBox1.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.zeroitUltraTextBox1.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.zeroitUltraTextBox1.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.zeroitUltraTextBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.zeroitUltraTextBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.zeroitUltraTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.zeroitUltraTextBox1.IsEnabled = true;
            this.zeroitUltraTextBox1.Location = new System.Drawing.Point(-9, 9);
            this.zeroitUltraTextBox1.MaxLength = 0;
            this.zeroitUltraTextBox1.Multiline = false;
            this.zeroitUltraTextBox1.Name = "zeroitUltraTextBox1";
            this.zeroitUltraTextBox1.PasswordChar = '\0';
            this.zeroitUltraTextBox1.Placeholder = true;
            this.zeroitUltraTextBox1.PlaceHolderText = "";
            this.zeroitUltraTextBox1.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.zeroitUltraTextBox1.ReadOnly = false;
            this.zeroitUltraTextBox1.Size = new System.Drawing.Size(835, 24);
            this.zeroitUltraTextBox1.TabIndex = 0;
            this.zeroitUltraTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.zeroitUltraTextBox1.TextBackgroundColor = System.Drawing.SystemColors.Control;
            this.zeroitUltraTextBox1.UseSystemPasswordChar = false;
            this.zeroitUltraTextBox1.WordWrap = true;
            this.zeroitUltraTextBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseMove);
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pictureBox1);
            this.pnMain.Controls.Add(this.pbRemove);
            this.pnMain.Controls.Add(this.lbRevenue);
            this.pnMain.Controls.Add(this.lbPhonenum);
            this.pnMain.Controls.Add(this.lbID);
            this.pnMain.Controls.Add(this.lbIDNO);
            this.pnMain.Controls.Add(this.lbName);
            this.pnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(815, 30);
            this.pnMain.TabIndex = 1;
            this.pnMain.Click += new System.EventHandler(this.pnMain_Click);
            this.pnMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.icHorizontalArrow;
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pnMain_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseMove);
            // 
            // pbRemove
            // 
            this.pbRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRemove.Image = ((System.Drawing.Image)(resources.GetObject("pbRemove.Image")));
            this.pbRemove.Location = new System.Drawing.Point(791, 6);
            this.pbRemove.Name = "pbRemove";
            this.pbRemove.Size = new System.Drawing.Size(20, 20);
            this.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemove.TabIndex = 27;
            this.pbRemove.TabStop = false;
            this.pbRemove.Click += new System.EventHandler(this.pbRemove_Click);
            this.pbRemove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseMove);
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRevenue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevenue.Location = new System.Drawing.Point(652, 6);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(89, 20);
            this.lbRevenue.TabIndex = 22;
            this.lbRevenue.Text = "1234567890";
            this.lbRevenue.Click += new System.EventHandler(this.pnMain_Click);
            this.lbRevenue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseMove);
            // 
            // lbPhonenum
            // 
            this.lbPhonenum.AutoSize = true;
            this.lbPhonenum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPhonenum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhonenum.Location = new System.Drawing.Point(515, 6);
            this.lbPhonenum.Name = "lbPhonenum";
            this.lbPhonenum.Size = new System.Drawing.Size(89, 20);
            this.lbPhonenum.TabIndex = 23;
            this.lbPhonenum.Text = "1234567890";
            this.lbPhonenum.Click += new System.EventHandler(this.pnMain_Click);
            this.lbPhonenum.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseMove);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(32, 6);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(54, 20);
            this.lbID.TabIndex = 24;
            this.lbID.Text = "Mã KH";
            this.lbID.Click += new System.EventHandler(this.pnMain_Click);
            this.lbID.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseMove);
            // 
            // lbIDNO
            // 
            this.lbIDNO.AutoSize = true;
            this.lbIDNO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbIDNO.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDNO.Location = new System.Drawing.Point(350, 6);
            this.lbIDNO.Name = "lbIDNO";
            this.lbIDNO.Size = new System.Drawing.Size(81, 20);
            this.lbIDNO.TabIndex = 25;
            this.lbIDNO.Text = "123456789";
            this.lbIDNO.Click += new System.EventHandler(this.pnMain_Click);
            this.lbIDNO.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseMove);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(102, 6);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(32, 20);
            this.lbName.TabIndex = 26;
            this.lbName.Text = "Tên";
            this.lbName.Click += new System.EventHandler(this.pnMain_Click);
            this.lbName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseMove);
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
            this.xuiButton3.Location = new System.Drawing.Point(242, 42);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(51, 50);
            this.xuiButton3.TabIndex = 22;
            this.xuiButton3.TextColor = System.Drawing.Color.White;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.xuiButton6.Location = new System.Drawing.Point(405, 42);
            this.xuiButton6.Name = "xuiButton6";
            this.xuiButton6.Size = new System.Drawing.Size(51, 50);
            this.xuiButton6.TabIndex = 23;
            this.xuiButton6.TextColor = System.Drawing.Color.White;
            this.xuiButton6.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.xuiButton2.Location = new System.Drawing.Point(35, 42);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(51, 50);
            this.xuiButton2.TabIndex = 24;
            this.xuiButton2.TextColor = System.Drawing.Color.White;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // zeroitShadowPanel1
            // 
            this.zeroitShadowPanel1.BorderColor = System.Drawing.Color.Empty;
            this.zeroitShadowPanel1.Location = new System.Drawing.Point(5, 35);
            this.zeroitShadowPanel1.Name = "zeroitShadowPanel1";
            this.zeroitShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.zeroitShadowPanel1.Size = new System.Drawing.Size(806, 69);
            this.zeroitShadowPanel1.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.zeroitShadowPanel1.TabIndex = 21;
            // 
            // timerShow
            // 
            this.timerShow.Interval = 17;
            this.timerShow.Tick += new System.EventHandler(this.timerShow_Tick);
            // 
            // timerHide
            // 
            this.timerHide.Interval = 17;
            this.timerHide.Tick += new System.EventHandler(this.timerHide_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Địa chỉ";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Location = new System.Drawing.Point(299, 72);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(41, 20);
            this.lbSex.TabIndex = 28;
            this.lbSex.Text = "Nam";
            // 
            // lbBirthdate
            // 
            this.lbBirthdate.AutoSize = true;
            this.lbBirthdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthdate.Location = new System.Drawing.Point(92, 72);
            this.lbBirthdate.Name = "lbBirthdate";
            this.lbBirthdate.Size = new System.Drawing.Size(85, 20);
            this.lbBirthdate.TabIndex = 28;
            this.lbBirthdate.Text = "12/12/1212";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(462, 72);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(18, 20);
            this.lbAddress.TabIndex = 28;
            this.lbAddress.Text = "...";
            // 
            // Item_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbBirthdate);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xuiButton3);
            this.Controls.Add(this.xuiButton6);
            this.Controls.Add(this.xuiButton2);
            this.Controls.Add(this.zeroitShadowPanel1);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.zeroitUltraTextBox1);
            this.Name = "Item_Customer";
            this.Size = new System.Drawing.Size(815, 103);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Zeroit.Framework.Labels.ZeroitUltraTextBox zeroitUltraTextBox1;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.PictureBox pbRemove;
        private System.Windows.Forms.Label lbRevenue;
        private System.Windows.Forms.Label lbPhonenum;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbIDNO;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private XanderUI.XUIButton xuiButton3;
        private XanderUI.XUIButton xuiButton6;
        private XanderUI.XUIButton xuiButton2;
        private Zeroit.Framework.MiscControls.ZeroitShadowPanel zeroitShadowPanel1;
        private System.Windows.Forms.Timer timerShow;
        private System.Windows.Forms.Timer timerHide;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbBirthdate;
        private System.Windows.Forms.Label lbAddress;
    }
}
