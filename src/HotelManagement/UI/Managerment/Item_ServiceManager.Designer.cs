namespace HotelManagement.UI
{
    partial class Item_ServiceManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_ServiceManager));
            this.zeroitRectShadowPanel5 = new Zeroit.Framework.MiscControls.ZeroitRectShadowPanel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbName = new Zeroit.Framework.Labels.ZeroitMultiFormatLabel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.clickAnimator1 = new Zeroit.Framework.Metro.ClickAnimator();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // zeroitRectShadowPanel5
            // 
            this.zeroitRectShadowPanel5.BorderColor = System.Drawing.Color.Black;
            this.zeroitRectShadowPanel5.Color = System.Drawing.SystemColors.Control;
            this.zeroitRectShadowPanel5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.zeroitRectShadowPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroitRectShadowPanel5.Location = new System.Drawing.Point(0, 0);
            this.zeroitRectShadowPanel5.Name = "zeroitRectShadowPanel5";
            this.zeroitRectShadowPanel5.PolygonRadius = 93;
            this.zeroitRectShadowPanel5.PolygonSides = 3;
            this.zeroitRectShadowPanel5.PolygonStartingAngle = 90;
            this.zeroitRectShadowPanel5.Size = new System.Drawing.Size(198, 187);
            this.zeroitRectShadowPanel5.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.zeroitRectShadowPanel5.TabIndex = 6;
            this.zeroitRectShadowPanel5.Text = "zeroitRectShadowPanel1";
            this.zeroitRectShadowPanel5.Transparency = 10F;
            this.zeroitRectShadowPanel5.ZeroitRectShadowPanelType = Zeroit.Framework.MiscControls.ZeroitRectShadowPanel.TypeOfZeroitRectShadowPanel.Rectangle;
            // 
            // pbImage
            // 
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImage.Image = global::HotelManagement.Properties.Resources.fast_food;
            this.pbImage.Location = new System.Drawing.Point(3, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(192, 127);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 7;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // lbName
            // 
            this.lbName.AllowTransparency = true;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbName.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName.Location = new System.Drawing.Point(3, 132);
            this.lbName.MainText = "Name";
            this.lbName.MainTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbName.MainTextPadding = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(192, 31);
            this.lbName.TabIndex = 9;
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbPrice.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.lbPrice.Location = new System.Drawing.Point(56, 158);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(135, 24);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Price";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbRemove
            // 
            this.pbRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRemove.Image = ((System.Drawing.Image)(resources.GetObject("pbRemove.Image")));
            this.pbRemove.Location = new System.Drawing.Point(170, 3);
            this.pbRemove.Name = "pbRemove";
            this.pbRemove.Size = new System.Drawing.Size(25, 25);
            this.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemove.TabIndex = 10;
            this.pbRemove.TabStop = false;
            this.pbRemove.Click += new System.EventHandler(this.pbRemove_Click);
            // 
            // clickAnimator1
            // 
            this.clickAnimator1.ClickControl = this.pbImage;
            this.clickAnimator1.Shape = Zeroit.Framework.Metro.ClickAnimator.DrawMode.Circle;
            this.clickAnimator1.Speed = 19;
            // 
            // Item_ServiceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbRemove);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.zeroitRectShadowPanel5);
            this.Name = "Item_ServiceManager";
            this.Size = new System.Drawing.Size(198, 187);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Zeroit.Framework.MiscControls.ZeroitRectShadowPanel zeroitRectShadowPanel5;
        private System.Windows.Forms.PictureBox pbImage;
        private Zeroit.Framework.Labels.ZeroitMultiFormatLabel lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.PictureBox pbRemove;
        private Zeroit.Framework.Metro.ClickAnimator clickAnimator1;
    }
}
