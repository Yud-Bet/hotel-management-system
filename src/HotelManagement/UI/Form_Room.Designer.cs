namespace HotelManagement.UI
{
    partial class Form_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Room));
            this.animBookMulRooms = new Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim();
            this.btBookMultipleRooms = new XanderUI.XUIButton();
            this.animAddRoom = new Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim();
            this.btAddRoom = new XanderUI.XUIButton();
            this.animPbSearch = new Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.timerHide2SubBt = new System.Windows.Forms.Timer(this.components);
            this.pnToAddRoomInfo = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnToAddRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.lbListRoomIsEmpty = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tooltipAddRoom = new XanderUI.XUIButton();
            this.tooltipBookMulRoom = new XanderUI.XUIButton();
            this.lbNumberOfRoom = new XanderUI.XUIButton();
            this.lbNumberOfRepairingRoom = new XanderUI.XUIButton();
            this.lbNumberOfCleaningRoom = new XanderUI.XUIButton();
            this.lbNumberOfRentedRoom = new XanderUI.XUIButton();
            this.lbNumberOfEmptyRoom = new XanderUI.XUIButton();
            this.btThreeDot = new XanderUI.XUIButton();
            this.StatusLabel = new Zeroit.Framework.MiscControls.ZeroitLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbSearch = new Zeroit.Framework.Labels.ZeroitUltraTextBox();
            this.animTbSearch = new Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.pnToAddRoom.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // animBookMulRooms
            // 
            this.animBookMulRooms.Acceleration = 0.7F;
            this.animBookMulRooms.AnimationType = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.animationType.Slide;
            this.animBookMulRooms.Control = this.btBookMultipleRooms;
            this.animBookMulRooms.ControlStyles = System.Windows.Forms.ControlStyles.DoubleBuffer;
            this.animBookMulRooms.ControlStylesBool = false;
            this.animBookMulRooms.CordinateEnd_X = 44F;
            this.animBookMulRooms.CordinateEnd_Y = 94F;
            this.animBookMulRooms.CordinateStart_X = 100F;
            this.animBookMulRooms.CordinateStart_Y = 94F;
            this.animBookMulRooms.Duration = 250;
            this.animBookMulRooms.EasingEnd = 1F;
            this.animBookMulRooms.EasingNames = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.Linear;
            this.animBookMulRooms.EasingStart = 0.2F;
            this.animBookMulRooms.Fade_Begin = 0F;
            this.animBookMulRooms.Fade_Limit = 1F;
            this.animBookMulRooms.ResizeHeight_Begin = 10F;
            this.animBookMulRooms.ResizeHeight_Limit = 50F;
            this.animBookMulRooms.ResizeWidth_Begin = 10F;
            this.animBookMulRooms.ResizeWidth_Limit = 50F;
            // 
            // btBookMultipleRooms
            // 
            this.btBookMultipleRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btBookMultipleRooms.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btBookMultipleRooms.ButtonImage")));
            this.btBookMultipleRooms.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btBookMultipleRooms.ButtonText = "";
            this.btBookMultipleRooms.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btBookMultipleRooms.ClickTextColor = System.Drawing.Color.White;
            this.btBookMultipleRooms.CornerRadius = 5;
            this.btBookMultipleRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBookMultipleRooms.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btBookMultipleRooms.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btBookMultipleRooms.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btBookMultipleRooms.HoverTextColor = System.Drawing.Color.White;
            this.btBookMultipleRooms.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btBookMultipleRooms.Location = new System.Drawing.Point(44, 94);
            this.btBookMultipleRooms.Name = "btBookMultipleRooms";
            this.btBookMultipleRooms.Size = new System.Drawing.Size(37, 37);
            this.btBookMultipleRooms.TabIndex = 32;
            this.btBookMultipleRooms.TextColor = System.Drawing.Color.White;
            this.btBookMultipleRooms.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btBookMultipleRooms.Click += new System.EventHandler(this.btBookMultipleRooms_Click);
            this.btBookMultipleRooms.MouseLeave += new System.EventHandler(this.btBookMultipleRooms_MouseLeave);
            this.btBookMultipleRooms.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btBookMultipleRooms_MouseMove);
            // 
            // animAddRoom
            // 
            this.animAddRoom.Acceleration = 0.7F;
            this.animAddRoom.AnimationType = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.animationType.Slide;
            this.animAddRoom.Control = this.btAddRoom;
            this.animAddRoom.ControlStyles = System.Windows.Forms.ControlStyles.DoubleBuffer;
            this.animAddRoom.ControlStylesBool = false;
            this.animAddRoom.CordinateEnd_X = 44F;
            this.animAddRoom.CordinateEnd_Y = 94F;
            this.animAddRoom.CordinateStart_X = 156F;
            this.animAddRoom.CordinateStart_Y = 94F;
            this.animAddRoom.Duration = 250;
            this.animAddRoom.EasingEnd = 1F;
            this.animAddRoom.EasingNames = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.Linear;
            this.animAddRoom.EasingStart = 0.2F;
            this.animAddRoom.Fade_Begin = 0F;
            this.animAddRoom.Fade_Limit = 1F;
            this.animAddRoom.ResizeHeight_Begin = 10F;
            this.animAddRoom.ResizeHeight_Limit = 50F;
            this.animAddRoom.ResizeWidth_Begin = 10F;
            this.animAddRoom.ResizeWidth_Limit = 50F;
            // 
            // btAddRoom
            // 
            this.btAddRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btAddRoom.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btAddRoom.ButtonImage")));
            this.btAddRoom.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btAddRoom.ButtonText = "";
            this.btAddRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btAddRoom.ClickTextColor = System.Drawing.Color.White;
            this.btAddRoom.CornerRadius = 5;
            this.btAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddRoom.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btAddRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btAddRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btAddRoom.HoverTextColor = System.Drawing.Color.White;
            this.btAddRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btAddRoom.Location = new System.Drawing.Point(44, 94);
            this.btAddRoom.Name = "btAddRoom";
            this.btAddRoom.Size = new System.Drawing.Size(37, 37);
            this.btAddRoom.TabIndex = 32;
            this.btAddRoom.TextColor = System.Drawing.Color.White;
            this.btAddRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btAddRoom.Click += new System.EventHandler(this.btAddRoom_Click);
            this.btAddRoom.MouseLeave += new System.EventHandler(this.btAddRoom_MouseLeave);
            this.btAddRoom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btAddRoom_MouseMove);
            // 
            // animPbSearch
            // 
            this.animPbSearch.Acceleration = 0.7F;
            this.animPbSearch.AnimationType = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.animationType.Slide;
            this.animPbSearch.Control = this.pbSearch;
            this.animPbSearch.ControlStyles = System.Windows.Forms.ControlStyles.DoubleBuffer;
            this.animPbSearch.ControlStylesBool = false;
            this.animPbSearch.CordinateEnd_X = 90F;
            this.animPbSearch.CordinateEnd_Y = 98F;
            this.animPbSearch.CordinateStart_X = 202F;
            this.animPbSearch.CordinateStart_Y = 98F;
            this.animPbSearch.Duration = 250;
            this.animPbSearch.EasingEnd = 1F;
            this.animPbSearch.EasingNames = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.Linear;
            this.animPbSearch.EasingStart = 0.2F;
            this.animPbSearch.Fade_Begin = 0F;
            this.animPbSearch.Fade_Limit = 1F;
            this.animPbSearch.ResizeHeight_Begin = 10F;
            this.animPbSearch.ResizeHeight_Limit = 50F;
            this.animPbSearch.ResizeWidth_Begin = 10F;
            this.animPbSearch.ResizeWidth_Limit = 50F;
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::HotelManagement.Properties.Resources.icSearch;
            this.pbSearch.Location = new System.Drawing.Point(90, 98);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(35, 32);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 9;
            this.pbSearch.TabStop = false;
            // 
            // timerHide2SubBt
            // 
            this.timerHide2SubBt.Interval = 250;
            this.timerHide2SubBt.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnToAddRoomInfo
            // 
            this.pnToAddRoomInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnToAddRoomInfo.Location = new System.Drawing.Point(0, 90);
            this.pnToAddRoomInfo.Name = "pnToAddRoomInfo";
            this.pnToAddRoomInfo.Size = new System.Drawing.Size(968, 575);
            this.pnToAddRoomInfo.TabIndex = 9;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(3, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(159, 61);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Phòng";
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbRoomID.ForeColor = System.Drawing.Color.Black;
            this.lbRoomID.Location = new System.Drawing.Point(154, 14);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(52, 61);
            this.lbRoomID.TabIndex = 2;
            this.lbRoomID.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 61);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(36, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 2);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(321, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tất cả:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(456, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 30);
            this.label3.TabIndex = 11;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(575, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 30);
            this.label2.TabIndex = 11;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(694, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 30);
            this.label4.TabIndex = 11;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(813, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 30);
            this.label5.TabIndex = 11;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnToAddRoom
            // 
            this.pnToAddRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnToAddRoom.AutoScroll = true;
            this.pnToAddRoom.Controls.Add(this.lbListRoomIsEmpty);
            this.pnToAddRoom.Location = new System.Drawing.Point(39, 151);
            this.pnToAddRoom.Name = "pnToAddRoom";
            this.pnToAddRoom.Size = new System.Drawing.Size(905, 492);
            this.pnToAddRoom.TabIndex = 23;
            this.pnToAddRoom.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnToAddRoom_ControlAdded);
            this.pnToAddRoom.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnToAddRoom_ControlRemoved);
            // 
            // lbListRoomIsEmpty
            // 
            this.lbListRoomIsEmpty.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListRoomIsEmpty.Location = new System.Drawing.Point(3, 0);
            this.lbListRoomIsEmpty.Name = "lbListRoomIsEmpty";
            this.lbListRoomIsEmpty.Size = new System.Drawing.Size(894, 50);
            this.lbListRoomIsEmpty.TabIndex = 0;
            this.lbListRoomIsEmpty.Text = "Chưa có phòng nào!";
            this.lbListRoomIsEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.tooltipAddRoom);
            this.panel1.Controls.Add(this.tooltipBookMulRoom);
            this.panel1.Controls.Add(this.lbNumberOfRoom);
            this.panel1.Controls.Add(this.lbNumberOfRepairingRoom);
            this.panel1.Controls.Add(this.lbNumberOfCleaningRoom);
            this.panel1.Controls.Add(this.lbNumberOfRentedRoom);
            this.panel1.Controls.Add(this.lbNumberOfEmptyRoom);
            this.panel1.Controls.Add(this.btThreeDot);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.pbSearch);
            this.panel1.Controls.Add(this.pnToAddRoom);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbRoomID);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.btBookMultipleRooms);
            this.panel1.Controls.Add(this.btAddRoom);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 665);
            this.panel1.TabIndex = 1;
            // 
            // tooltipAddRoom
            // 
            this.tooltipAddRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tooltipAddRoom.ButtonImage = null;
            this.tooltipAddRoom.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.tooltipAddRoom.ButtonText = "Thêm phòng";
            this.tooltipAddRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tooltipAddRoom.ClickTextColor = System.Drawing.Color.Black;
            this.tooltipAddRoom.CornerRadius = 5;
            this.tooltipAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tooltipAddRoom.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tooltipAddRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.tooltipAddRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tooltipAddRoom.HoverTextColor = System.Drawing.Color.Black;
            this.tooltipAddRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.tooltipAddRoom.Location = new System.Drawing.Point(969, 47);
            this.tooltipAddRoom.Name = "tooltipAddRoom";
            this.tooltipAddRoom.Size = new System.Drawing.Size(125, 27);
            this.tooltipAddRoom.TabIndex = 32;
            this.tooltipAddRoom.TextColor = System.Drawing.Color.Black;
            this.tooltipAddRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.tooltipAddRoom.Click += new System.EventHandler(this.btThreeDot_Click);
            // 
            // tooltipBookMulRoom
            // 
            this.tooltipBookMulRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tooltipBookMulRoom.ButtonImage = null;
            this.tooltipBookMulRoom.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.tooltipBookMulRoom.ButtonText = "Đặt nhiều phòng";
            this.tooltipBookMulRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tooltipBookMulRoom.ClickTextColor = System.Drawing.Color.Black;
            this.tooltipBookMulRoom.CornerRadius = 5;
            this.tooltipBookMulRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tooltipBookMulRoom.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tooltipBookMulRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.tooltipBookMulRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tooltipBookMulRoom.HoverTextColor = System.Drawing.Color.Black;
            this.tooltipBookMulRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.tooltipBookMulRoom.Location = new System.Drawing.Point(969, 14);
            this.tooltipBookMulRoom.Name = "tooltipBookMulRoom";
            this.tooltipBookMulRoom.Size = new System.Drawing.Size(166, 27);
            this.tooltipBookMulRoom.TabIndex = 32;
            this.tooltipBookMulRoom.TextColor = System.Drawing.Color.Black;
            this.tooltipBookMulRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.tooltipBookMulRoom.Click += new System.EventHandler(this.btThreeDot_Click);
            // 
            // lbNumberOfRoom
            // 
            this.lbNumberOfRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.lbNumberOfRoom.ButtonImage = null;
            this.lbNumberOfRoom.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.lbNumberOfRoom.ButtonText = "0";
            this.lbNumberOfRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.lbNumberOfRoom.ClickTextColor = System.Drawing.Color.Black;
            this.lbNumberOfRoom.CornerRadius = 5;
            this.lbNumberOfRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNumberOfRoom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbNumberOfRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.lbNumberOfRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.lbNumberOfRoom.HoverTextColor = System.Drawing.Color.Black;
            this.lbNumberOfRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.lbNumberOfRoom.Location = new System.Drawing.Point(389, 100);
            this.lbNumberOfRoom.Name = "lbNumberOfRoom";
            this.lbNumberOfRoom.Size = new System.Drawing.Size(60, 27);
            this.lbNumberOfRoom.TabIndex = 32;
            this.lbNumberOfRoom.TextColor = System.Drawing.Color.Black;
            this.lbNumberOfRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.lbNumberOfRoom.Click += new System.EventHandler(this.btThreeDot_Click);
            // 
            // lbNumberOfRepairingRoom
            // 
            this.lbNumberOfRepairingRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(116)))));
            this.lbNumberOfRepairingRoom.ButtonImage = null;
            this.lbNumberOfRepairingRoom.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.lbNumberOfRepairingRoom.ButtonText = "0";
            this.lbNumberOfRepairingRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(116)))));
            this.lbNumberOfRepairingRoom.ClickTextColor = System.Drawing.Color.Black;
            this.lbNumberOfRepairingRoom.CornerRadius = 5;
            this.lbNumberOfRepairingRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNumberOfRepairingRoom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbNumberOfRepairingRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.lbNumberOfRepairingRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(116)))));
            this.lbNumberOfRepairingRoom.HoverTextColor = System.Drawing.Color.Black;
            this.lbNumberOfRepairingRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.lbNumberOfRepairingRoom.Location = new System.Drawing.Point(861, 100);
            this.lbNumberOfRepairingRoom.Name = "lbNumberOfRepairingRoom";
            this.lbNumberOfRepairingRoom.Size = new System.Drawing.Size(60, 27);
            this.lbNumberOfRepairingRoom.TabIndex = 32;
            this.lbNumberOfRepairingRoom.TextColor = System.Drawing.Color.Black;
            this.lbNumberOfRepairingRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.lbNumberOfRepairingRoom.Click += new System.EventHandler(this.btThreeDot_Click);
            // 
            // lbNumberOfCleaningRoom
            // 
            this.lbNumberOfCleaningRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lbNumberOfCleaningRoom.ButtonImage = null;
            this.lbNumberOfCleaningRoom.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.lbNumberOfCleaningRoom.ButtonText = "0";
            this.lbNumberOfCleaningRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lbNumberOfCleaningRoom.ClickTextColor = System.Drawing.Color.Black;
            this.lbNumberOfCleaningRoom.CornerRadius = 5;
            this.lbNumberOfCleaningRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNumberOfCleaningRoom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbNumberOfCleaningRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.lbNumberOfCleaningRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lbNumberOfCleaningRoom.HoverTextColor = System.Drawing.Color.Black;
            this.lbNumberOfCleaningRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.lbNumberOfCleaningRoom.Location = new System.Drawing.Point(743, 100);
            this.lbNumberOfCleaningRoom.Name = "lbNumberOfCleaningRoom";
            this.lbNumberOfCleaningRoom.Size = new System.Drawing.Size(60, 27);
            this.lbNumberOfCleaningRoom.TabIndex = 32;
            this.lbNumberOfCleaningRoom.TextColor = System.Drawing.Color.Black;
            this.lbNumberOfCleaningRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.lbNumberOfCleaningRoom.Click += new System.EventHandler(this.btThreeDot_Click);
            // 
            // lbNumberOfRentedRoom
            // 
            this.lbNumberOfRentedRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.lbNumberOfRentedRoom.ButtonImage = null;
            this.lbNumberOfRentedRoom.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.lbNumberOfRentedRoom.ButtonText = "0";
            this.lbNumberOfRentedRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.lbNumberOfRentedRoom.ClickTextColor = System.Drawing.Color.Black;
            this.lbNumberOfRentedRoom.CornerRadius = 5;
            this.lbNumberOfRentedRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNumberOfRentedRoom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbNumberOfRentedRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.lbNumberOfRentedRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.lbNumberOfRentedRoom.HoverTextColor = System.Drawing.Color.Black;
            this.lbNumberOfRentedRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.lbNumberOfRentedRoom.Location = new System.Drawing.Point(625, 100);
            this.lbNumberOfRentedRoom.Name = "lbNumberOfRentedRoom";
            this.lbNumberOfRentedRoom.Size = new System.Drawing.Size(60, 27);
            this.lbNumberOfRentedRoom.TabIndex = 32;
            this.lbNumberOfRentedRoom.TextColor = System.Drawing.Color.Black;
            this.lbNumberOfRentedRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.lbNumberOfRentedRoom.Click += new System.EventHandler(this.btThreeDot_Click);
            // 
            // lbNumberOfEmptyRoom
            // 
            this.lbNumberOfEmptyRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.lbNumberOfEmptyRoom.ButtonImage = null;
            this.lbNumberOfEmptyRoom.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.lbNumberOfEmptyRoom.ButtonText = "0";
            this.lbNumberOfEmptyRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.lbNumberOfEmptyRoom.ClickTextColor = System.Drawing.Color.Black;
            this.lbNumberOfEmptyRoom.CornerRadius = 5;
            this.lbNumberOfEmptyRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNumberOfEmptyRoom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbNumberOfEmptyRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.lbNumberOfEmptyRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.lbNumberOfEmptyRoom.HoverTextColor = System.Drawing.Color.Black;
            this.lbNumberOfEmptyRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.lbNumberOfEmptyRoom.Location = new System.Drawing.Point(507, 100);
            this.lbNumberOfEmptyRoom.Name = "lbNumberOfEmptyRoom";
            this.lbNumberOfEmptyRoom.Size = new System.Drawing.Size(60, 27);
            this.lbNumberOfEmptyRoom.TabIndex = 32;
            this.lbNumberOfEmptyRoom.TextColor = System.Drawing.Color.Black;
            this.lbNumberOfEmptyRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.lbNumberOfEmptyRoom.Click += new System.EventHandler(this.btThreeDot_Click);
            // 
            // btThreeDot
            // 
            this.btThreeDot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btThreeDot.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btThreeDot.ButtonImage")));
            this.btThreeDot.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btThreeDot.ButtonText = "";
            this.btThreeDot.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btThreeDot.ClickTextColor = System.Drawing.Color.White;
            this.btThreeDot.CornerRadius = 5;
            this.btThreeDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThreeDot.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btThreeDot.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btThreeDot.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btThreeDot.HoverTextColor = System.Drawing.Color.White;
            this.btThreeDot.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btThreeDot.Location = new System.Drawing.Point(44, 94);
            this.btThreeDot.Name = "btThreeDot";
            this.btThreeDot.Size = new System.Drawing.Size(37, 37);
            this.btThreeDot.TabIndex = 32;
            this.btThreeDot.TextColor = System.Drawing.Color.White;
            this.btThreeDot.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btThreeDot.Click += new System.EventHandler(this.btThreeDot_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.StatusLabel.Location = new System.Drawing.Point(39, 647);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 31;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::HotelManagement.Properties.Resources.icFix;
            this.pictureBox5.Location = new System.Drawing.Point(821, 96);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::HotelManagement.Properties.Resources.icClean;
            this.pictureBox4.Location = new System.Drawing.Point(703, 96);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::HotelManagement.Properties.Resources.icRented_DB;
            this.pictureBox3.Location = new System.Drawing.Point(584, 94);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::HotelManagement.Properties.Resources.icYes;
            this.pictureBox2.Location = new System.Drawing.Point(464, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(319, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 49);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // tbSearch
            // 
            this.tbSearch.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.tbSearch.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tbSearch.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbSearch.IsEnabled = true;
            this.tbSearch.Location = new System.Drawing.Point(130, 105);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Multiline = false;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.Placeholder = true;
            this.tbSearch.PlaceHolderText = "Tìm kiếm";
            this.tbSearch.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tbSearch.ReadOnly = false;
            this.tbSearch.Size = new System.Drawing.Size(183, 24);
            this.tbSearch.TabIndex = 28;
            this.tbSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearch.TextBackgroundColor = System.Drawing.SystemColors.Control;
            this.tbSearch.UseSystemPasswordChar = false;
            this.tbSearch.WordWrap = true;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // animTbSearch
            // 
            this.animTbSearch.Acceleration = 0.7F;
            this.animTbSearch.AnimationType = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.animationType.Slide;
            this.animTbSearch.Control = this.tbSearch;
            this.animTbSearch.ControlStyles = System.Windows.Forms.ControlStyles.DoubleBuffer;
            this.animTbSearch.ControlStylesBool = false;
            this.animTbSearch.CordinateEnd_X = 130F;
            this.animTbSearch.CordinateEnd_Y = 105F;
            this.animTbSearch.CordinateStart_X = 242F;
            this.animTbSearch.CordinateStart_Y = 105F;
            this.animTbSearch.Duration = 250;
            this.animTbSearch.EasingEnd = 1F;
            this.animTbSearch.EasingNames = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.Linear;
            this.animTbSearch.EasingStart = 0.2F;
            this.animTbSearch.Fade_Begin = 0F;
            this.animTbSearch.Fade_Limit = 1F;
            this.animTbSearch.ResizeHeight_Begin = 10F;
            this.animTbSearch.ResizeHeight_Limit = 50F;
            this.animTbSearch.ResizeWidth_Begin = 10F;
            this.animTbSearch.ResizeWidth_Limit = 50F;
            // 
            // Form_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnToAddRoomInfo);
            this.Name = "Form_Room";
            this.Size = new System.Drawing.Size(968, 666);
            this.Load += new System.EventHandler(this.Form_Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.pnToAddRoom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim animBookMulRooms;
        private Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim animAddRoom;
        private Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim animPbSearch;
        private System.Windows.Forms.Timer timerHide2SubBt;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Panel pnToAddRoomInfo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.FlowLayoutPanel pnToAddRoom;
        private System.Windows.Forms.Panel panel1;
        private Zeroit.Framework.Labels.ZeroitUltraTextBox tbSearch;
        private Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim animTbSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Zeroit.Framework.MiscControls.ZeroitLabel StatusLabel;
        private XanderUI.XUIButton btThreeDot;
        private XanderUI.XUIButton btBookMultipleRooms;
        private XanderUI.XUIButton btAddRoom;
        private XanderUI.XUIButton lbNumberOfRoom;
        private XanderUI.XUIButton lbNumberOfRepairingRoom;
        private XanderUI.XUIButton lbNumberOfCleaningRoom;
        private XanderUI.XUIButton lbNumberOfRentedRoom;
        private XanderUI.XUIButton lbNumberOfEmptyRoom;
        private XanderUI.XUIButton tooltipAddRoom;
        private XanderUI.XUIButton tooltipBookMulRoom;
        private System.Windows.Forms.Label lbListRoomIsEmpty;
    }
}
