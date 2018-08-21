using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter four numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            
            int smallest = Math.Min(Math.Min(a, b), Math.Min(c, d));

            Console.WriteLine("The smallest number is: " + smallest);

            // Variant 1: Använd Math.Max istället för Math.Min.
            // Variant 2: Detta visade sig vara en "slamkrypare" som inte gick att lösa lika enkelt som jag först tänkte mig. Jag ber om ursäkt för detta och har nu tagit bort denna variant från e-boken.
        }
    }
}
;