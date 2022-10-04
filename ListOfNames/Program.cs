using System;
using System.Collections.Generic;

namespace ListOfNames
{
    /// <summary>
    /// Программа заполняет массив именами, которые вводит пользователь, пока вводимое значение не будет пустым, после - выводит отстортированный список имён
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            List<string> names = new List<string>();

            while (true)
            {
                Console.Write("Введите имя: ");
                string someName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(someName))
                {
                    Console.WriteLine("Ввод завершён");
                    break;
                }
                else
                    names.Add(someName);
            }

            names.Sort();

            Console.WriteLine("\nПолучен следующий список имён:");
            foreach (string name in names)
                Console.WriteLine(name);
        }
    }
}
