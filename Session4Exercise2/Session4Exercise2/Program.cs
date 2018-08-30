using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise2
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
                result += s[i];
                if (i != s.Length - 1)
                {
                    result += "-";
                }
            }
            Console.WriteLine(result);
        }
    }
}
