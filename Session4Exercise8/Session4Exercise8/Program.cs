using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string s = Console.ReadLine();

            int firstLetter = -1;
            for (int i = 0; i < s.Length && firstLetter == -1; i++)
            {
                if (s[i] != ' ')
                {
                    firstLetter = i;
                }
            }

            int lastLetter = s.Length;
            for (int i = s.Length - 1; i >= 0 && lastLetter == s.Length; i--)
            {
                if (s[i] != ' ')
                {
                    lastLetter = i;
                }
            }

            string result = "";
            for (int i = firstLetter; i <= lastLetter; i++)
            {
                result += s[i];
            }

            Console.WriteLine(result);
        }
    }
}
