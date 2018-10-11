using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session18
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] lines = GetLines(text);
            string[] sortedLines = SortLines(lines);
            PrintLines(sortedLines);
        }

        static string[] GetLines(string s)
        {
            return s.Split('.');
        }

        static string[] SortLines(string[] lines)
        {
            return lines.OrderBy(s => s.Length).ToArray();
        }

        static void PrintLines(string[] lines)
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
