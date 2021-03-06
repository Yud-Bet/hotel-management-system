﻿namespace HotelManagement.UI
{
    partial class Form_AddEditRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddEditRoom));
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btAddRoom = new XanderUI.XUIButton();
            this.btSave = new XanderUI.XUIButton();
            this.tbRoomPrice = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbRoomID = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.tbRoomSize = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.pnSignle_Dou = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtSingle = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtDouble = new MaterialSkin.Controls.MaterialRadioButton();
            this.pnVip_Nor = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtVip = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtNor = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbVND = new System.Windows.Forms.Label();
            this.lbRoomPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbM2 = new System.Windows.Forms.Label();
            this.lbRoomCount = new System.Windows.Forms.Label();
            this.lbRoomSize = new System.Windows.Forms.Label();
            this.lbRoomType = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnSignle_Dou.SuspendLayout();
            this.pnVip_Nor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Controls.Add(this.tbRoomPrice);
            this.panel4.Controls.Add(this.tbRoomID);
            this.panel4.Controls.Add(this.tbRoomSize);
            this.panel4.Controls.Add(this.pnSignle_Dou);
            this.panel4.Controls.Add(this.pnVip_Nor);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.lbVND);
            this.panel4.Controls.Add(this.lbRoomPrice);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lbM2);
            this.panel4.Controls.Add(this.lbRoomCount);
            this.panel4.Controls.Add(this.lbRoomSize);
            this.panel4.Controls.Add(this.lbRoomType);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Location = new System.Drawing.Point(5, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(537, 271);
            this.panel4.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btAddRoom);
            this.flowLayoutPanel1.Controls.Add(this.btSave);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(363, 222);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(164, 38);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btAddRoom
            // 
            this.btAddRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btAddRoom.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btAddRoom.ButtonImage")));
            this.btAddRoom.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btAddRoom.ButtonText = "Thêm Phòng";
            this.btAddRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btAddRoom.ClickTextColor = System.Drawing.Color.White;
            this.btAddRoom.CornerRadius = 5;
            this.btAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddRoom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btAddRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btAddRoom.HoverTextColor = System.Drawing.Color.White;
            this.btAddRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btAddRoom.Location = new System.Drawing.Point(5, 3);
            this.btAddRoom.Name = "btAddRoom";
            this.btAddRoom.Size = new System.Drawing.Size(156, 33);
            this.btAddRoom.TabIndex = 17;
            this.btAddRoom.TextColor = System.Drawing.Color.White;
            this.btAddRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btAddRoom.Click += new System.EventHandler(this.btAddRoom_Click);
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
            this.btSave.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btSave.HoverTextColor = System.Drawing.Color.White;
            this.btSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btSave.Location = new System.Drawing.Point(85, 42);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(76, 33);
            this.btSave.TabIndex = 18;
            this.btSave.TextColor = System.Drawing.Color.White;
            this.btSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbRoomPrice
            // 
            this.tbRoomPrice.DisabledStringColor = System.Drawing.Color.Black;
            this.tbRoomPrice.DisabledUnFocusedColor = System.Drawing.Color.Silver;
            this.tbRoomPrice.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbRoomPrice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.tbRoomPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbRoomPrice.ForeColor = System.Drawing.Color.Black;
            this.tbRoomPrice.IsEnabled = true;
            this.tbRoomPrice.Location = new System.Drawing.Point(108, 185);
            this.tbRoomPrice.MaxLength = 32767;
            this.tbRoomPrice.Multiline = false;
            this.tbRoomPrice.Name = "tbRoomPrice";
            this.tbRoomPrice.PasswordChar = '\0';
            this.tbRoomPrice.Placeholder = true;
            this.tbRoomPrice.PlaceHolderText = "";
            this.tbRoomPrice.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbRoomPrice.ReadOnly = false;
            this.tbRoomPrice.Size = new System.Drawing.Size(362, 24);
            this.tbRoomPrice.TabIndex = 11;
            this.tbRoomPrice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRoomPrice.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbRoomPrice.UseSystemPasswordChar = false;
            this.tbRoomPrice.WordWrap = true;
            // 
            // tbRoomID
            // 
            this.tbRoomID.DisabledStringColor = System.Drawing.Color.Black;
            this.tbRoomID.DisabledUnFocusedColor = System.Drawing.Color.Silver;
            this.tbRoomID.Enabled = false;
            this.tbRoomID.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbRoomID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.tbRoomID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbRoomID.ForeColor = System.Drawing.Color.Black;
            this.tbRoomID.IsEnabled = true;
            this.tbRoomID.Location = new System.Drawing.Point(108, 47);
            this.tbRoomID.MaxLength = 32767;
            this.tbRoomID.Multiline = false;
            this.tbRoomID.Name = "tbRoomID";
            this.tbRoomID.PasswordChar = '\0';
            this.tbRoomID.Placeholder = true;
            this.tbRoomID.PlaceHolderText = "";
            this.tbRoomID.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbRoomID.ReadOnly = false;
            this.tbRoomID.Size = new System.Drawing.Size(362, 24);
            this.tbRoomID.TabIndex = 12;
            this.tbRoomID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRoomID.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbRoomID.UseSystemPasswordChar = false;
            this.tbRoomID.WordWrap = true;
            // 
            // tbRoomSize
            // 
            this.tbRoomSize.DisabledStringColor = System.Drawing.Color.Black;
            this.tbRoomSize.DisabledUnFocusedColor = System.Drawing.Color.Silver;
            this.tbRoomSize.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbRoomSize.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.tbRoomSize.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbRoomSize.ForeColor = System.Drawing.Color.Black;
            this.tbRoomSize.IsEnabled = true;
            this.tbRoomSize.Location = new System.Drawing.Point(108, 134);
            this.tbRoomSize.MaxLength = 32767;
            this.tbRoomSize.Multiline = false;
            this.tbRoomSize.Name = "tbRoomSize";
            this.tbRoomSize.PasswordChar = '\0';
            this.tbRoomSize.Placeholder = true;
            this.tbRoomSize.PlaceHolderText = "";
            this.tbRoomSize.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbRoomSize.ReadOnly = false;
            this.tbRoomSize.Size = new System.Drawing.Size(362, 24);
            this.tbRoomSize.TabIndex = 12;
            this.tbRoomSize.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRoomSize.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbRoomSize.UseSystemPasswordChar = false;
            this.tbRoomSize.WordWrap = true;
            // 
            // pnSignle_Dou
            // 
            this.pnSignle_Dou.Controls.Add(this.rbtSingle);
            this.pnSignle_Dou.Controls.Add(this.rbtDouble);
            this.pnSignle_Dou.Location = new System.Drawing.Point(267, 83);
            this.pnSignle_Dou.Name = "pnSignle_Dou";
            this.pnSignle_Dou.Size = new System.Drawing.Size(144, 31);
            this.pnSignle_Dou.TabIndex = 9;
            // 
            // rbtSingle
            // 
            this.rbtSingle.AutoSize = true;
            this.rbtSingle.Checked = true;
            this.rbtSingle.Depth = 0;
            this.rbtSingle.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtSingle.Location = new System.Drawing.Point(0, 0);
            this.rbtSingle.Margin = new System.Windows.Forms.Padding(0);
            this.rbtSingle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtSingle.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtSingle.Name = "rbtSingle";
            this.rbtSingle.Ripple = true;
            this.rbtSingle.Size = new System.Drawing.Size(54, 30);
            this.rbtSingle.TabIndex = 8;
            this.rbtSingle.TabStop = true;
            this.rbtSingle.Text = "Đơn";
            this.rbtSingle.UseVisualStyleBackColor = true;
            // 
            // rbtDouble
            // 
            this.rbtDouble.AutoSize = true;
            this.rbtDouble.Depth = 0;
            this.rbtDouble.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtDouble.Location = new System.Drawing.Point(54, 0);
            this.rbtDouble.Margin = new System.Windows.Forms.Padding(0);
            this.rbtDouble.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtDouble.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtDouble.Name = "rbtDouble";
            this.rbtDouble.Ripple = true;
            this.rbtDouble.Size = new System.Drawing.Size(49, 30);
            this.rbtDouble.TabIndex = 9;
            this.rbtDouble.TabStop = true;
            this.rbtDouble.Text = "Đôi";
            this.rbtDouble.UseVisualStyleBackColor = true;
            // 
            // pnVip_Nor
            // 
            this.pnVip_Nor.Controls.Add(this.rbtVip);
            this.pnVip_Nor.Controls.Add(this.rbtNor);
            this.pnVip_Nor.Location = new System.Drawing.Point(121, 83);
            this.pnVip_Nor.Name = "pnVip_Nor";
            this.pnVip_Nor.Size = new System.Drawing.Size(131, 31);
            this.pnVip_Nor.TabIndex = 10;
            // 
            // rbtVip
            // 
            this.rbtVip.AutoSize = true;
            this.rbtVip.Depth = 0;
            this.rbtVip.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtVip.Location = new System.Drawing.Point(0, 0);
            this.rbtVip.Margin = new System.Windows.Forms.Padding(0);
            this.rbtVip.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtVip.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtVip.Name = "rbtVip";
            this.rbtVip.Ripple = true;
            this.rbtVip.Size = new System.Drawing.Size(49, 30);
            this.rbtVip.TabIndex = 7;
            this.rbtVip.TabStop = true;
            this.rbtVip.Text = "Vip";
            this.rbtVip.UseVisualStyleBackColor = true;
            // 
            // rbtNor
            // 
            this.rbtNor.AutoSize = true;
            this.rbtNor.Checked = true;
            this.rbtNor.Depth = 0;
            this.rbtNor.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtNor.Location = new System.Drawing.Point(49, 0);
            this.rbtNor.Margin = new System.Windows.Forms.Padding(0);
            this.rbtNor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtNor.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtNor.Name = "rbtNor";
            this.rbtNor.Ripple = true;
            this.rbtNor.Size = new System.Drawing.Size(77, 30);
            this.rbtNor.TabIndex = 7;
            this.rbtNor.TabStop = true;
            this.rbtNor.Text = "Thường";
            this.rbtNor.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(8, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 3);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.panel5.Location = new System.Drawing.Point(257, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 30);
            this.panel5.TabIndex = 3;
            // 
            // lbVND
            // 
            this.lbVND.AutoSize = true;
            this.lbVND.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbVND.ForeColor = System.Drawing.Color.Black;
            this.lbVND.Location = new System.Drawing.Point(476, 186);
            this.lbVND.Name = "lbVND";
            this.lbVND.Size = new System.Drawing.Size(46, 23);
            this.lbVND.TabIndex = 2;
            this.lbVND.Text = "VNĐ";
            // 
            // lbRoomPrice
            // 
            this.lbRoomPrice.AutoSize = true;
            this.lbRoomPrice.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbRoomPrice.ForeColor = System.Drawing.Color.Black;
            this.lbRoomPrice.Location = new System.Drawing.Point(3, 183);
            this.lbRoomPrice.Name = "lbRoomPrice";
            this.lbRoomPrice.Size = new System.Drawing.Size(75, 25);
            this.lbRoomPrice.TabIndex = 2;
            this.lbRoomPrice.Text = "Đơn giá";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(495, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "2";
            // 
            // lbM2
            // 
            this.lbM2.AutoSize = true;
            this.lbM2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbM2.ForeColor = System.Drawing.Color.Black;
            this.lbM2.Location = new System.Drawing.Point(476, 135);
            this.lbM2.Name = "lbM2";
            this.lbM2.Size = new System.Drawing.Size(25, 23);
            this.lbM2.TabIndex = 2;
            this.lbM2.Text = "m";
            // 
            // lbRoomCount
            // 
            this.lbRoomCount.AutoSize = true;
            this.lbRoomCount.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbRoomCount.ForeColor = System.Drawing.Color.Black;
            this.lbRoomCount.Location = new System.Drawing.Point(3, 43);
            this.lbRoomCount.Name = "lbRoomCount";
            this.lbRoomCount.Size = new System.Drawing.Size(91, 25);
            this.lbRoomCount.TabIndex = 2;
            this.lbRoomCount.Text = "Số phòng";
            // 
            // lbRoomSize
            // 
            this.lbRoomSize.AutoSize = true;
            this.lbRoomSize.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbRoomSize.ForeColor = System.Drawing.Color.Black;
            this.lbRoomSize.Location = new System.Drawing.Point(3, 132);
            this.lbRoomSize.Name = "lbRoomSize";
            this.lbRoomSize.Size = new System.Drawing.Size(81, 25);
            this.lbRoomSize.TabIndex = 2;
            this.lbRoomSize.Text = "Diện tích";
            // 
            // lbRoomType
            // 
            this.lbRoomType.AutoSize = true;
            this.lbRoomType.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbRoomType.ForeColor = System.Drawing.Color.Black;
            this.lbRoomType.Location = new System.Drawing.Point(3, 84);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(102, 25);
            this.lbRoomType.TabIndex = 2;
            this.lbRoomType.Text = "Loại phòng";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(159, 28);
            this.label19.TabIndex = 2;
            this.label19.Text = "Thông tin phòng";
            // 
            // Form_AddEditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 311);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(547, 319);
            this.Movable = false;
            this.Name = "Form_AddEditRoom";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AddEditRoom_FormClosing);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnSignle_Dou.ResumeLayout(false);
            this.pnSignle_Dou.PerformLayout();
            this.pnVip_Nor.ResumeLayout(false);
            this.pnVip_Nor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbVND;
        private System.Windows.Forms.Label lbRoomPrice;
        private System.Windows.Forms.Label lbM2;
        private System.Windows.Forms.Label lbRoomCount;
        private System.Windows.Forms.Label lbRoomSize;
        private System.Windows.Forms.Label lbRoomType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private XanderUI.XUIButton btAddRoom;
        private XanderUI.XUIButton btSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnSignle_Dou;
        private MaterialSkin.Controls.MaterialRadioButton rbtSingle;
        private MaterialSkin.Controls.MaterialRadioButton rbtDouble;
        private System.Windows.Forms.FlowLayoutPanel pnVip_Nor;
        private MaterialSkin.Controls.MaterialRadioButton rbtVip;
        private MaterialSkin.Controls.MaterialRadioButton rbtNor;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbRoomPrice;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbRoomID;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbRoomSize;
        private System.Windows.Forms.Panel panel1;
    }
}