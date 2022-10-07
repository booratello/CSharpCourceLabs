using System;

namespace QuadraticEquation
{
    /// <summary>
    /// Программа для поиска корней квадратного уровнения, коэффициенты которого указывает пользователь
    /// </summary>
    internal class Program
    {
        public static (double D, double? X1, double? X2) Solve((double A, double B, double C) ratios)
        {
            double d = Math.Pow(ratios.B, 2) - 4 * ratios.A * ratios.C;
            if (d >= 0)
                return (d, -ratios.B + Math.Sqrt(d) / 2 * ratios.A, -ratios.B - Math.Sqrt(d) / 2 * ratios.A);
            else
                return (d, null, null);
        }

        static void Main()
        {
            (double A, double B, double C) ratios = (0, 0, 0);

            while (true)
            {
                if (ratios.A == 0)
                {
                    Console.Write("Введите коэффициент A квадратного уравнения, он не должен быть равен нулю: ");
                    ratios.A = double.Parse(Console.ReadLine());
                }
                else break;
            }
            Console.Write("Введите коэффициент B квадратного уравнения: ");
            ratios.B = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент C квадратного уравнения: ");
            ratios.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Получено следующее квадратное уравнение: {0}*x^2{1}{2}{3}{4} = 0",
                                ratios.A,
                                ratios.B > 0 ? "+" : "",
                                ratios.B != 0 ? $"{ratios.B}*x" : "",
                                ratios.C > 0 ? "+" : "",
                                ratios.C != 0 ? $"{ratios.C}" : "");

            var SolveQuadraticEquation = Solve(ratios);

            if (SolveQuadraticEquation.D > 0)
                Console.WriteLine($"Корни данного квадратного уравнения: корень1 = {(double)SolveQuadraticEquation.X1:f3}, корень2 = {(double)SolveQuadraticEquation.X2:f3}");
            else if (SolveQuadraticEquation.D == 0)
                Console.WriteLine($"Корни данного квадратного уравнения: корень1 = корень2 = {SolveQuadraticEquation.X1:f3}");
            else
                Console.WriteLine("У данного квадратного уравнения нет действительных корней");
        }
    }
}
