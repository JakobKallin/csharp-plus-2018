using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                bool divisibleByThree = i % 3 == 0;
                bool divisibleByFive = i % 5 == 0;
                if (divisibleByThree && divisibleByFive)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (divisibleByThree)
                {
                    Console.WriteLine("Fizz");
                }
                else if (divisibleByFive)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
