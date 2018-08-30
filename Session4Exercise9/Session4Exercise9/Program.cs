using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 12, 4 };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * 2;
            }
        }
    }
}
