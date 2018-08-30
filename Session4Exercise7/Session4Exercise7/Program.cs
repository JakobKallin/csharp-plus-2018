using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise7
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

            string result = "";
            for (int i = firstLetter; i < s.Length; i++)
            {
                result += s[i];
            }

            Console.WriteLine(result);
        }
    }
}
