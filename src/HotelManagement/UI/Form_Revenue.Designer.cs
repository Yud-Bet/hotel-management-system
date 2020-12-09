namespace HotelManagement.UI
{
    partial class Form_Revenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Revenue));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.cbTypeOfRevenue = new MetroFramework.Controls.MetroComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbRevenueValue = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.barChart = new LiveCharts.WinForms.CartesianChart();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.btExportExcel = new XanderUI.XUIButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.lbTitle.Size = new System.Drawing.Size(255, 61);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Doanh Thu";
            // 
            // cbTypeOfRevenue
            // 
            this.cbTypeOfRevenue.FormattingEnabled = true;
            this.cbTypeOfRevenue.ItemHeight = 23;
            this.cbTypeOfRevenue.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Quý",
            "Năm"});
            this.cbTypeOfRevenue.Location = new System.Drawing.Point(128, 24);
            this.cbTypeOfRevenue.Name = "cbTypeOfRevenue";
            this.cbTypeOfRevenue.Size = new System.Drawing.Size(144, 29);
            this.cbTypeOfRevenue.TabIndex = 8;
            this.cbTypeOfRevenue.UseSelectable = true;
            this.cbTypeOfRevenue.SelectedIndexChanged += new System.EventHandler(this.cbTypeOfRevenue_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.btExportExcel);
            this.panel1.Controls.Add(this.dtEnd);
            this.panel1.Controls.Add(this.dtStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTypeOfRevenue);
            this.panel1.Location = new System.Drawing.Point(9, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 219);
            this.panel1.TabIndex = 9;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(128, 108);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(119, 29);
            this.dtEnd.TabIndex = 10;
            this.dtEnd.ValueChanged += new System.EventHandler(this.cbTypeOfRevenue_SelectedIndexChanged);
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(128, 66);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(119, 29);
            this.dtStart.TabIndex = 10;
            this.dtStart.ValueChanged += new System.EventHandler(this.cbTypeOfRevenue_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Loại doanh thu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.lbRevenueValue);
            this.panel3.Controls.Add(this.lbDate);
            this.panel3.Controls.Add(this.pieChart);
            this.panel3.Location = new System.Drawing.Point(9, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 333);
            this.panel3.TabIndex = 9;
            // 
            // lbRevenueValue
            // 
            this.lbRevenueValue.AutoSize = true;
            this.lbRevenueValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevenueValue.Location = new System.Drawing.Point(144, 293);
            this.lbRevenueValue.Name = "lbRevenueValue";
            this.lbRevenueValue.Size = new System.Drawing.Size(87, 21);
            this.lbRevenueValue.TabIndex = 9;
            this.lbRevenueValue.Text = "giá trị VNĐ";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(8, 293);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(169, 21);
            this.lbDate.TabIndex = 9;
            this.lbDate.Text = "Ngày(Tháng,Quý,Năm)";
            // 
            // pieChart
            // 
            this.pieChart.Location = new System.Drawing.Point(0, 0);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(284, 262);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "pieChart1";
            this.pieChart.Visible = false;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel4.Controls.Add(this.barChart);
            this.panel4.Location = new System.Drawing.Point(299, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(661, 530);
            this.panel4.TabIndex = 9;
            // 
            // barChart
            // 
            this.barChart.Location = new System.Drawing.Point(0, 0);
            this.barChart.Name = "barChart";
            this.barChart.Size = new System.Drawing.Size(661, 530);
            this.barChart.TabIndex = 0;
            this.barChart.Text = "cartesianChart1";
            this.barChart.Visible = false;
            this.barChart.DataClick += new LiveCharts.Events.DataClickHandler(this.barChart_DataClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng doanh thu";
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.AutoSize = true;
            this.lbTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRevenue.Location = new System.Drawing.Point(452, 95);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(22, 25);
            this.lbTotalRevenue.TabIndex = 9;
            this.lbTotalRevenue.Text = "0";
            // 
            // btExportExcel
            // 
            this.btExportExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btExportExcel.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btExportExcel.ButtonImage")));
            this.btExportExcel.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btExportExcel.ButtonText = "Xuất File";
            this.btExportExcel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btExportExcel.ClickTextColor = System.Drawing.Color.White;
            this.btExportExcel.CornerRadius = 5;
            this.btExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExportExcel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btExportExcel.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btExportExcel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btExportExcel.HoverTextColor = System.Drawing.Color.White;
            this.btExportExcel.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btExportExcel.Location = new System.Drawing.Point(8, 152);
            this.btExportExcel.Name = "btExportExcel";
            this.btExportExcel.Size = new System.Drawing.Size(131, 50);
            this.btExportExcel.TabIndex = 17;
            this.btExportExcel.TextColor = System.Drawing.Color.White;
            this.btExportExcel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // Form_Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTotalRevenue);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form_Revenue";
            this.Size = new System.Drawing.Size(968, 665);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private MetroFramework.Controls.MetroComboBox cbTypeOfRevenue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private LiveCharts.WinForms.PieChart pieChart;
        private LiveCharts.WinForms.CartesianChart barChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbRevenueValue;
        private System.Windows.Forms.Label lbDate;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private XanderUI.XUIButton btExportExcel;
    }
}
