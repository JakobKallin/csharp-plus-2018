using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string s = Console.ReadLine();
            string result = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                result += s[i];
            }
            Console.WriteLine(result);
        }
    }
}
