using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where in Sweden should you travel?");

            Console.WriteLine("What do you want to see?");
            string attraction = Console.ReadLine();
            if (attraction == "Forests")
            {
                Console.WriteLine("Småland");
            }
            else if (attraction == "Mountains")
            {
                Console.WriteLine("Lappland");
            }
            else if (attraction == "Cities")
            {
                Console.WriteLine("Do you enjoy puns?");
                string enjoysPuns = Console.ReadLine();
                if (enjoysPuns == "Yes")
                {
                    Console.WriteLine("Gothenburg");
                }
                else if (enjoysPuns == "No")
                {
                    Console.WriteLine("Stockholm");
                }
            }

            // Our chart does not contain any cycles, and we wouldn't be able to handle them if it did. We would need something that can repeat the same part of the code over and over.
        }
    }
}
