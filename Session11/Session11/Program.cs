using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { };
            numbers.Add(5);
            numbers.Add(7);
            numbers.Add(2);
            numbers.Add(9);

            List<int> greaterThanFive = new List<int> { };
            foreach (int x in numbers)
            {
                if (x > 5)
                {
                    greaterThanFive.Add(x);
                }
            }

            List<int> alsoGreaterThanFive = numbers.Where(x => x > 5).ToList();
            List<int> multipliedByTwo = numbers.Select(x => x * 2).ToList();
        }
    }
}
