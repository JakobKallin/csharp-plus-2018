using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = bool.Parse(Console.ReadLine());
            bool y = bool.Parse(Console.ReadLine());

            bool result1 = !(x && y);

            // By applying "De Morgan's laws", we find that the expression below is equivalent.
            bool result2 = !x || !y;

            // If we set up a truth table, we will see that there are four possible combinations of x and y to test.
        }
    }
}
