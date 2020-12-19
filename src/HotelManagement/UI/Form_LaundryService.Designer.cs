namespace HotelManagement.UI
{
    partial class Form_LaundryService
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any 
        /// 
        /// 
        /// 
        /// 
        /// being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LaundryService));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btAdd = new XanderUI.XUIButton();
            this.cbRoomSelection = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotalPayable = new System.Windows.Forms.Label();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnItem = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIronPrice = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btItemIron = new Zeroit.Framework.MiscControls.ZeroitRectShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLaundryPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btItemLaundry = new Zeroit.Framework.MiscControls.ZeroitRectShadowPanel();
            this.StatusLabel = new Zeroit.Framework.MiscControls.ZeroitLabel();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel2.TabIndex = 7;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(3, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(339, 61);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Dịch Vụ Giặt Ủi";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel5.Controls.Add(this.btAdd);
            this.panel5.Controls.Add(this.cbRoomSelection);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.lbDiscount);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.lbTotalPayable);
            this.panel5.Controls.Add(this.lbTotalMoney);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Location = new System.Drawing.Point(387, 362);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(433, 176);
            this.panel5.TabIndex = 18;
            // 
            // btAdd
            // 
            this.btAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btAdd.ButtonImage = global::HotelManagement.Properties.Resources.icPayment;
            this.btAdd.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btAdd.ButtonText = "Thêm";
            this.btAdd.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(161)))));
            this.btAdd.ClickTextColor = System.Drawing.Color.White;
            this.btAdd.CornerRadius = 5;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btAdd.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btAdd.HoverTextColor = System.Drawing.Color.White;
            this.btAdd.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btAdd.Location = new System.Drawing.Point(271, 105);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(115, 50);
            this.btAdd.TabIndex = 17;
            this.btAdd.TextColor = System.Drawing.Color.White;
            this.btAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbRoomSelection
            // 
            this.cbRoomSelection.FormattingEnabled = true;
            this.cbRoomSelection.ItemHeight = 23;
            this.cbRoomSelection.Location = new System.Drawing.Point(271, 70);
            this.cbRoomSelection.Name = "cbRoomSelection";
            this.cbRoomSelection.Size = new System.Drawing.Size(115, 29);
            this.cbRoomSelection.TabIndex = 4;
            this.cbRoomSelection.UseSelectable = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tổng phải trả";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbDiscount.ForeColor = System.Drawing.Color.Black;
            this.lbDiscount.Location = new System.Drawing.Point(131, 82);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(19, 23);
            this.lbDiscount.TabIndex = 2;
            this.lbDiscount.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(172, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giảm giá";
            // 
            // lbTotalPayable
            // 
            this.lbTotalPayable.AutoSize = true;
            this.lbTotalPayable.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbTotalPayable.ForeColor = System.Drawing.Color.Black;
            this.lbTotalPayable.Location = new System.Drawing.Point(131, 122);
            this.lbTotalPayable.Name = "lbTotalPayable";
            this.lbTotalPayable.Size = new System.Drawing.Size(19, 23);
            this.lbTotalPayable.TabIndex = 2;
            this.lbTotalPayable.Text = "0";
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbTotalMoney.ForeColor = System.Drawing.Color.Black;
            this.lbTotalMoney.Location = new System.Drawing.Point(131, 44);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(19, 23);
            this.lbTotalMoney.TabIndex = 2;
            this.lbTotalMoney.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(267, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Chọn phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Thanh toán";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.panel8.Location = new System.Drawing.Point(7, 27);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(150, 3);
            this.panel8.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.pnItem);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(387, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 168);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đơn giá";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(322, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "Số lượng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Tên dịch vụ";
            // 
            // pnItem
            // 
            this.pnItem.AutoScroll = true;
            this.pnItem.Location = new System.Drawing.Point(3, 82);
            this.pnItem.Name = "pnItem";
            this.pnItem.Size = new System.Drawing.Size(428, 78);
            this.pnItem.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Thông tin dịch vụ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(3, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 1);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(7, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 3);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ủi";
            this.label2.Click += new System.EventHandler(this.btItemIron_Click);
            // 
            // lbIronPrice
            // 
            this.lbIronPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbIronPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbIronPrice.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIronPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.lbIronPrice.Location = new System.Drawing.Point(223, 528);
            this.lbIronPrice.Name = "lbIronPrice";
            this.lbIronPrice.Size = new System.Drawing.Size(135, 25);
            this.lbIronPrice.TabIndex = 12;
            this.lbIronPrice.Text = "Price";
            this.lbIronPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbIronPrice.Click += new System.EventHandler(this.btItemIron_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(174, 382);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btItemIron_Click);
            // 
            // btItemIron
            // 
            this.btItemIron.BorderColor = System.Drawing.Color.Black;
            this.btItemIron.Color = System.Drawing.SystemColors.Control;
            this.btItemIron.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btItemIron.Location = new System.Drawing.Point(167, 367);
            this.btItemIron.Name = "btItemIron";
            this.btItemIron.PolygonRadius = 98;
            this.btItemIron.PolygonSides = 3;
            this.btItemIron.PolygonStartingAngle = 90;
            this.btItemIron.Size = new System.Drawing.Size(200, 200);
            this.btItemIron.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btItemIron.TabIndex = 8;
            this.btItemIron.Text = "zeroitRectShadowPanel1";
            this.btItemIron.Transparency = 10F;
            this.btItemIron.ZeroitRectShadowPanelType = Zeroit.Framework.MiscControls.ZeroitRectShadowPanel.TypeOfZeroitRectShadowPanel.Rectangle;
            this.btItemIron.Click += new System.EventHandler(this.btItemIron_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Giặt";
            this.label1.Click += new System.EventHandler(this.btItemLaundry_Click);
            // 
            // lbLaundryPrice
            // 
            this.lbLaundryPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbLaundryPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLaundryPrice.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLaundryPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.lbLaundryPrice.Location = new System.Drawing.Point(223, 308);
            this.lbLaundryPrice.Name = "lbLaundryPrice";
            this.lbLaundryPrice.Size = new System.Drawing.Size(135, 25);
            this.lbLaundryPrice.TabIndex = 12;
            this.lbLaundryPrice.Text = "Price";
            this.lbLaundryPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbLaundryPrice.Click += new System.EventHandler(this.btItemLaundry_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btItemLaundry_Click);
            // 
            // btItemLaundry
            // 
            this.btItemLaundry.BorderColor = System.Drawing.Color.Black;
            this.btItemLaundry.Color = System.Drawing.SystemColors.Control;
            this.btItemLaundry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btItemLaundry.Location = new System.Drawing.Point(167, 146);
            this.btItemLaundry.Name = "btItemLaundry";
            this.btItemLaundry.PolygonRadius = 98;
            this.btItemLaundry.PolygonSides = 3;
            this.btItemLaundry.PolygonStartingAngle = 90;
            this.btItemLaundry.Size = new System.Drawing.Size(200, 200);
            this.btItemLaundry.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btItemLaundry.TabIndex = 8;
            this.btItemLaundry.Text = "zeroitRectShadowPanel1";
            this.btItemLaundry.Transparency = 10F;
            this.btItemLaundry.ZeroitRectShadowPanelType = Zeroit.Framework.MiscControls.ZeroitRectShadowPanel.TypeOfZeroitRectShadowPanel.Rectangle;
            this.btItemLaundry.Click += new System.EventHandler(this.btItemLaundry_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.StatusLabel.Location = new System.Drawing.Point(17, 642);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 19;
            // 
            // Form_LaundryService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbIronPrice);
            this.Controls.Add(this.lbLaundryPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btItemIron);
            this.Controls.Add(this.btItemLaundry);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form_LaundryService";
            this.Size = new System.Drawing.Size(968, 665);
            this.Load += new System.EventHandler(this.Form_LaundryService_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel5;
        private XanderUI.XUIButton btAdd;
        private MetroFramework.Controls.MetroComboBox cbRoomSelection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalPayable;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel pnItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbIronPrice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Zeroit.Framework.MiscControls.ZeroitRectShadowPanel btItemIron;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLaundryPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Zeroit.Framework.MiscControls.ZeroitRectShadowPanel btItemLaundry;
        private Zeroit.Framework.MiscControls.ZeroitLabel StatusLabel;
    }
}
