using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class DropDownList : UserControl
    {
        public DropDownList()
        {
            InitializeComponent();
        }

        #region properties
        public string selectedItemName = "";
        public string selectedItemText = "";

        #endregion

        #region event
        public EventHandler ChooseItem;
        #endregion

        public void addItem(string text, string name)
        {
            Label label = new System.Windows.Forms.Label();
            label.AutoSize = true;
            flowLayoutPanel1.SetFlowBreak(label, true);
            label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(3, 0);
            label.MinimumSize = new System.Drawing.Size(267, 0);
            label.Name = name;
            label.Size = new System.Drawing.Size(267, 19);
            label.TabIndex = 21;
            label.Text = text;
            label.Cursor = Cursors.Hand;

            label.MouseMove += delegate { label.BackColor = Color.FromArgb(248, 248, 248); };
            label.MouseLeave += delegate { label.BackColor = Color.White; };
            label.Click += delegate {
                timer.Start();
                selectedItemName = label.Name;
                selectedItemText = label.Text;
                if (this.ChooseItem != null)
                    this.ChooseItem(this, new HandledEventArgs());
            };

            Zeroit.Framework.Transitions.ZeroitClickAnimator clickAnimator = new Zeroit.Framework.Transitions.ZeroitClickAnimator();
            clickAnimator.ClickControl = label;
            clickAnimator.AnimationColor = Color.FromArgb(150, 230, 230, 230);

            this.flowLayoutPanel1.Controls.Add(label);
        }

        private void timerHide_Tick(object sender, EventArgs e)
        {
            this.Hide();
            timer.Stop();
        }

        public void clear()
        {
            this.flowLayoutPanel1.Controls.Clear();
        }
    }
}
