using System;
using System.Linq;

namespace GetUserArrayProperties
{
    /// <summary>
    /// Программа запрашивает у пользователя размер массива и значения его элементов, после чего сообщает минимальное, максимальное и среднее значения из данных элементов.
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Укажите размер массива:");
            int[] usersArray = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < usersArray.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива:");
                usersArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Результат 'ленивого' решения:");
            Console.WriteLine($"Минимальное значение в массиве: {usersArray.Min()}");
            Console.WriteLine($"Максимальное значение в массиве: {usersArray.Max()}");
            Console.WriteLine($"Среднее значение в массиве: {usersArray.Average():f2}");

            int min, max, sum = 0;
            min = max = usersArray[0];

            for (int i = 0; i < usersArray.Length; i++)
            {
                if (usersArray[i] > max) max = usersArray[i];
                if (usersArray[i] < min) min = usersArray[i];
                sum += usersArray[i];
            }

            Console.WriteLine("Результат решения с перебором элементов:");
            Console.WriteLine($"Минимальное значение в массиве: {min}");
            Console.WriteLine($"Максимальное значение в массиве: {max}");
            Console.WriteLine($"Среднее значение в массиве: {(float)sum / usersArray.Length:f2}");
        }
    }
}
