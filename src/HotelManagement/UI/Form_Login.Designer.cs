namespace HotelManagement.UI
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.pnUsernameLine = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pnPasswordLine = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btLogin = new Zeroit.Framework.Button.ZeroitDummyControl();
            this.btExit = new Zeroit.Framework.Button.ZeroitDummyControl();
            this.LoginClickAnimator = new Zeroit.Framework.Metro.ClickAnimator();
            this.ExitClickAnimator = new Zeroit.Framework.Metro.ClickAnimator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.ExitTimer = new System.Windows.Forms.Timer(this.components);
            this.LoginBGWorker = new System.ComponentModel.BackgroundWorker();
            this.StatusLabel = new Zeroit.Framework.MiscControls.ZeroitLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            this.tbUsername.Location = new System.Drawing.Point(87, 191);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(319, 25);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Text = "Tên đăng nhập";
            // 
            // pnUsernameLine
            // 
            this.pnUsernameLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            this.pnUsernameLine.Location = new System.Drawing.Point(56, 222);
            this.pnUsernameLine.Name = "pnUsernameLine";
            this.pnUsernameLine.Size = new System.Drawing.Size(350, 5);
            this.pnUsernameLine.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            this.tbPassword.Location = new System.Drawing.Point(87, 277);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(319, 25);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Mật khẩu";
            // 
            // pnPasswordLine
            // 
            this.pnPasswordLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            this.pnPasswordLine.Location = new System.Drawing.Point(56, 305);
            this.pnPasswordLine.Name = "pnPasswordLine";
            this.pnPasswordLine.Size = new System.Drawing.Size(350, 5);
            this.pnPasswordLine.TabIndex = 3;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.lbUsername.Location = new System.Drawing.Point(84, 175);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(81, 13);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Tên đăng nhập";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.lbPassword.Location = new System.Drawing.Point(84, 261);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(52, 13);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // btLogin
            // 
            this.btLogin.AllowClickAnimation = true;
            this.btLogin.AllowTransparency = true;
            this.btLogin.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btLogin.BorderWidth = 2;
            this.btLogin.ClickMaxOffset = 10;
            this.btLogin.ClickOffset = 0;
            this.btLogin.ClickSpeed = 1;
            this.btLogin.ColorShape = true;
            this.btLogin.Curve = 3;
            this.btLogin.DownLeftCurve = 12;
            this.btLogin.DownRightCurve = 12;
            this.btLogin.DrawBorder = false;
            this.btLogin.EndAngle = 90F;
            this.btLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Image = null;
            this.btLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btLogin.ImageSize = new System.Drawing.Size(0, 0);
            this.btLogin.Location = new System.Drawing.Point(56, 336);
            this.btLogin.Name = "btLogin";
            this.btLogin.PolygonRadius = 10;
            this.btLogin.PolygonSides = 3;
            this.btLogin.PolygonStartingAngle = 90;
            this.btLogin.Rounding = true;
            this.btLogin.Shape = Zeroit.Framework.Button.Shapes.Rectangle;
            this.btLogin.ShapeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btLogin.ShapePopulate = new Zeroit.Framework.Button.ShapePopulate(Zeroit.Framework.Button.Shapes.Rectangle, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224))))), true, true, false, 3, 12, 12, 12, 12);
            this.btLogin.ShowText = true;
            this.btLogin.Size = new System.Drawing.Size(163, 61);
            this.btLogin.StartAngle = 0F;
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "ĐĂNG NHẬP";
            this.btLogin.TextAlign = System.Drawing.StringAlignment.Center;
            this.btLogin.UpperLeftCurve = 12;
            this.btLogin.UpperRightCurve = 12;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btExit
            // 
            this.btExit.AllowClickAnimation = true;
            this.btExit.AllowTransparency = true;
            this.btExit.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btExit.BorderWidth = 2;
            this.btExit.ClickMaxOffset = 10;
            this.btExit.ClickOffset = 0;
            this.btExit.ClickSpeed = 1;
            this.btExit.ColorShape = true;
            this.btExit.Curve = 10;
            this.btExit.DownLeftCurve = 8;
            this.btExit.DownRightCurve = 8;
            this.btExit.DrawBorder = false;
            this.btExit.EndAngle = 90F;
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Image = null;
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btExit.ImageSize = new System.Drawing.Size(0, 0);
            this.btExit.Location = new System.Drawing.Point(242, 336);
            this.btExit.Name = "btExit";
            this.btExit.PolygonRadius = 10;
            this.btExit.PolygonSides = 3;
            this.btExit.PolygonStartingAngle = 90;
            this.btExit.Rounding = true;
            this.btExit.Shape = Zeroit.Framework.Button.Shapes.Rectangle;
            this.btExit.ShapeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.btExit.ShapePopulate = new Zeroit.Framework.Button.ShapePopulate(Zeroit.Framework.Button.Shapes.Rectangle, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(224))))), true, true, false, 10, 8, 8, 8, 8);
            this.btExit.ShowText = true;
            this.btExit.Size = new System.Drawing.Size(164, 61);
            this.btExit.StartAngle = 0F;
            this.btExit.TabIndex = 4;
            this.btExit.Text = "THOÁT";
            this.btExit.TextAlign = System.Drawing.StringAlignment.Center;
            this.btExit.UpperLeftCurve = 8;
            this.btExit.UpperRightCurve = 8;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // LoginClickAnimator
            // 
            this.LoginClickAnimator.ClickControl = this.btLogin;
            this.LoginClickAnimator.Shape = Zeroit.Framework.Metro.ClickAnimator.DrawMode.Circle;
            this.LoginClickAnimator.Speed = 25;
            // 
            // ExitClickAnimator
            // 
            this.ExitClickAnimator.ClickControl = this.btExit;
            this.ExitClickAnimator.Shape = Zeroit.Framework.Metro.ClickAnimator.DrawMode.Circle;
            this.ExitClickAnimator.Speed = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.profile_user;
            this.pictureBox1.Location = new System.Drawing.Point(172, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pbPass
            // 
            this.pbPass.Image = ((System.Drawing.Image)(resources.GetObject("pbPass.Image")));
            this.pbPass.Location = new System.Drawing.Point(56, 277);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(25, 25);
            this.pbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPass.TabIndex = 1;
            this.pbPass.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(56, 191);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(25, 25);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 1;
            this.pbUser.TabStop = false;
            // 
            // ExitTimer
            // 
            this.ExitTimer.Enabled = true;
            this.ExitTimer.Interval = 800;
            // 
            // LoginBGWorker
            // 
            this.LoginBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LoginBGWorker_DoWork);
            this.LoginBGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.LoginBGWorker_ProgressChanged);
            this.LoginBGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LoginBGWorker_RunWorkerCompleted);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.StatusLabel.Location = new System.Drawing.Point(12, 406);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 19);
            this.StatusLabel.TabIndex = 6;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(464, 434);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.pnPasswordLine);
            this.Controls.Add(this.pnUsernameLine);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.pbPass);
            this.Controls.Add(this.pbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zeroitSeaBlueForm1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel pnUsernameLine;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Panel pnPasswordLine;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private Zeroit.Framework.Button.ZeroitDummyControl btLogin;
        private Zeroit.Framework.Button.ZeroitDummyControl btExit;
        private Zeroit.Framework.Metro.ClickAnimator LoginClickAnimator;
        private Zeroit.Framework.Metro.ClickAnimator ExitClickAnimator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer ExitTimer;
        private System.ComponentModel.BackgroundWorker LoginBGWorker;
        private Zeroit.Framework.MiscControls.ZeroitLabel StatusLabel;
    }
}