using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Square : Figure
    {
        public double sideLength { get; set; }

        public Square() { }

        public Square(int x, int y, int sideLength)
        {
            this.x = x;
            this.y = y;
            this.sideLength = sideLength;
        }

        public override void DrawBlack(PictureBox p)
        {
            Pen sq = Pens.Blue;

            using (var g = Graphics.FromImage(p.Image))
            {
                g.DrawRectangle(sq, x, y, (int)sideLength, (int)sideLength);
            }
        }

        public override void HideDrawingBackGround(PictureBox p)
        {
            Pen sq = Pens.White;
            using (var g = Graphics.FromImage(p.Image))
            {
                g.DrawRectangle(sq, x, y, (int)sideLength, (int)sideLength);
            }
        }
    }
}
