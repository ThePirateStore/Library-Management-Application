using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LibraryManagement
{ 
    public class RadioButton2 : RadioButton
    {
		public RadioButton2()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            Padding = new Padding(6);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            OnPaintBackground(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			using(GraphicsPath path = new GraphicsPath())
            {
                int d = Padding.All;
                int r = Height - 1 * d;
                int r2 = Height - 3 * d;

				//Exterior arc
                path.AddArc(d, d, r, r, 90, 180);
                path.AddArc(Width - r - d, d, r, r, -90, 180);

                //Interior arcs
                path.AddArc(d, d, r2, r2, 90, 180);
                path.AddArc(Width - r2 - d, d, r2, r2, -90, 180);

                path.CloseFigure();

                Rectangle rect = new Rectangle(0, 0, r, r);
                Rectangle rect2 = new Rectangle(3, 3, r2, r2);

                e.Graphics.FillEllipse(Brushes.WhiteSmoke, rect);
                e.Graphics.FillEllipse(Checked ? Brushes.Black : Brushes.WhiteSmoke, rect2);

                e.Graphics.DrawEllipse(Checked ? new Pen(Brushes.Black, 1.5f) : new Pen(Brushes.WhiteSmoke), rect);
            }
        }
    }
}
