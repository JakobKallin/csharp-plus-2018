using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string s = Console.ReadLine();
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }
            Console.WriteLine(result);
        }
    }
}
