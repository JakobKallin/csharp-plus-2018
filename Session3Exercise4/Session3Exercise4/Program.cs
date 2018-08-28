using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            string message = "";
            for (int i = seconds; i >= 1; i--)
            {
                message += i + ", ";
            }
            message += "takeoff!";

            Console.WriteLine(message);

            // Variant: använd uttrycket "seconds - i" inuti loopen för att få den nuvarande sekunden.
        }
    }
}
