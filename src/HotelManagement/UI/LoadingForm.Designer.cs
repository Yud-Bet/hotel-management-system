namespace HotelManagement.UI
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            this.xuiCircleProgressBar1 = new XanderUI.XUICircleProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SysTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // xuiCircleProgressBar1
            // 
            this.xuiCircleProgressBar1.AnimationSpeed = 8;
            this.xuiCircleProgressBar1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.xuiCircleProgressBar1.FilledColorAlpha = 255;
            this.xuiCircleProgressBar1.FilledThickness = 8;
            this.xuiCircleProgressBar1.IsAnimated = true;
            this.xuiCircleProgressBar1.Location = new System.Drawing.Point(21, 20);
            this.xuiCircleProgressBar1.Name = "xuiCircleProgressBar1";
            this.xuiCircleProgressBar1.Percentage = 33;
            this.xuiCircleProgressBar1.ShowText = false;
            this.xuiCircleProgressBar1.Size = new System.Drawing.Size(90, 90);
            this.xuiCircleProgressBar1.TabIndex = 1;
            this.xuiCircleProgressBar1.TextColor = System.Drawing.Color.Gray;
            this.xuiCircleProgressBar1.TextSize = 25;
            this.xuiCircleProgressBar1.UnFilledColor = System.Drawing.Color.Transparent;
            this.xuiCircleProgressBar1.UnfilledThickness = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(148, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vui lòng chờ";
            // 
            // SysTimer
            // 
            this.SysTimer.Interval = 500;
            this.SysTimer.Tick += new System.EventHandler(this.SysTimer_Tick);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(348, 132);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xuiCircleProgressBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoadingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadingForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICircleProgressBar xuiCircleProgressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer SysTimer;
    }
}