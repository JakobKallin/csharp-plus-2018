using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string s = Console.ReadLine();
            int count = 0;
            foreach (char c in s)
            {
                if (c == 'A' || c == 'a')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
