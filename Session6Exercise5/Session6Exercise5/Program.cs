using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            string result = DateTime.Today.ToString("dd/MM/yy (a dddd in MMMM)");
            Console.WriteLine(result);
        }
    }
}
