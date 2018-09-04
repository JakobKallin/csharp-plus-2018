using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { };
            bool done = false;
            while (!done)
            {
                string s = Console.ReadLine();
                if (s == "")
                {
                    done = true;
                }
                else
                {
                    int n = int.Parse(s);
                    numbers.Add(n);
                }
            }

            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }

            Console.Write("Sum: ");
            Console.WriteLine(sum);
        }
    }
}
