using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            int[] repeated = new int[numbers.Length * 2];

            for (int i = 0; i < numbers.Length; i++)
            {
                repeated[i] = numbers[i];
            }

            for (int i = numbers.Length; i < numbers.Length * 2; i++)
            {
                repeated[i] = numbers[i - numbers.Length];
            }
        }
    }
}
