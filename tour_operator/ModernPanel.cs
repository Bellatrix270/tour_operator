using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tour_operator
{
    class ModernPanel : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            LinearGradientBrush gradientBrush = new LinearGradientBrush(this.ClientRectangle, ColorTop, ColorBottom, LinearGradientMode.Vertical);
            Graphics g = e.Graphics;
            g.FillRectangle(gradientBrush, this.ClientRectangle);
        }
    }
}
