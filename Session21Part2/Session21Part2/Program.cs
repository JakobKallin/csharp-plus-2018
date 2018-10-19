using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session21Part2
{
    class Actor
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public double Height;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Actor[] actors = new Actor[]
            {
                new Actor { FirstName = "Tom", LastName = "Hardy", Age = 41 },
                new Actor { FirstName = "Scarlett", LastName = "Johansson", Age = 33 },
                new Actor { FirstName = "Jakob", LastName = "Kallin", Age = 31 },
                new Actor { FirstName = "John", LastName = "Travolta", Age = 64 },
            };

            Actor youngestActor = actors.OrderBy(a => a.Age).ToArray()[0];
            int[] ages = actors.Select(a => a.Age).ToArray();
            int totalAge = ages.Sum();
            double averageAge = ages.Average();
        }
    }
}
