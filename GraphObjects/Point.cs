using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphObjects
{
    internal class Point : AbsGraphObj, IColorful
    {
        public int X;
        public int Y;

        public Point(int X, int Y, string Color = DEFAULT_COLOR) : base(Color)
        {
            this.X = X;
            this.Y = Y;
        }

        public void MoveBy(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public override void Draw()
        {
            Console.WriteLine($"Point with coordinates ({X}, {Y}) and {Color} color");
        }

        public void SetColor(string newColor)
        {
            this.Color = newColor;
        }
    }
}
