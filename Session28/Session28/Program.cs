using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session28
{
    class ParseIntResult
    {
        public int Value;
        public bool Success;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            ParseIntResult result = CustomParseInt(input);
            if (result.Success)
            {
                Console.WriteLine("You typed the number: " + result.Value);
            }
            else
            {
                Console.WriteLine("You did not type a valid number!");
            }
        }

        public static ParseIntResult CustomParseInt(string s)
        {
            try
            {
                ParseIntResult r = new ParseIntResult
                {
                    Value = int.Parse(s),
                    Success = true
                };
                return r;
            }
            catch
            {
                ParseIntResult r = new ParseIntResult
                {
                    Value = 0,
                    Success = false
                };
                return r;
            }
        }
    }
}
