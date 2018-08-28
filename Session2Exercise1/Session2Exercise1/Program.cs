using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter password: ");
            string password = Console.ReadLine();
            if (password == "secret123")
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }
    }
}
