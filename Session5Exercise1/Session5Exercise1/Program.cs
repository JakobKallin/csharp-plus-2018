using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Text: ");
            string text = Console.ReadLine();

            if (text.StartsWith("Classified: "))
            {
                int start = "Classified: ".Length;
                text = text.Substring(start);
                text = text.Replace("Area 51", "[AN UNDISCLOSED LOCATION]");
            }

            Console.WriteLine(text);
        }
    }
}
