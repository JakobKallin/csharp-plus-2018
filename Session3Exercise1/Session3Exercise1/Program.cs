using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter max number: ");
            int max = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 1; i <= max; i++)
            {
                message += i + ", ";
            }
            message += "go!";
            Console.WriteLine(message);
        }
    }
}
