using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = false || true;
            bool b = false || false || true;
            bool c = true && false;
            bool d = true && true && false;
            bool e = (true && false) || (true || false);
            bool f = !true || !false;
            bool g = !true && !false;
            bool h = !(true || false);
            bool i = !(true || false) && !false;
            bool j = !(!(true && false));
        }
    }
}
