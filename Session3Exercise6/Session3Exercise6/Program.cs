using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Console.Write("(" + i + ", " + j + ")");
                    if (i < 6 || j < 6)
                    {
                        Console.Write(", ");
                    }
                }
            }

            // Variant 1: använd en if-sats i den inre loopen som bara körs om summan av i + j är större än det angivna värdet.
            // Variant 2: ändra loop-villkoret i valfri loop till att jämföra med 8 istället för 6.
        }
    }
}
