using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Console.WriteLine("Leap years since 2000: ");
            for (int i = 2000; i <= 2018; i++)
            {
                bool isLeapYear = DateTime.IsLeapYear(i);
                if (isLeapYear)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
