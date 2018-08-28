using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int total = 1;
            for (int i = 1; i <= number; i++)
            {
                total = total * i;
            }

            Console.Write("The factorial of " + number + " is: ");
            Console.WriteLine(total);
        }
    }
}
