namespace HotelManagement.UI
{
    partial class Form_EditAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btCancel = new XanderUI.XUIButton();
            this.btSave = new XanderUI.XUIButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnAccount = new System.Windows.Forms.Panel();
            this.pbShowHidePass = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPass = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbUsername = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pnAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHidePass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(5, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 303);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btCancel);
            this.flowLayoutPanel1.Controls.Add(this.btSave);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 264);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(381, 36);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.btCancel.Location = new System.Drawing.Point(279, 3);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(99, 29);
            this.btCancel.TabIndex = 0;
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
            this.btSave.Location = new System.Drawing.Point(174, 3);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(99, 29);
            this.btSave.TabIndex = 0;
            this.btSave.TextColor = System.Drawing.Color.White;
            this.btSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pnAccount);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 7);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(377, 254);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // pnAccount
            // 
            this.pnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnAccount.Controls.Add(this.pbShowHidePass);
            this.pnAccount.Controls.Add(this.label2);
            this.pnAccount.Controls.Add(this.lbTitle);
            this.pnAccount.Controls.Add(this.label1);
            this.pnAccount.Controls.Add(this.tbPass);
            this.pnAccount.Controls.Add(this.tbUsername);
            this.pnAccount.Controls.Add(this.xuiButton2);
            this.pnAccount.Controls.Add(this.xuiButton1);
            this.pnAccount.Location = new System.Drawing.Point(3, 3);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(371, 248);
            this.pnAccount.TabIndex = 0;
            // 
            // pbShowHidePass
            // 
            this.pbShowHidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowHidePass.Image = global::HotelManagement.Properties.Resources.icShowPass;
            this.pbShowHidePass.Location = new System.Drawing.Point(335, 188);
            this.pbShowHidePass.Name = "pbShowHidePass";
            this.pbShowHidePass.Size = new System.Drawing.Size(25, 25);
            this.pbShowHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowHidePass.TabIndex = 21;
            this.pbShowHidePass.TabStop = false;
            this.pbShowHidePass.Click += new System.EventHandler(this.pbShowHidePass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên đăng nhập";
            // 
            // tbPass
            // 
            this.tbPass.DisabledStringColor = System.Drawing.Color.Black;
            this.tbPass.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tbPass.EnabledUnFocusedColor = System.Drawing.Color.Silver;
            this.tbPass.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbPass.ForeColor = System.Drawing.Color.Black;
            this.tbPass.IsEnabled = true;
            this.tbPass.Location = new System.Drawing.Point(60, 189);
            this.tbPass.MaxLength = 32767;
            this.tbPass.Multiline = false;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '•';
            this.tbPass.Placeholder = true;
            this.tbPass.PlaceHolderText = "";
            this.tbPass.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbPass.ReadOnly = false;
            this.tbPass.Size = new System.Drawing.Size(300, 24);
            this.tbPass.TabIndex = 0;
            this.tbPass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPass.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbPass.UseSystemPasswordChar = false;
            this.tbPass.WordWrap = true;
            // 
            // tbUsername
            // 
            this.tbUsername.DisabledStringColor = System.Drawing.Color.Black;
            this.tbUsername.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tbUsername.EnabledUnFocusedColor = System.Drawing.Color.Silver;
            this.tbUsername.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbUsername.ForeColor = System.Drawing.Color.Black;
            this.tbUsername.IsEnabled = true;
            this.tbUsername.Location = new System.Drawing.Point(60, 90);
            this.tbUsername.MaxLength = 32767;
            this.tbUsername.Multiline = false;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.Placeholder = true;
            this.tbUsername.PlaceHolderText = "";
            this.tbUsername.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbUsername.ReadOnly = false;
            this.tbUsername.Size = new System.Drawing.Size(300, 24);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUsername.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbUsername.UseSystemPasswordChar = false;
            this.tbUsername.WordWrap = true;
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
            this.xuiButton2.Location = new System.Drawing.Point(3, 64);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(51, 50);
            this.xuiButton2.TabIndex = 18;
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
            this.xuiButton1.Location = new System.Drawing.Point(3, 163);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(51, 50);
            this.xuiButton1.TabIndex = 18;
            this.xuiButton1.TextColor = System.Drawing.Color.White;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbTitle.Location = new System.Drawing.Point(8, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(166, 25);
            this.lbTitle.TabIndex = 20;
            this.lbTitle.Text = "Thông tin tài khoản";
            // 
            // Form_EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 346);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form_EditAccount";
            this.Resizable = false;
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pnAccount.ResumeLayout(false);
            this.pnAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHidePass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel pnAccount;
        private XanderUI.XUIButton btSave;
        private XanderUI.XUIButton btCancel;
        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton xuiButton1;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbPass;
        private System.Windows.Forms.PictureBox pbShowHidePass;
        private System.Windows.Forms.Label lbTitle;
    }
}