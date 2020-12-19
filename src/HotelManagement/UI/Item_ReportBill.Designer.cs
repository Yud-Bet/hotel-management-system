namespace HotelManagement.UI
{
    partial class Item_ReportBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_ReportBill));
            this.zeroitUltraTextBox1 = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.lbRoomCharge = new Zeroit.Framework.Labels.ZeroitMultiFormatLabel();
            this.lbTotalMoney = new Zeroit.Framework.Labels.ZeroitMultiFormatLabel();
            this.lbServiceCharge = new Zeroit.Framework.Labels.ZeroitMultiFormatLabel();
            this.lbStaffName = new Zeroit.Framework.Labels.ZeroitMultiFormatLabel();
            this.lbRoomReservationID = new Zeroit.Framework.Labels.ZeroitMultiFormatLabel();
            this.lbBillDateCre = new Zeroit.Framework.Labels.ZeroitMultiFormatLabel();
            this.lbBillID = new Zeroit.Framework.Labels.ZeroitMultiFormatLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.zeroitMaterialContextMenuStrip1 = new Zeroit.Framework.MaterialDesign.Controls.ZeroitMaterialContextMenuStrip();
            this.menuItemDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPay = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.zeroitMaterialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zeroitUltraTextBox1
            // 
            this.zeroitUltraTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.zeroitUltraTextBox1.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.zeroitUltraTextBox1.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.zeroitUltraTextBox1.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.zeroitUltraTextBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.zeroitUltraTextBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.zeroitUltraTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.zeroitUltraTextBox1.IsEnabled = true;
            this.zeroitUltraTextBox1.Location = new System.Drawing.Point(0, 9);
            this.zeroitUltraTextBox1.MaxLength = 32767;
            this.zeroitUltraTextBox1.Multiline = false;
            this.zeroitUltraTextBox1.Name = "zeroitUltraTextBox1";
            this.zeroitUltraTextBox1.PasswordChar = '\0';
            this.zeroitUltraTextBox1.Placeholder = true;
            this.zeroitUltraTextBox1.PlaceHolderText = "";
            this.zeroitUltraTextBox1.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.zeroitUltraTextBox1.ReadOnly = false;
            this.zeroitUltraTextBox1.Size = new System.Drawing.Size(913, 24);
            this.zeroitUltraTextBox1.TabIndex = 0;
            this.zeroitUltraTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.zeroitUltraTextBox1.TextBackgroundColor = System.Drawing.SystemColors.Control;
            this.zeroitUltraTextBox1.UseSystemPasswordChar = false;
            this.zeroitUltraTextBox1.WordWrap = true;
            this.zeroitUltraTextBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Item_ReportBill_MouseMove);
            // 
            // lbRoomCharge
            // 
            this.lbRoomCharge.AllowTransparency = true;
            this.lbRoomCharge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomCharge.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbRoomCharge.Location = new System.Drawing.Point(460, 1);
            this.lbRoomCharge.MainText = "RoomCharge";
            this.lbRoomCharge.MainTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbRoomCharge.MainTextPadding = new System.Windows.Forms.Padding(0);
            this.lbRoomCharge.Name = "lbRoomCharge";
            this.lbRoomCharge.Size = new System.Drawing.Size(140, 31);
            this.lbRoomCharge.TabIndex = 8;
            this.lbRoomCharge.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Item_ReportBill_MouseMove);
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AllowTransparency = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMoney.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbTotalMoney.Location = new System.Drawing.Point(740, 1);
            this.lbTotalMoney.MainText = "TotalMoney";
            this.lbTotalMoney.MainTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTotalMoney.MainTextPadding = new System.Windows.Forms.Padding(0);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(140, 31);
            this.lbTotalMoney.TabIndex = 9;
            this.lbTotalMoney.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Item_ReportBill_MouseMove);
            // 
            // lbServiceCharge
            // 
            this.lbServiceCharge.AllowTransparency = true;
            this.lbServiceCharge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServiceCharge.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbServiceCharge.Location = new System.Drawing.Point(600, 1);
            this.lbServiceCharge.MainText = "ServiceCharge";
            this.lbServiceCharge.MainTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbServiceCharge.MainTextPadding = new System.Windows.Forms.Padding(0);
            this.lbServiceCharge.Name = "lbServiceCharge";
            this.lbServiceCharge.Size = new System.Drawing.Size(140, 31);
            this.lbServiceCharge.TabIndex = 10;
            this.lbServiceCharge.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Item_ReportBill_MouseMove);
            // 
            // lbStaffName
            // 
            this.lbStaffName.AllowTransparency = true;
            this.lbStaffName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbStaffName.Location = new System.Drawing.Point(260, 1);
            this.lbStaffName.MainText = "StaffName";
            this.lbStaffName.MainTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbStaffName.MainTextPadding = new System.Windows.Forms.Padding(0);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(200, 31);
            this.lbStaffName.TabIndex = 11;
            this.lbStaffName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Item_ReportBill_MouseMove);
            // 
            // lbRoomReservationID
            // 
            this.lbRoomReservationID.AllowTransparency = true;
            this.lbRoomReservationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomReservationID.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbRoomReservationID.Location = new System.Drawing.Point(190, 1);
            this.lbRoomReservationID.MainText = "RRID";
            this.lbRoomReservationID.MainTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRoomReservationID.MainTextPadding = new System.Windows.Forms.Padding(0);
            this.lbRoomReservationID.Name = "lbRoomReservationID";
            this.lbRoomReservationID.Size = new System.Drawing.Size(70, 31);
            this.lbRoomReservationID.TabIndex = 12;
            this.lbRoomReservationID.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Item_ReportBill_MouseMove);
            // 
            // lbBillDateCre
            // 
            this.lbBillDateCre.AllowTransparency = true;
            this.lbBillDateCre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBillDateCre.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbBillDateCre.Location = new System.Drawing.Point(70, 1);
            this.lbBillDateCre.MainText = "BillDate";
            this.lbBillDateCre.MainTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbBillDateCre.MainTextPadding = new System.Windows.Forms.Padding(0);
            this.lbBillDateCre.Name = "lbBillDateCre";
            this.lbBillDateCre.Size = new System.Drawing.Size(120, 31);
            this.lbBillDateCre.TabIndex = 13;
            this.lbBillDateCre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Item_ReportBill_MouseMove);
            // 
            // lbBillID
            // 
            this.lbBillID.AllowTransparency = true;
            this.lbBillID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBillID.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbBillID.Location = new System.Drawing.Point(0, 1);
            this.lbBillID.MainText = "BillID";
            this.lbBillID.MainTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbBillID.MainTextPadding = new System.Windows.Forms.Padding(0);
            this.lbBillID.Name = "lbBillID";
            this.lbBillID.Size = new System.Drawing.Size(70, 31);
            this.lbBillID.TabIndex = 14;
            this.lbBillID.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Item_ReportBill_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.pbMenu);
            this.panel1.Controls.Add(this.lbRoomCharge);
            this.panel1.Controls.Add(this.lbServiceCharge);
            this.panel1.Controls.Add(this.lbTotalMoney);
            this.panel1.Controls.Add(this.lbStaffName);
            this.panel1.Controls.Add(this.lbRoomReservationID);
            this.panel1.Controls.Add(this.lbBillDateCre);
            this.panel1.Controls.Add(this.lbBillID);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 30);
            this.panel1.TabIndex = 15;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Item_ReportBill_MouseMove);
            // 
            // pbMenu
            // 
            this.pbMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(882, 3);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(25, 25);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu.TabIndex = 15;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            this.pbMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Item_ReportBill_MouseMove);
            // 
            // zeroitMaterialContextMenuStrip1
            // 
            this.zeroitMaterialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.zeroitMaterialContextMenuStrip1.Depth = 0;
            this.zeroitMaterialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDetail,
            this.menuItemPay});
            this.zeroitMaterialContextMenuStrip1.MouseState = Zeroit.Framework.MaterialDesign.MouseState.HOVER;
            this.zeroitMaterialContextMenuStrip1.Name = "zeroitMaterialContextMenuStrip1";
            this.zeroitMaterialContextMenuStrip1.Size = new System.Drawing.Size(138, 48);
            // 
            // menuItemDetail
            // 
            this.menuItemDetail.Name = "menuItemDetail";
            this.menuItemDetail.Size = new System.Drawing.Size(137, 22);
            this.menuItemDetail.Text = "Xem chi tiết";
            // 
            // menuItemPay
            // 
            this.menuItemPay.Name = "menuItemPay";
            this.menuItemPay.Size = new System.Drawing.Size(137, 22);
            this.menuItemPay.Text = "Thanh toán";
            // 
            // Item_ReportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zeroitUltraTextBox1);
            this.Name = "Item_ReportBill";
            this.Size = new System.Drawing.Size(907, 33);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Item_ReportBill_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.zeroitMaterialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Zeroit.Framework.Labels.ZeroitUltraTextBox zeroitUltraTextBox1;
        private Zeroit.Framework.Labels.ZeroitMultiFormatLabel lbRoomCharge;
        private Zeroit.Framework.Labels.ZeroitMultiFormatLabel lbTotalMoney;
        private Zeroit.Framework.Labels.ZeroitMultiFormatLabel lbServiceCharge;
        private Zeroit.Framework.Labels.ZeroitMultiFormatLabel lbStaffName;
        private Zeroit.Framework.Labels.ZeroitMultiFormatLabel lbRoomReservationID;
        private Zeroit.Framework.Labels.ZeroitMultiFormatLabel lbBillDateCre;
        private Zeroit.Framework.Labels.ZeroitMultiFormatLabel lbBillID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbMenu;
        private Zeroit.Framework.MaterialDesign.Controls.ZeroitMaterialContextMenuStrip zeroitMaterialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemPay;
    }
}
