using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 0.56;

            Console.WriteLine("Celsius: " + celsius);

            // Variant 1: Skapa en ny variabel för varje steg i beräkningen och sätt dess värde till det föregående värdet kombinerat med nästa operator.
            // Variant 2: "Vänd på" beräkningen genom att istället först dividera med 0.56 och sedan addera 32.
            // Variant 3: Division av två heltal ger ett annat heltal tillbaka, vilket innebär avrundning. Att ange decimalpunkt på något av talen (exempelvis "5.0 / 9") gör att beräkningen ger tillbaka ett decimaltal istället. Även "type casting" går att använda.
        }
    }
}
