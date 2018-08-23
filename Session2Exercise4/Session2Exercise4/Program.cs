using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Country: ");
            string country = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Times elected: ");
            int timesElected = int.Parse(Console.ReadLine());

            if (country == "USA" && age >= 35 && timesElected < 2)
            {
                Console.WriteLine("You can be president!");
            }
            else
            {
                Console.WriteLine("Unfortunately, you cannot be president");
            }

            // Variant 1
            /*
            Console.Write("Country: ");
            string country = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Times elected: ");
            int timesElected = int.Parse(Console.ReadLine());
            Console.Write("Saved world from extraterrestrials: ");
            bool savedWorld = bool.Parse(Console.ReadLine());

            if (savedWorld || (country == "USA" && age >= 35 && timesElected < 2))
            {
                Console.WriteLine("You can be president!");
            }
            else
            {
                Console.WriteLine("Unfortunately, you cannot be president");
            }
            */
        }
    }
}
