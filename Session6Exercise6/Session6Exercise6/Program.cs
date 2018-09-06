using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            DateTime gbgTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Central European Standard Time");
            DateTime nycTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "US Eastern Standard Time");
            TimeSpan difference = gbgTime - nycTime;

            // The difference is sometimes not an exact integer, so round it just to be sure.
            double hours = Math.Round(difference.TotalHours);

            Console.WriteLine(hours);
        }
    }
}
