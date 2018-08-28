using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter min number: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter max number: ");
            int max = int.Parse(Console.ReadLine());
            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
