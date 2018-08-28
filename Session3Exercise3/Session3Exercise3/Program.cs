using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Max: ");
            int max = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i <= max; i += 2)
            {
                sum += i;
            }

            Console.WriteLine("Sum of even numbers: " + sum);

            // Variant: sätt räknarens startvärde till 1 istället för 0.
        }
    }
}
