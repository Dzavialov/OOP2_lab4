using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Circle : Figure
    {
        double radius { get; set; }

        public Circle() { }

        public Circle(int x, int y, double radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void DrawBlack(PictureBox p)
        {
            using (var g = Graphics.FromImage(p.Image))
            {
                g.DrawEllipse(Pens.Black, x, y, (int)radius, (int)radius);
            }
        }

        public override void HideDrawingBackGround(PictureBox p)
        {
            using (var g = Graphics.FromImage(p.Image))
            {
                g.DrawEllipse(Pens.White, x, y, (int)radius, (int)radius);
            }
        }
    }
}
