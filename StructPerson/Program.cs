using System;

namespace StructPerson
{
    /// <summary>
    /// Программа для создания объектов структуры Person и вызова для этих объектов определённого в структуре метода Show
    /// </summary>
    struct Person
    {
        string Name;
        int? Age;

        public Person(string Name, int? Age = null)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void Show()
        {
            string ageInfo = (Age != null) ? $", возраст: {Age}" : "";
            Console.WriteLine($"Имя: {Name}{ageInfo}");
        }
    }


    internal class Program
    {
        static void Main()
        {
            Person notHumblePerson = new Person("Goodwin the Great and Terrible", 55);
            Person humblePerson = new Person("Cinderella");

            notHumblePerson.Show();
            humblePerson.Show();
        }
    }
}
