using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LibraryManagement
{
    public class GradientPanel : Panel
    {
        public float Angle { get; set; }
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(ClientRectangle, TopColor, BottomColor, Angle);

            Graphics g = e.Graphics;
            g.FillRectangle(lgb, ClientRectangle);

            base.OnPaint(e);
        }
    }
}
