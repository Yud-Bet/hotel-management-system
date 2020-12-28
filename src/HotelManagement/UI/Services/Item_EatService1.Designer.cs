namespace HotelManagement.UI
{
    partial class Item_EatService1
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
            this.lbPrice = new System.Windows.Forms.Label();
            this.zeroitClickAnimator1 = new Zeroit.Framework.Transitions.ZeroitClickAnimator();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.zeroitRectShadowPanel1 = new Zeroit.Framework.MiscControls.ZeroitRectShadowPanel();
            this.lbName = new Zeroit.Framework.Labels.ZeroitMultiFormatLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbPrice.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.lbPrice.Location = new System.Drawing.Point(88, 158);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(135, 24);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // zeroitClickAnimator1
            // 
            this.zeroitClickAnimator1.ClickControl = this.pbImage;
            this.zeroitClickAnimator1.Shape = Zeroit.Framework.Transitions.ZeroitClickAnimator.drawMode.Circle;
            this.zeroitClickAnimator1.Speed = 22;
            // 
            // pbImage
            // 
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImage.Image = global::HotelManagement.Properties.Resources.fast_food;
            this.pbImage.Location = new System.Drawing.Point(3, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(221, 127);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // zeroitRectShadowPanel1
            // 
            this.zeroitRectShadowPanel1.BorderColor = System.Drawing.Color.Black;
            this.zeroitRectShadowPanel1.Color = System.Drawing.SystemColors.Control;
            this.zeroitRectShadowPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.zeroitRectShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroitRectShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.zeroitRectShadowPanel1.Name = "zeroitRectShadowPanel1";
            this.zeroitRectShadowPanel1.PolygonRadius = 100;
            this.zeroitRectShadowPanel1.PolygonSides = 3;
            this.zeroitRectShadowPanel1.PolygonStartingAngle = 90;
            this.zeroitRectShadowPanel1.Size = new System.Drawing.Size(227, 187);
            this.zeroitRectShadowPanel1.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.zeroitRectShadowPanel1.TabIndex = 3;
            this.zeroitRectShadowPanel1.Text = "zeroitRectShadowPanel1";
            this.zeroitRectShadowPanel1.Transparency = 10F;
            this.zeroitRectShadowPanel1.ZeroitRectShadowPanelType = Zeroit.Framework.MiscControls.ZeroitRectShadowPanel.TypeOfZeroitRectShadowPanel.Rectangle;
            this.zeroitRectShadowPanel1.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // lbName
            // 
            this.lbName.AllowTransparency = true;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName.Location = new System.Drawing.Point(3, 128);
            this.lbName.MainText = "Name";
            this.lbName.MainTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbName.MainTextPadding = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(221, 35);
            this.lbName.TabIndex = 4;
            // 
            // Item_EatService1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.zeroitRectShadowPanel1);
            this.DoubleBuffered = true;
            this.Name = "Item_EatService1";
            this.Size = new System.Drawing.Size(227, 187);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbPrice;
        private Zeroit.Framework.Transitions.ZeroitClickAnimator zeroitClickAnimator1;
        private Zeroit.Framework.MiscControls.ZeroitRectShadowPanel zeroitRectShadowPanel1;
        private Zeroit.Framework.Labels.ZeroitMultiFormatLabel lbName;
    }
}
