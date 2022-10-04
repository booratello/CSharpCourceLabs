using System;

namespace SquencePhibonacci
{
    /// <summary>
    /// Программа для вывода чисел последовательности Фибоначчи, пока их значение меньше 1000
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            int previousVal = 0;
            int currentVal = 1;

            while (currentVal < 1000)
            {
                int bufferVal = currentVal;
                Console.WriteLine(currentVal);

                currentVal += previousVal;
                previousVal = bufferVal;
            }
        }
    }
}
