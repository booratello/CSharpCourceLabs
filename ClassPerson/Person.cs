using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    internal class Person
    {
        public string Name { get; }
        public int? Age { get; }

        public Person(string Name, int? Age = null)
        {
            this.Name = Name;
            this.Age = (Age != null && Age > 0) ? Age : null;
        }

        public void Show()
        {
            string ageInfo = (Age != null) ? $", возраст: {Age}" : "";
            Console.WriteLine($"Имя: {Name}{ageInfo}");
        }
    }
}
