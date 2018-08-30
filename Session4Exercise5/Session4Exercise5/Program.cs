using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string s = Console.ReadLine();
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += s[i];
                }
                else
                {
                    result += "*";
                }
            }
            Console.WriteLine(result);
        }
    }
}
