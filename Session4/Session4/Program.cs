using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int firstLetterIndex = 0;
            while (s[firstLetterIndex] == ' ')
            {
                firstLetterIndex++;
            }

            string result = "";
            for (int i = firstLetterIndex; i < s.Length; i++)
            {
                result += s[i];
            }
        }
    }
}
