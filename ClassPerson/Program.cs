using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    /// <summary>
    /// Программа для создания объектов класса Person и вызова у них метода-расширения Validate класса PersonExt
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Person somePerson = new Person("Mario", 41);
            somePerson.Show();
            Console.WriteLine(somePerson.Validate());

            Person someTurtleDragon = new Person("Bowser");
            someTurtleDragon.Show();
            Console.WriteLine(someTurtleDragon.Validate());
        }
    }
}
