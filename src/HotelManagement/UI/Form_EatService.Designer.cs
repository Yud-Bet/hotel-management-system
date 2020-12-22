namespace HotelManagement.UI
{
    partial class Form_EatService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EatService));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnBookingInfo = new System.Windows.Forms.Panel();
            this.pnServicesList = new System.Windows.Forms.FlowLayoutPanel();
            this.zeroitPictureBox1 = new Zeroit.Framework.MiscControls.ZeroitPictureBox();
            this.tbSearch = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnSelectedServices = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btPay = new XanderUI.XUIButton();
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
            this.bill = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogBill = new System.Windows.Forms.PrintPreviewDialog();
            this.StatusLabel = new Zeroit.Framework.MiscControls.ZeroitLabel();
            this.pnBookingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zeroitPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.lbTitle.Size = new System.Drawing.Size(376, 61);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Dịch Vụ Ăn Uống";
            // 
            // pnBookingInfo
            // 
            this.pnBookingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnBookingInfo.Controls.Add(this.pnServicesList);
            this.pnBookingInfo.Controls.Add(this.zeroitPictureBox1);
            this.pnBookingInfo.Controls.Add(this.tbSearch);
            this.pnBookingInfo.Controls.Add(this.label23);
            this.pnBookingInfo.Controls.Add(this.panel7);
            this.pnBookingInfo.Location = new System.Drawing.Point(17, 97);
            this.pnBookingInfo.Name = "pnBookingInfo";
            this.pnBookingInfo.Size = new System.Drawing.Size(493, 550);
            this.pnBookingInfo.TabIndex = 14;
            // 
            // pnServicesList
            // 
            this.pnServicesList.AutoScroll = true;
            this.pnServicesList.Location = new System.Drawing.Point(3, 47);
            this.pnServicesList.Name = "pnServicesList";
            this.pnServicesList.Size = new System.Drawing.Size(485, 487);
            this.pnServicesList.TabIndex = 6;
            // 
            // zeroitPictureBox1
            // 
            this.zeroitPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.zeroitPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("zeroitPictureBox1.Image")));
            this.zeroitPictureBox1.Location = new System.Drawing.Point(466, 5);
            this.zeroitPictureBox1.Name = "zeroitPictureBox1";
            this.zeroitPictureBox1.Size = new System.Drawing.Size(22, 24);
            this.zeroitPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zeroitPictureBox1.TabIndex = 4;
            this.zeroitPictureBox1.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.tbSearch.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tbSearch.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.IsEnabled = true;
            this.tbSearch.Location = new System.Drawing.Point(315, 9);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Multiline = false;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.Placeholder = true;
            this.tbSearch.PlaceHolderText = "Tìm kiếm";
            this.tbSearch.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbSearch.ReadOnly = false;
            this.tbSearch.Size = new System.Drawing.Size(175, 24);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearch.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbSearch.UseSystemPasswordChar = false;
            this.tbSearch.WordWrap = true;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(3, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(185, 25);
            this.label23.TabIndex = 2;
            this.label23.Text = "Danh sách mặt hàng";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.panel7.Location = new System.Drawing.Point(7, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 3);
            this.panel7.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnSelectedServices);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(517, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 361);
            this.panel1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mặt hàng";
            // 
            // pnSelectedServices
            // 
            this.pnSelectedServices.AutoScroll = true;
            this.pnSelectedServices.Location = new System.Drawing.Point(3, 74);
            this.pnSelectedServices.Name = "pnSelectedServices";
            this.pnSelectedServices.Size = new System.Drawing.Size(428, 284);
            this.pnSelectedServices.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách đã chọn";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(3, 72);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel5.Controls.Add(this.btPay);
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
            this.panel5.Location = new System.Drawing.Point(517, 464);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(433, 183);
            this.panel5.TabIndex = 16;
            // 
            // btPay
            // 
            this.btPay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btPay.ButtonImage = global::HotelManagement.Properties.Resources.icPayment;
            this.btPay.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btPay.ButtonText = "Thanh toán";
            this.btPay.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(161)))));
            this.btPay.ClickTextColor = System.Drawing.Color.White;
            this.btPay.CornerRadius = 5;
            this.btPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPay.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPay.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btPay.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btPay.HoverTextColor = System.Drawing.Color.White;
            this.btPay.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btPay.Location = new System.Drawing.Point(256, 111);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(167, 38);
            this.btPay.TabIndex = 17;
            this.btPay.TextColor = System.Drawing.Color.White;
            this.btPay.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btPay.Click += new System.EventHandler(this.btPay_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btAdd.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btAdd.ButtonImage")));
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
            this.btAdd.Location = new System.Drawing.Point(256, 67);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(167, 38);
            this.btAdd.TabIndex = 17;
            this.btAdd.TextColor = System.Drawing.Color.White;
            this.btAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbRoomSelection
            // 
            this.cbRoomSelection.FormattingEnabled = true;
            this.cbRoomSelection.ItemHeight = 23;
            this.cbRoomSelection.Location = new System.Drawing.Point(256, 31);
            this.cbRoomSelection.Name = "cbRoomSelection";
            this.cbRoomSelection.Size = new System.Drawing.Size(167, 29);
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
            this.label9.Location = new System.Drawing.Point(252, 34);
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
            // bill
            // 
            this.bill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.bill_PrintPage);
            // 
            // printPreviewDialogBill
            // 
            this.printPreviewDialogBill.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogBill.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogBill.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogBill.Enabled = true;
            this.printPreviewDialogBill.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogBill.Icon")));
            this.printPreviewDialogBill.Name = "printPreviewDialogBill";
            this.printPreviewDialogBill.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.StatusLabel.Location = new System.Drawing.Point(17, 650);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 17;
            // 
            // Form_EatService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnBookingInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form_EatService";
            this.Size = new System.Drawing.Size(968, 665);
            this.Load += new System.EventHandler(this.Form_EatService_Load);
            this.pnBookingInfo.ResumeLayout(false);
            this.pnBookingInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zeroitPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnBookingInfo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel7;
        private Zeroit.Framework.MiscControls.ZeroitPictureBox zeroitPictureBox1;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel pnServicesList;
        private System.Windows.Forms.FlowLayoutPanel pnSelectedServices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalPayable;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cbRoomSelection;
        private System.Windows.Forms.Label label9;
        private XanderUI.XUIButton btAdd;
        private XanderUI.XUIButton btPay;
        private System.Drawing.Printing.PrintDocument bill;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogBill;
        private Zeroit.Framework.MiscControls.ZeroitLabel StatusLabel;
    }
}
