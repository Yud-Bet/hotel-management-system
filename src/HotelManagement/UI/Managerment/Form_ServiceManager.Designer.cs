using System.Windows.Forms;

namespace HotelManagement.UI
{
    partial class Form_ServiceManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ServiceManager));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.tbSearch = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btAddService = new XanderUI.XUIButton();
            this.pnToAddItem = new System.Windows.Forms.FlowLayoutPanel();
            this.lbListServiceIsEmpty = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbIronPrice = new System.Windows.Forms.Label();
            this.lbLaundryPrice = new System.Windows.Forms.Label();
            this.lbIronName = new System.Windows.Forms.Label();
            this.lbLaundryName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btItemIron = new Zeroit.Framework.MiscControls.ZeroitRectShadowPanel();
            this.btItemLaundry = new Zeroit.Framework.MiscControls.ZeroitRectShadowPanel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.pnToAddItem.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 61);
            this.panel2.TabIndex = 11;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(3, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(186, 61);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Dịch Vụ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(19, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 46);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ăn, uống";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(678, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 46);
            this.panel3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Giặt, ủi";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel4.Controls.Add(this.pbSearch);
            this.panel4.Controls.Add(this.tbSearch);
            this.panel4.Controls.Add(this.flowLayoutPanel2);
            this.panel4.Controls.Add(this.btAddService);
            this.panel4.Controls.Add(this.pnToAddItem);
            this.panel4.Location = new System.Drawing.Point(19, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(653, 502);
            this.panel4.TabIndex = 12;
            // 
            // pbSearch
            // 
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(25, 7);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(35, 32);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 35;
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
            this.tbSearch.Location = new System.Drawing.Point(65, 14);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Multiline = false;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.Placeholder = true;
            this.tbSearch.PlaceHolderText = "Tìm kiếm";
            this.tbSearch.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbSearch.ReadOnly = false;
            this.tbSearch.Size = new System.Drawing.Size(183, 24);
            this.tbSearch.TabIndex = 36;
            this.tbSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearch.TextBackgroundColor = System.Drawing.SystemColors.Control;
            this.tbSearch.UseSystemPasswordChar = false;
            this.tbSearch.WordWrap = true;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(24, 44);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(600, 1);
            this.flowLayoutPanel2.TabIndex = 34;
            // 
            // btAddService
            // 
            this.btAddService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btAddService.ButtonImage = global::HotelManagement.Properties.Resources.icAddRoom2;
            this.btAddService.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btAddService.ButtonText = "Thêm dịch vụ";
            this.btAddService.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btAddService.ClickTextColor = System.Drawing.Color.White;
            this.btAddService.CornerRadius = 5;
            this.btAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddService.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btAddService.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btAddService.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btAddService.HoverTextColor = System.Drawing.Color.White;
            this.btAddService.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btAddService.Location = new System.Drawing.Point(468, 9);
            this.btAddService.Name = "btAddService";
            this.btAddService.Size = new System.Drawing.Size(156, 29);
            this.btAddService.TabIndex = 32;
            this.btAddService.TextColor = System.Drawing.Color.White;
            this.btAddService.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btAddService.Click += new System.EventHandler(this.btAddService_Click);
            // 
            // pnToAddItem
            // 
            this.pnToAddItem.AutoScroll = true;
            this.pnToAddItem.Controls.Add(this.lbListServiceIsEmpty);
            this.pnToAddItem.Location = new System.Drawing.Point(20, 53);
            this.pnToAddItem.Name = "pnToAddItem";
            this.pnToAddItem.Size = new System.Drawing.Size(630, 432);
            this.pnToAddItem.TabIndex = 0;
            this.pnToAddItem.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnToAddItem_ControlAdded);
            this.pnToAddItem.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnToAddItem_ControlRemoved);
            // 
            // lbListServiceIsEmpty
            // 
            this.lbListServiceIsEmpty.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListServiceIsEmpty.Location = new System.Drawing.Point(3, 0);
            this.lbListServiceIsEmpty.Name = "lbListServiceIsEmpty";
            this.lbListServiceIsEmpty.Size = new System.Drawing.Size(620, 50);
            this.lbListServiceIsEmpty.TabIndex = 1;
            this.lbListServiceIsEmpty.Text = "Chưa có dịch vụ nào!";
            this.lbListServiceIsEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel5.Controls.Add(this.lbIronPrice);
            this.panel5.Controls.Add(this.lbLaundryPrice);
            this.panel5.Controls.Add(this.lbIronName);
            this.panel5.Controls.Add(this.lbLaundryName);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.btItemIron);
            this.panel5.Controls.Add(this.btItemLaundry);
            this.panel5.Location = new System.Drawing.Point(678, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 502);
            this.panel5.TabIndex = 12;
            // 
            // lbIronPrice
            // 
            this.lbIronPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbIronPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbIronPrice.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIronPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.lbIronPrice.Location = new System.Drawing.Point(91, 431);
            this.lbIronPrice.Name = "lbIronPrice";
            this.lbIronPrice.Size = new System.Drawing.Size(135, 25);
            this.lbIronPrice.TabIndex = 19;
            this.lbIronPrice.Text = "Price";
            this.lbIronPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbIronPrice.Click += new System.EventHandler(this.btItemIron_Click);
            // 
            // lbLaundryPrice
            // 
            this.lbLaundryPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbLaundryPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLaundryPrice.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLaundryPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.lbLaundryPrice.Location = new System.Drawing.Point(91, 195);
            this.lbLaundryPrice.Name = "lbLaundryPrice";
            this.lbLaundryPrice.Size = new System.Drawing.Size(135, 25);
            this.lbLaundryPrice.TabIndex = 20;
            this.lbLaundryPrice.Text = "Price";
            this.lbLaundryPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbLaundryPrice.Click += new System.EventHandler(this.btItemLaundry_Click);
            // 
            // lbIronName
            // 
            this.lbIronName.AutoSize = true;
            this.lbIronName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbIronName.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIronName.Location = new System.Drawing.Point(47, 398);
            this.lbIronName.Name = "lbIronName";
            this.lbIronName.Size = new System.Drawing.Size(38, 31);
            this.lbIronName.TabIndex = 17;
            this.lbIronName.Text = "Ủi";
            this.lbIronName.Click += new System.EventHandler(this.btItemIron_Click);
            // 
            // lbLaundryName
            // 
            this.lbLaundryName.AutoSize = true;
            this.lbLaundryName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLaundryName.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLaundryName.Location = new System.Drawing.Point(47, 161);
            this.lbLaundryName.Name = "lbLaundryName";
            this.lbLaundryName.Size = new System.Drawing.Size(58, 31);
            this.lbLaundryName.TabIndex = 18;
            this.lbLaundryName.Text = "Giặt";
            this.lbLaundryName.Click += new System.EventHandler(this.btItemLaundry_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 285);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btItemIron_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btItemLaundry_Click);
            // 
            // btItemIron
            // 
            this.btItemIron.BorderColor = System.Drawing.Color.Black;
            this.btItemIron.Color = System.Drawing.SystemColors.Control;
            this.btItemIron.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btItemIron.Location = new System.Drawing.Point(35, 270);
            this.btItemIron.Name = "btItemIron";
            this.btItemIron.PolygonRadius = 98;
            this.btItemIron.PolygonSides = 3;
            this.btItemIron.PolygonStartingAngle = 90;
            this.btItemIron.Size = new System.Drawing.Size(200, 200);
            this.btItemIron.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btItemIron.TabIndex = 13;
            this.btItemIron.Text = "zeroitRectShadowPanel1";
            this.btItemIron.Transparency = 10F;
            this.btItemIron.ZeroitRectShadowPanelType = Zeroit.Framework.MiscControls.ZeroitRectShadowPanel.TypeOfZeroitRectShadowPanel.Rectangle;
            this.btItemIron.Click += new System.EventHandler(this.btItemIron_Click);
            // 
            // btItemLaundry
            // 
            this.btItemLaundry.BorderColor = System.Drawing.Color.Black;
            this.btItemLaundry.Color = System.Drawing.SystemColors.Control;
            this.btItemLaundry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btItemLaundry.Location = new System.Drawing.Point(35, 33);
            this.btItemLaundry.Name = "btItemLaundry";
            this.btItemLaundry.PolygonRadius = 98;
            this.btItemLaundry.PolygonSides = 3;
            this.btItemLaundry.PolygonStartingAngle = 90;
            this.btItemLaundry.Size = new System.Drawing.Size(200, 200);
            this.btItemLaundry.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btItemLaundry.TabIndex = 14;
            this.btItemLaundry.Text = "zeroitRectShadowPanel1";
            this.btItemLaundry.Transparency = 10F;
            this.btItemLaundry.ZeroitRectShadowPanelType = Zeroit.Framework.MiscControls.ZeroitRectShadowPanel.TypeOfZeroitRectShadowPanel.Rectangle;
            this.btItemLaundry.Click += new System.EventHandler(this.btItemLaundry_Click);
            // 
            // Form_ServiceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form_ServiceManager";
            this.Size = new System.Drawing.Size(968, 665);
            this.Load += new System.EventHandler(this.Form_ServiceManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.pnToAddItem.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel pnToAddItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIronPrice;
        private System.Windows.Forms.Label lbLaundryPrice;
        private System.Windows.Forms.Label lbIronName;
        private System.Windows.Forms.Label lbLaundryName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Zeroit.Framework.MiscControls.ZeroitRectShadowPanel btItemIron;
        private Zeroit.Framework.MiscControls.ZeroitRectShadowPanel btItemLaundry;
        private XanderUI.XUIButton btAddService;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pbSearch;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbSearch;
        private System.Windows.Forms.Label lbListServiceIsEmpty;

        public Label LbIronPrice { get => lbIronPrice; set => lbIronPrice = value; }
        public Label LbLaundryPrice { get => lbLaundryPrice; set => lbLaundryPrice = value; }
        public Label LbIronName { get => lbIronName; set => lbIronName = value; }
        public Label LbLaundryName { get => lbLaundryName; set => lbLaundryName = value; }
    }
}
