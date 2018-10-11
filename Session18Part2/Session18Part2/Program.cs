using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session18Part2
{
    class Person {
        public string Name;
        public int Age;
        public int Money;
        public Movie Movie;

        public void CelebrateBirthday()
        {
            Age += 1;
        }

        public void UseAntiAgingCream()
        {
            Age -= 10;
        }

        public string Summary()
        {
            return Name + " is " + Age + " years old and has starred in " + Movie.Title;
        }
    }

    class Movie
    {
        public string Title;
        public int Year;
        public Person Actor;

        public string Summary()
        {
            return Title + " was released in " + Year + " and stars " + Actor.Name;
        }

        public void DoSomethingWithAnActor(Person p)
        {
            Console.WriteLine("I did something with " + p.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person johnny = new Person
            {
                Name = "Johnny Depp",
                Age = 50,
                Money = 4000
            };
            Person orlando = new Person
            {
                Name = "Orlando Bloom",
                Age = 41,
                Money = 8000
            };

            Movie pirates = new Movie
            {
                Title = "Pirates of the Caribbean",
                Year = 2002,
                Actor = johnny
            };
            johnny.Movie = pirates;

            string s = pirates.Summary();
            Console.WriteLine(s);

            string s2 = johnny.Summary();
            Console.WriteLine(s2);

            pirates.DoSomethingWithAnActor(orlando);
        }
    }
}
