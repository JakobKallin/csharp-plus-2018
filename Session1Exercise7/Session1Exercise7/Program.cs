using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            int s = seconds % 60;
            int m = (seconds / 60) % 60;
            int h = seconds / (60 * 60);
            string timer = h + "h, " + m + "m, " + s + "s";

            Console.WriteLine(timer);
        }
    }
}
