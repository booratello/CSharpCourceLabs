using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphObjects
{
    /// <summary>
    /// Программа для создания объектов класса AbsGraphObj и унаследованных от него классов
    /// </summary>
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

            Console.WriteLine("\nAttempt to create Circle with negative radius value");

            try
            {
                Circle circle2 = new Circle(35, 12, -14.2);
                circle2.Draw();
            }
            catch (InvalidRadius radEx)
            {
                Console.WriteLine($"{radEx.Message}: {radEx.InvalidRadiusValue}");
            }

            //NB: из-за отсутствия фабричного метода всё равно добавляется окружность с центром (32, 12) и нулевым радиусом
            AbsGraphObj.DrawScene();
        }
    }
}
