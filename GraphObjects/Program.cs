using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbsGraphObj obj1 = new AbsGraphObj();
            obj1.Draw();
            AbsGraphObj obj2 = new AbsGraphObj("red");
            obj2.Draw();

            Point point = new Point(5, 7, "green");
            point.Draw();
            point.MoveBy(2, -2);
            point.Draw();

            Circle circle = new Circle(15, 25, 14.2);
            circle.Draw();
            circle.Color = "orange";
            circle.Draw();
            circle.Scale(2.7);
            circle.Draw();

            AbsGraphObj.DrawScene();

            AbsGraphObj.ChangeColorForced("ultramarine");
            AbsGraphObj.DrawScene();
        }
    }
}
