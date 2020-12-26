using System;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HotelManagement.UI
{
    public partial class LoadingForm : Form
    {
        private CancellationToken ct;
        private bool Permission = false;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public LoadingForm(CancellationToken ct)
        {
            InitializeComponent();
            this.ct = ct;
            SysTimer.Start();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
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
