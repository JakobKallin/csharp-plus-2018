using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bank: ");
            int cash = int.Parse(Console.ReadLine());

            Console.Write("Cash: ");
            int bank = int.Parse(Console.ReadLine());

            int total = cash + bank;
            Console.WriteLine("You have a total of $" + total);
        }
    }
}
