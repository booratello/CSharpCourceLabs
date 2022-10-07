using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperations
{
    /// <summary>
    /// Программа для создания объектов класса BankAccout, редактирование полей которого доступно только через соответствующие методы
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccout someRichPerson = new BankAccout("Elon Musk", (decimal)(219 * Math.Pow(10, 9)));

            Console.WriteLine(someRichPerson.Owner);
            Console.WriteLine(someRichPerson.Balance);

            Console.WriteLine(someRichPerson.ToString());

            someRichPerson.Deposite(-876531981);
            Console.WriteLine(someRichPerson.ToString());

            someRichPerson.Deposite(876531981);
            Console.WriteLine(someRichPerson.ToString());

            Console.WriteLine(someRichPerson.Withdraw(876531981));
            Console.WriteLine(someRichPerson.ToString());

            Console.WriteLine(someRichPerson.Withdraw((decimal)(220 * Math.Pow(10, 9))));
            Console.WriteLine(someRichPerson.ToString());

            BankAccout someNotAsRichPerson = new BankAccout("Johnny Depp", (decimal)(150 * Math.Pow(10, 6)));

            Console.WriteLine(BankAccout.Transfer(someRichPerson, someNotAsRichPerson, (decimal)(220 * Math.Pow(10, 9))));
            Console.WriteLine(someRichPerson.ToString());
            Console.WriteLine(someNotAsRichPerson.ToString());

            Console.WriteLine(BankAccout.Transfer(someRichPerson, someNotAsRichPerson, (decimal)(219 * Math.Pow(10, 9))));
            Console.WriteLine(someRichPerson.ToString());
            Console.WriteLine(someNotAsRichPerson.ToString());

            Console.WriteLine(BankAccout.Transfer(someNotAsRichPerson, someRichPerson, (decimal)(218.99 * Math.Pow(10, 9))));
            Console.WriteLine(someRichPerson.ToString());
            Console.WriteLine(someNotAsRichPerson.ToString());
        }
    }
}
