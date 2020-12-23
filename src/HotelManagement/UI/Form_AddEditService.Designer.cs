namespace HotelManagement.UI
{
    partial class Form_AddEditService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddEditService));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btAddService = new XanderUI.XUIButton();
            this.btSave = new XanderUI.XUIButton();
            this.tbPrice = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbName = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(5, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 228);
            this.panel1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btAddService);
            this.flowLayoutPanel1.Controls.Add(this.btSave);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(342, 177);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(163, 34);
            this.flowLayoutPanel1.TabIndex = 3;
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
            this.btAddService.Location = new System.Drawing.Point(4, 3);
            this.btAddService.Name = "btAddService";
            this.btAddService.Size = new System.Drawing.Size(156, 29);
            this.btAddService.TabIndex = 33;
            this.btAddService.TextColor = System.Drawing.Color.White;
            this.btAddService.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btAddService.Click += new System.EventHandler(this.btAddService_Click);
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
            this.btSave.Location = new System.Drawing.Point(86, 38);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(74, 29);
            this.btSave.TabIndex = 33;
            this.btSave.TextColor = System.Drawing.Color.White;
            this.btSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.tbPrice.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tbPrice.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbPrice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbPrice.IsEnabled = true;
            this.tbPrice.Location = new System.Drawing.Point(233, 133);
            this.tbPrice.MaxLength = 32767;
            this.tbPrice.Multiline = false;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.Placeholder = true;
            this.tbPrice.PlaceHolderText = "";
            this.tbPrice.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbPrice.ReadOnly = false;
            this.tbPrice.Size = new System.Drawing.Size(270, 24);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPrice.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbPrice.UseSystemPasswordChar = false;
            this.tbPrice.WordWrap = true;
            // 
            // tbName
            // 
            this.tbName.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.tbName.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tbName.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbName.IsEnabled = true;
            this.tbName.Location = new System.Drawing.Point(235, 62);
            this.tbName.MaxLength = 32767;
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.Placeholder = true;
            this.tbName.PlaceHolderText = "";
            this.tbName.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbName.ReadOnly = false;
            this.tbName.Size = new System.Drawing.Size(270, 24);
            this.tbName.TabIndex = 1;
            this.tbName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbName.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbName.UseSystemPasswordChar = false;
            this.tbName.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá dịch vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên dịch vụ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_AddEditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 261);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form_AddEditService";
            this.Resizable = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbName;
        private System.Windows.Forms.Label label2;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbPrice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private XanderUI.XUIButton btAddService;
        private XanderUI.XUIButton btSave;
    }
}