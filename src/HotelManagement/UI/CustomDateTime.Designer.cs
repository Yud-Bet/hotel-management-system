namespace HotelManagement.UI
{
    partial class CustomDateTime
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any 
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
            this.pnMonth = new System.Windows.Forms.Panel();
            this.lbMonth = new System.Windows.Forms.Label();
            this.cbMonth = new MetroFramework.Controls.MetroComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTime = new MetroFramework.Controls.MetroDateTime();
            this.pnQuarter = new System.Windows.Forms.Panel();
            this.lbQuarter = new System.Windows.Forms.Label();
            this.cbQuarter = new MetroFramework.Controls.MetroComboBox();
            this.pnYear = new System.Windows.Forms.Panel();
            this.lbYear = new System.Windows.Forms.Label();
            this.cbYear = new MetroFramework.Controls.MetroComboBox();
            this.pnMonth.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnQuarter.SuspendLayout();
            this.pnYear.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMonth
            // 
            this.pnMonth.Controls.Add(this.lbMonth);
            this.pnMonth.Controls.Add(this.cbMonth);
            this.pnMonth.Location = new System.Drawing.Point(123, 3);
            this.pnMonth.Name = "pnMonth";
            this.pnMonth.Size = new System.Drawing.Size(118, 35);
            this.pnMonth.TabIndex = 12;
            // 
            // lbMonth
            // 
            this.lbMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonth.Location = new System.Drawing.Point(3, 0);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(55, 32);
            this.lbMonth.TabIndex = 9;
            this.lbMonth.Text = "Tháng";
            this.lbMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.ItemHeight = 23;
            this.cbMonth.Location = new System.Drawing.Point(64, 3);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(53, 29);
            this.cbMonth.TabIndex = 10;
            this.cbMonth.UseSelectable = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dateTime);
            this.flowLayoutPanel1.Controls.Add(this.pnMonth);
            this.flowLayoutPanel1.Controls.Add(this.pnQuarter);
            this.flowLayoutPanel1.Controls.Add(this.pnYear);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(501, 35);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(3, 3);
            this.dateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(114, 29);
            this.dateTime.TabIndex = 11;
            // 
            // pnQuarter
            // 
            this.pnQuarter.Controls.Add(this.lbQuarter);
            this.pnQuarter.Controls.Add(this.cbQuarter);
            this.pnQuarter.Location = new System.Drawing.Point(247, 3);
            this.pnQuarter.Name = "pnQuarter";
            this.pnQuarter.Size = new System.Drawing.Size(106, 35);
            this.pnQuarter.TabIndex = 13;
            // 
            // lbQuarter
            // 
            this.lbQuarter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuarter.Location = new System.Drawing.Point(3, 0);
            this.lbQuarter.Name = "lbQuarter";
            this.lbQuarter.Size = new System.Drawing.Size(42, 32);
            this.lbQuarter.TabIndex = 9;
            this.lbQuarter.Text = "Quý";
            this.lbQuarter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbQuarter
            // 
            this.cbQuarter.FormattingEnabled = true;
            this.cbQuarter.ItemHeight = 23;
            this.cbQuarter.Location = new System.Drawing.Point(51, 3);
            this.cbQuarter.Name = "cbQuarter";
            this.cbQuarter.Size = new System.Drawing.Size(53, 29);
            this.cbQuarter.TabIndex = 10;
            this.cbQuarter.UseSelectable = true;
            // 
            // pnYear
            // 
            this.pnYear.Controls.Add(this.lbYear);
            this.pnYear.Controls.Add(this.cbYear);
            this.pnYear.Location = new System.Drawing.Point(359, 3);
            this.pnYear.Name = "pnYear";
            this.pnYear.Size = new System.Drawing.Size(138, 35);
            this.pnYear.TabIndex = 13;
            // 
            // lbYear
            // 
            this.lbYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(3, 0);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(44, 32);
            this.lbYear.TabIndex = 9;
            this.lbYear.Text = "Năm";
            this.lbYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.ItemHeight = 23;
            this.cbYear.Location = new System.Drawing.Point(53, 3);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(84, 29);
            this.cbYear.TabIndex = 10;
            this.cbYear.UseSelectable = true;
            // 
            // CustomDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CustomDateTime";
            this.Size = new System.Drawing.Size(506, 40);
            this.pnMonth.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnQuarter.ResumeLayout(false);
            this.pnYear.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMonth;
        private System.Windows.Forms.Label lbMonth;
        private MetroFramework.Controls.MetroComboBox cbMonth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroDateTime dateTime;
        private System.Windows.Forms.Panel pnQuarter;
        private System.Windows.Forms.Label lbQuarter;
        private MetroFramework.Controls.MetroComboBox cbQuarter;
        private System.Windows.Forms.Panel pnYear;
        private System.Windows.Forms.Label lbYear;
        private MetroFramework.Controls.MetroComboBox cbYear;
    }
}
