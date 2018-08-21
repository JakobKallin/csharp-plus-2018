using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = int.Parse(Console.ReadLine());

            int xDistance = x2 - x1;
            int yDistance = y2 - y1;
            double distance = Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2));

            Console.WriteLine("Distance: " + distance);
        }
    }
}
