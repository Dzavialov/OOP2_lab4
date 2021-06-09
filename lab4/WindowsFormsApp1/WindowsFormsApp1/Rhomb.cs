using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Rhomb : Figure
    {
        private double horDiagLen { get; set; }
        private double vertDiagLen { get; set; }

        public Rhomb() { }

        public Rhomb(int x, int y, double horDiagLen, double vertDiagLen)
        {
            this.x = x;
            this.y = y;
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
        }

        public override void DrawBlack(PictureBox p)
        {
            Pen rh = Pens.Red;

            using (var g = Graphics.FromImage(p.Image))
            {
                Rectangle rec = new Rectangle(x, y, (int)horDiagLen, (int)vertDiagLen);
                using (Matrix m = new Matrix())
                {
                    m.RotateAt(45, new PointF(rec.Left + (rec.Width / 2), rec.Top + (rec.Height / 2)));
                    g.Transform = m;
                    g.DrawRectangle(rh, rec);
                }
            }
        }

        public override void HideDrawingBackGround(PictureBox p)
        {
            Pen rh = Pens.White;
            using (var g = Graphics.FromImage(p.Image))
            {
                Rectangle rec = new Rectangle(x, y, (int)horDiagLen, (int)vertDiagLen);
                using (Matrix m = new Matrix())
                {
                    m.RotateAt(45, new PointF(rec.Left + (rec.Width / 2), rec.Top + (rec.Height / 2)));                  
                    g.Transform = m;
                    g.DrawRectangle(rh, rec);
                }
            }
        }
    }
}
