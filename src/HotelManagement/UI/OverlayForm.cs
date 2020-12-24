using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    class OverlayForm: Form
    {
        public OverlayForm(Form ParentRef, Form ChildRef)
        {
            ControlBox = false;
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.None;
            AllowTransparency = true;
            ShowInTaskbar = false;
            Opacity = .50d;
            BackColor = Color.Black;
            Size = ParentRef.Size;
            Location = ParentRef.Location;
            Enabled = false;
            Owner = ParentRef;
            Activated += (s, e) =>
            {
                ChildRef.Activate();
            };
            ChildRef.StartPosition = FormStartPosition.Manual;
            ChildRef.Owner = ParentRef;
            ChildRef.ShowInTaskbar = false;
            ChildRef.Enabled = false;
            ChildRef.Location = new Point(Location.X + Width / 2 - ChildRef.Width / 2, Location.Y + Height / 2 - ChildRef.Height / 2);
            ChildRef.FormClosed += (s, e) =>
             {
                 this.Close();
                 ParentRef.Focus();
             };
            ChildRef.Show();
        }
    }
}
