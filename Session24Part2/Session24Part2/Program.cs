using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session24Part2
{
    public class Triangle
    {
        public static bool IsIsosceles(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                return false;
            }
            else
            {
                return a == b || a == c || b == c;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
