using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Day: ");
            int day = int.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime birth = new DateTime(year, month, day);
            TimeSpan span = today - birth;
            int days = span.Days;

            Console.WriteLine("Days since birth: " + days);
        }
    }
}
