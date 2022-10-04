using System;

namespace ConvertCelsiusIntoFahrenheit
{
    /// <summary>
    /// Программа для перевода указанного пользователем значения температуры из градусов по Цельсию в градусы по Фаренгейту
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Укажите количество градусов по Цельсию:");
            float tCelsius = float.Parse(Console.ReadLine());
            Console.WriteLine($"{tCelsius} градусов по Цельсию = {tCelsius * 9 / 5 + 32:f2} по Фаренгейту");
        }
    }
}
