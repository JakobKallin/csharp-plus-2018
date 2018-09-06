using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            DateTime current = DateTime.Now;
            int daysToSaturday = 0;
            while (current.ToString("dddd") != "Saturday")
            {
                current = current.AddDays(1);
                daysToSaturday++;
            }

            if (daysToSaturday == 0)
            {
                Console.WriteLine("Saturday is today!");
            }
            else
            {
                Console.WriteLine("Days to Saturday: " + daysToSaturday);
            }
        }
    }
}
