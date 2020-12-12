using System;
using System.Threading;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class LoadingForm : Form
    {
        private CancellationToken ct;
        private bool Permission = false;
        public LoadingForm(CancellationToken ct)
        {
            InitializeComponent();
            this.ct = ct;
            SysTimer.Start();
        }

        private void SysTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                ct.ThrowIfCancellationRequested();
            }
            catch (OperationCanceledException)
            {
                SysTimer.Stop();
                Permission = true;
                this.Close();
            }
        }

        private void LoadingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Permission) e.Cancel = true;
        }
    }
}
