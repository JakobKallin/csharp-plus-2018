using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool textIsLarge = IsLarge("hello");
            bool numberIsLarge = IsLarge(5000);
            bool booleanIsLarge = IsLarge(true);
        }

        static bool IsLarge(string s)
        {
            return s.Length > 50;
        }

        static bool IsLarge(int i)
        {
            return i > 1000;
        }

        static bool IsLarge(bool b)
        {
            return b == true;
        }
    }
}
