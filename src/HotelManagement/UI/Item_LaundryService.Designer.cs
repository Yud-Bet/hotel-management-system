namespace HotelManagement.UI
{
    partial class Item_LaundryService
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
            this.lbName = new System.Windows.Forms.Label();
            this.zeroitUltraTextBox1 = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(16, 6);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(102, 21);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "ServiceName";
            // 
            // zeroitUltraTextBox1
            // 
            this.zeroitUltraTextBox1.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.zeroitUltraTextBox1.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.zeroitUltraTextBox1.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.zeroitUltraTextBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.zeroitUltraTextBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.zeroitUltraTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.zeroitUltraTextBox1.IsEnabled = true;
            this.zeroitUltraTextBox1.Location = new System.Drawing.Point(-11, 9);
            this.zeroitUltraTextBox1.MaxLength = 0;
            this.zeroitUltraTextBox1.Multiline = false;
            this.zeroitUltraTextBox1.Name = "zeroitUltraTextBox1";
            this.zeroitUltraTextBox1.PasswordChar = '\0';
            this.zeroitUltraTextBox1.Placeholder = true;
            this.zeroitUltraTextBox1.PlaceHolderText = "";
            this.zeroitUltraTextBox1.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.zeroitUltraTextBox1.ReadOnly = false;
            this.zeroitUltraTextBox1.Size = new System.Drawing.Size(438, 24);
            this.zeroitUltraTextBox1.TabIndex = 1;
            this.zeroitUltraTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.zeroitUltraTextBox1.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.zeroitUltraTextBox1.UseSystemPasswordChar = false;
            this.zeroitUltraTextBox1.WordWrap = true;
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPrice.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.lbPrice.Location = new System.Drawing.Point(171, 4);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(100, 24);
            this.lbPrice.TabIndex = 11;
            this.lbPrice.Text = "Price";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbCount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 30);
            this.panel1.TabIndex = 15;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("San Francisco Text Regular", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(-1, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "x";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCount
            // 
            this.tbCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCount.Location = new System.Drawing.Point(322, 4);
            this.tbCount.MaxLength = 2;
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(80, 22);
            this.tbCount.TabIndex = 12;
            this.tbCount.Text = "1";
            this.tbCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCount_KeyPress);
            this.tbCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Item_LaundryService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zeroitUltraTextBox1);
            this.Name = "Item_LaundryService";
            this.Size = new System.Drawing.Size(417, 33);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox zeroitUltraTextBox1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCount;
    }
}
