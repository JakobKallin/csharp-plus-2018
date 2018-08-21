using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Children: ");
            int children = int.Parse(Console.ReadLine());

            Console.Write("Candy: ");
            int candy = int.Parse(Console.ReadLine());

            double portion = (double) candy / children;
            Console.WriteLine("Candy per child: " + portion);
        }
    }
}
