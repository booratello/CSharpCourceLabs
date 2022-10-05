using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphObjects
{
    internal class Circle : AbsGraphObj, IColorful
    {
        public int centerX;
        public int centerY;
        public double radius;

        public Circle(int centerX, int centerY, double radius, string Color = DEFAULT_COLOR) : base(Color)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
        }

        public void Scale(double ratioScale)
        {
            radius *= ratioScale;
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle with coordinates of center  ({centerX}, {centerY}), radius = {radius:f2} and {Color} color");
        }

        public void SetColor(string newColor)
        {
            this.Color = newColor;
        }
    }
}
