using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session23
{
    class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public double Area { get; set; }
        public int Founded { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            City[] cities =
            {
                new City
                {
                    Name = "Stockholm",
                    Area = 381.63,
                    Population = 1515017,
                    Founded = 1252
                },
                new City
                {
                    Name = "Göteborg",
                    Area = 215.13,
                    Population = 590580,
                    Founded = 1621
                },
                new City
                {
                    Name = "Malmö",
                    Area = 77.06,
                    Population = 312012,
                    Founded = 1250
                },
                new City
                {
                    Name = "Uppsala",
                    Area = 43.74,
                    Population = 156854,
                    Founded = 1286
                },
                new City
                {
                    Name = "Västerås",
                    Area = 48.07,
                    Population = 121806,
                    Founded = 990
                },
                new City
                {
                    Name = "Örebro",
                    Area = 50.64,
                    Population = 119091,
                    Founded = 1200
                }
            };

            // Find the largest city.
            City largest = null;
            foreach (City c in cities)
            {
                if (largest != null && c.Population > largest.Population)
                {
                    largest = c;
                }
            }

            // Find the smallest city.
            City smallest = null;
            foreach (City c in cities)
            {
                if (smallest == null || c.Population < smallest.Population)
                {
                    smallest = c;
                }
            }

            // Calculate the average population.
            int totalPopulation = 0;
            foreach (City c in cities)
            {
                totalPopulation += c.Population;
            }
            double averagePopulation = (double) totalPopulation / cities.Length;

            // Show various statistics.
            double vsAverage = Math.Round(averagePopulation - smallest.Population);
            Console.WriteLine("The smallest city has " + vsAverage + " people fewer than the average.");
            int vsLargest = (largest.Population - smallest.Population);
            Console.WriteLine("The smallest city has " + vsLargest + " people fewer than the largest.");
        }
    }
}
