using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session20Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = ReadString("Enter first name: ");
            string lastName = ReadString("Enter last name: ");
            string city = ReadString("Enter city: ");
            string nickname = ReadString("Enter nickname: ");
        }

        private static string ReadString(string prompt)
        {
            Console.Write(prompt);
            string result = Console.ReadLine();
            return result;
        }
    }
}
