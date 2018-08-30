using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 5, 5, 5 };
            for (int i = 0; i < numbers.Length; i += 2)
            {
                numbers[i] = 0;
            }
        }
    }
}
