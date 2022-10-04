using System;

namespace HowManyCrowsOnBranch
{
    /// <summary>
    /// Программа для определения правильного падежа сова "ворона" в зависимости от их количества
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Укажите количество ворон на ветке:");
            int countOfCrows = int.Parse(Console.ReadLine());
            string strCrowsReference;

            if (countOfCrows % 100 >= 11 && countOfCrows % 100 <= 14)
            {
                strCrowsReference = "ворон";
            }
            else
            {
                switch (countOfCrows % 10)
                {
                    case 1:
                        strCrowsReference = "ворона";
                        break;
                    case 2:
                    case 3:
                    case 4:
                        strCrowsReference = "вороны";
                        break;
                    default:
                        strCrowsReference = "ворон";
                        break;
                }
            }
            Console.WriteLine($"На ветке {countOfCrows} {strCrowsReference}");
        }
    }
}
