namespace HotelManagement.UI
{
    partial class Item_Room
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
            this.lbRoomStatus = new System.Windows.Forms.Label();
            this.pnBackground = new System.Windows.Forms.Panel();
            this.pnBar = new System.Windows.Forms.Panel();
            this.pbRoomType = new System.Windows.Forms.PictureBox();
            this.pbVip = new System.Windows.Forms.PictureBox();
            this.pbRoomStatus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.pbShadow = new System.Windows.Forms.PictureBox();
            this.RightClickMenu = new Zeroit.Framework.MaterialDesign.Controls.ZeroitMaterialContextMenuStrip();
            this.menuItemRepairRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEndRepairRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCleanRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEndCleanRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.pnBackground.SuspendLayout();
            this.pnBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoomStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShadow)).BeginInit();
            this.RightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRoomStatus
            // 
            this.lbRoomStatus.AutoSize = true;
            this.lbRoomStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lbRoomStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomStatus.ForeColor = System.Drawing.Color.Black;
            this.lbRoomStatus.Location = new System.Drawing.Point(58, 61);
            this.lbRoomStatus.Name = "lbRoomStatus";
            this.lbRoomStatus.Size = new System.Drawing.Size(121, 32);
            this.lbRoomStatus.TabIndex = 3;
            this.lbRoomStatus.Text = "Trạng thái";
            this.lbRoomStatus.Click += new System.EventHandler(this.pbRoomType_Click);
            this.lbRoomStatus.MouseLeave += new System.EventHandler(this.pnBackground_MouseLeave);
            this.lbRoomStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnBackground_MouseMove);
            // 
            // pnBackground
            // 
            this.pnBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.pnBackground.Controls.Add(this.lbRoomStatus);
            this.pnBackground.Controls.Add(this.pnBar);
            this.pnBackground.Controls.Add(this.pbRoomStatus);
            this.pnBackground.Controls.Add(this.label1);
            this.pnBackground.Controls.Add(this.lbRoomID);
            this.pnBackground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnBackground.Location = new System.Drawing.Point(0, 0);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(200, 160);
            this.pnBackground.TabIndex = 7;
            this.pnBackground.Click += new System.EventHandler(this.pbRoomType_Click);
            this.pnBackground.MouseLeave += new System.EventHandler(this.pnBackground_MouseLeave);
            this.pnBackground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnBackground_MouseMove);
            // 
            // pnBar
            // 
            this.pnBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(222)))), ((int)(((byte)(190)))));
            this.pnBar.Controls.Add(this.pbRoomType);
            this.pnBar.Controls.Add(this.pbVip);
            this.pnBar.Location = new System.Drawing.Point(0, 120);
            this.pnBar.Name = "pnBar";
            this.pnBar.Size = new System.Drawing.Size(200, 40);
            this.pnBar.TabIndex = 0;
            this.pnBar.Click += new System.EventHandler(this.pbRoomType_Click);
            this.pnBar.MouseLeave += new System.EventHandler(this.pnBackground_MouseLeave);
            this.pnBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnBackground_MouseMove);
            // 
            // pbRoomType
            // 
            this.pbRoomType.Location = new System.Drawing.Point(152, 0);
            this.pbRoomType.Name = "pbRoomType";
            this.pbRoomType.Size = new System.Drawing.Size(48, 40);
            this.pbRoomType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRoomType.TabIndex = 4;
            this.pbRoomType.TabStop = false;
            this.pbRoomType.Click += new System.EventHandler(this.pbRoomType_Click);
            this.pbRoomType.MouseLeave += new System.EventHandler(this.pnBackground_MouseLeave);
            this.pbRoomType.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnBackground_MouseMove);
            // 
            // pbVip
            // 
            this.pbVip.Location = new System.Drawing.Point(108, 0);
            this.pbVip.Name = "pbVip";
            this.pbVip.Size = new System.Drawing.Size(48, 40);
            this.pbVip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVip.TabIndex = 4;
            this.pbVip.TabStop = false;
            this.pbVip.Click += new System.EventHandler(this.pbRoomType_Click);
            this.pbVip.MouseLeave += new System.EventHandler(this.pnBackground_MouseLeave);
            this.pbVip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnBackground_MouseMove);
            // 
            // pbRoomStatus
            // 
            this.pbRoomStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.pbRoomStatus.Location = new System.Drawing.Point(10, 55);
            this.pbRoomStatus.Name = "pbRoomStatus";
            this.pbRoomStatus.Size = new System.Drawing.Size(48, 40);
            this.pbRoomStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRoomStatus.TabIndex = 2;
            this.pbRoomStatus.TabStop = false;
            this.pbRoomStatus.Click += new System.EventHandler(this.pbRoomType_Click);
            this.pbRoomStatus.MouseLeave += new System.EventHandler(this.pnBackground_MouseLeave);
            this.pbRoomStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnBackground_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phòng";
            this.label1.Click += new System.EventHandler(this.pbRoomType_Click);
            this.label1.MouseLeave += new System.EventHandler(this.pnBackground_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnBackground_MouseMove);
            // 
            // lbRoomID
            // 
            this.lbRoomID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.lbRoomID.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomID.ForeColor = System.Drawing.Color.Black;
            this.lbRoomID.Location = new System.Drawing.Point(101, 0);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(70, 41);
            this.lbRoomID.TabIndex = 1;
            this.lbRoomID.Text = "101";
            this.lbRoomID.Click += new System.EventHandler(this.pbRoomType_Click);
            this.lbRoomID.MouseLeave += new System.EventHandler(this.pnBackground_MouseLeave);
            this.lbRoomID.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnBackground_MouseMove);
            // 
            // pbShadow
            // 
            this.pbShadow.Image = global::HotelManagement.Properties.Resources.imgBackground;
            this.pbShadow.Location = new System.Drawing.Point(0, 0);
            this.pbShadow.Name = "pbShadow";
            this.pbShadow.Size = new System.Drawing.Size(215, 179);
            this.pbShadow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShadow.TabIndex = 6;
            this.pbShadow.TabStop = false;
            // 
            // RightClickMenu
            // 
            this.RightClickMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightClickMenu.Depth = 0;
            this.RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRepairRoom,
            this.menuItemEndRepairRoom,
            this.menuItemCleanRoom,
            this.menuItemEndCleanRoom});
            this.RightClickMenu.MouseState = Zeroit.Framework.MaterialDesign.MouseState.HOVER;
            this.RightClickMenu.Name = "RightClickMenu";
            this.RightClickMenu.Size = new System.Drawing.Size(181, 92);
            // 
            // menuItemRepairRoom
            // 
            this.menuItemRepairRoom.Name = "menuItemRepairRoom";
            this.menuItemRepairRoom.Size = new System.Drawing.Size(180, 22);
            this.menuItemRepairRoom.Text = "Sửa phòng";
            this.menuItemRepairRoom.Click += new System.EventHandler(this.menuItemRepairRoom_Click);
            // 
            // menuItemEndRepairRoom
            // 
            this.menuItemEndRepairRoom.Name = "menuItemEndRepairRoom";
            this.menuItemEndRepairRoom.Size = new System.Drawing.Size(180, 22);
            this.menuItemEndRepairRoom.Text = "Kết thúc sửa phòng";
            this.menuItemEndRepairRoom.Click += new System.EventHandler(this.menuItemEndRepairRoom_Click);
            // 
            // menuItemCleanRoom
            // 
            this.menuItemCleanRoom.Name = "menuItemCleanRoom";
            this.menuItemCleanRoom.Size = new System.Drawing.Size(180, 22);
            this.menuItemCleanRoom.Text = "Dọn phòng";
            this.menuItemCleanRoom.Click += new System.EventHandler(this.menuItemCleanRoom_Click);
            // 
            // menuItemEndCleanRoom
            // 
            this.menuItemEndCleanRoom.Name = "menuItemEndCleanRoom";
            this.menuItemEndCleanRoom.Size = new System.Drawing.Size(180, 22);
            this.menuItemEndCleanRoom.Text = "Kết thúc dọn phòng";
            this.menuItemEndCleanRoom.Click += new System.EventHandler(this.menuItemEndCleanRoom_Click);
            // 
            // Item_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBackground);
            this.Controls.Add(this.pbShadow);
            this.Name = "Item_Room";
            this.Size = new System.Drawing.Size(215, 179);
            this.Load += new System.EventHandler(this.Room_Load);
            this.pnBackground.ResumeLayout(false);
            this.pnBackground.PerformLayout();
            this.pnBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRoomType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoomStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShadow)).EndInit();
            this.RightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbRoomStatus;
        private System.Windows.Forms.PictureBox pbRoomType;
        private System.Windows.Forms.Panel pnBackground;
        private System.Windows.Forms.Panel pnBar;
        private System.Windows.Forms.PictureBox pbVip;
        private System.Windows.Forms.PictureBox pbRoomStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.PictureBox pbShadow;
        private Zeroit.Framework.MaterialDesign.Controls.ZeroitMaterialContextMenuStrip RightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemRepairRoom;
        private System.Windows.Forms.ToolStripMenuItem menuItemEndRepairRoom;
        private System.Windows.Forms.ToolStripMenuItem menuItemCleanRoom;
        private System.Windows.Forms.ToolStripMenuItem menuItemEndCleanRoom;
    }
}
