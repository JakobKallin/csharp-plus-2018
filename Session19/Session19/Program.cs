using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session19
{
    class Person
    {
        public string Name;
        private int Age;

        public void SetAge(int a)
        {
            if (a >= 0)
            {
                Age = a;
            }
        }

        public int GetAge()
        {
            return Age;
        }
    }

    class PersonWithProperties
    {
        public string Name;
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }
    }

    class PersonWithAutoProperties
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int a = int.Parse(Console.ReadLine());

            Person p = new Person();
            p.Name = name;
            p.SetAge(a);

            int nextAge = p.GetAge() + 1;
            Console.WriteLine("Next year, " + p.Name + " will be " + nextAge + " years old");

            /////

            PersonWithProperties p2 = new PersonWithProperties();
            p2.Name = name;
            p2.Age = a;

            int nextAge2 = p2.Age + 1;
            Console.WriteLine("Next year, " + p2.Name + " will be " + nextAge2 + " years old");
            /////

            PersonWithAutoProperties p3 = new PersonWithAutoProperties();
            p3.Name = name;
            p3.Age = a;

            int nextAge3 = p3.Age + 1;
            Console.WriteLine("Next year, " + p3.Name + " will be " + nextAge3 + " years old");
        }
    }
}
