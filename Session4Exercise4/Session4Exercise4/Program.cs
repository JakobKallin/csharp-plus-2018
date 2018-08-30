using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string s = Console.ReadLine();
            string result = "";
            foreach (char c in s)
            {
                if (c != 'A' && c != 'a' && c != 'E' && c != 'e' && c != 'I' && c != 'i' && c != 'O' && c != 'o' && c != 'U' && c != 'u' && c != 'Y' && c != 'y')
                {
                    result += c;
                }
            }
            Console.WriteLine(result);
        }
    }
}
