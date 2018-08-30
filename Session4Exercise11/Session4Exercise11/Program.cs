using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 12, -3, 7 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 10)
                {
                    numbers[i] = 10;
                }
                else if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
        }
    }
}
