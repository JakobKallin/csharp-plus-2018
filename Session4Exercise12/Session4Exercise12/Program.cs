using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 12, 7, 100 };
            int count = 0;
            foreach (int n in numbers)
            {
                if (n > 10)
                {
                    count++;
                }
            }
        }
    }
}
