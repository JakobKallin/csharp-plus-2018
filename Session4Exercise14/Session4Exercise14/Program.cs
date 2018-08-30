using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 0, 7, 0, 2 };
            int count = 0;
            foreach (int n in numbers)
            {
                if (n != 0)
                {
                    count++;
                }
            }

            int[] removed = new int[count];
            int nextIndex = 0;
            foreach (int n in numbers)
            {
                if (n != 0)
                {
                    removed[nextIndex] = n;
                    nextIndex++;
                }
            }
        }
    }
}
