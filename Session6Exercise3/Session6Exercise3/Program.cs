using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Console.Write("Date: ");
            string dateString = Console.ReadLine();

            DateTime date = DateTime.Parse(dateString);
            Console.WriteLine("Year: " + date.Year);
            Console.WriteLine("Month: " + date.ToString("MMMM"));
            Console.WriteLine("Day: " + date.DayOfWeek);
            Console.WriteLine("Hour: " + date.Hour);
            Console.WriteLine("Day: " + date.Minute);
            Console.WriteLine("Second: " + date.Second);
        }
    }
}
