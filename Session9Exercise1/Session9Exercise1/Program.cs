using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9Exercise1
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public string Summary()
        {
            return FirstName + " " + LastName + " är " + Age + " år gammal.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Förnamn: ");
            string firstName = Console.ReadLine();

            Console.Write("Efternamn: ");
            string lastName = Console.ReadLine();

            Console.Write("Ålder: ");
            int age = int.Parse(Console.ReadLine());

            Person p = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age
            };

            Console.WriteLine(p.Summary());
        }
    }
}
