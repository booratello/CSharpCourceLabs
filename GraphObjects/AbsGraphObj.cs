using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphObjects
{
    internal class AbsGraphObj
    {
        public static List<AbsGraphObj> allGraphObjects = new List<AbsGraphObj>();
        public const string DEFAULT_COLOR = "black";
        public string Color;

        public AbsGraphObj(string Color = DEFAULT_COLOR)
        {
            this.Color = Color;
            allGraphObjects.Add(this);
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Some GraphObj with {Color} color");
        }

        public static void DrawScene()
        {
            Console.WriteLine("\nDraw scene:");
            foreach (var graphObj in allGraphObjects)
                graphObj.Draw();
        }

        public static void ChangeColorForced(string color)
        {
            Console.WriteLine("\nChange color for Graph Objects with IColorful interface");
            foreach (var graphObj in allGraphObjects)
            {
                if (graphObj is IColorful)
                {
                    (graphObj as IColorful).SetColor(color);
                }
            }

        }
    }
}
