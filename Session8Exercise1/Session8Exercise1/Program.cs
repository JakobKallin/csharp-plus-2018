using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Detta program innehåller några olika exempel på att göra om tidigare övningar till metoder.
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 0.56;
        }

        static int GreatestOfThree(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        static double Distance(int x1, int y1, int x2, int y2)
        {
            int xDistance = x2 - x1;
            int yDistance = y2 - y1;
            double distance = Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2));
            return distance;
        }
    }
}
