using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LibraryManagement
{
    public class ToggleSwitch : CheckBox
    {
        public ToggleSwitch()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            Padding = new Padding(3);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            OnPaintBackground(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = new GraphicsPath())
            {
                int d = Padding.All;
                int r = Height - 2 * d;
                path.AddArc(d, d, r, r, 90, 180);
                path.AddArc(Width - r - d, d, r, r, -90, 180);
                path.CloseFigure();
                e.Graphics.FillPath(Checked ? Brushes.DarkGray : Brushes.LightGray, path);
                r = Height - 1;
                Rectangle rect = Checked ? new Rectangle(Width - r - 1, 0, r, r) : new Rectangle(0, 0, r, r);
                e.Graphics.FillEllipse(Checked ? Brushes.Green : Brushes.WhiteSmoke, rect);
            }
        }
    }
}
