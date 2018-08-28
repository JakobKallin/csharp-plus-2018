using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter temperature: ");
            double temperature = double.Parse(Console.ReadLine());

            if (temperature >= 18 && temperature <= 26)
            {
                Console.WriteLine("Appropriate temperature");
            }
            else
            {
                Console.WriteLine("Unacceptable temperature");
            }

            // Variant 1: Använd en if-else-sats med tre grenar: en som körs om temperaturen är under 18, en som körs om temperaturen istället är över 26 och en som körs om inget av detta gäller.
        }
    }
}
