using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            // Input
            Console.Write("Please enter your weight: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Please enter your height: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Use metric? ");
            string metricString = Console.ReadLine();
            bool metric = bool.Parse(metricString);

            // Computation
            double bmi;
            if (metric)
            {
                // Metric
                bmi = weight / Math.Pow(height, 2);
            }
            else
            {
                // Imperial
                bmi = weight / Math.Pow(height, 2) * 703;
            }

            // Output
            Console.WriteLine("Your BMI is: " + bmi);
        }
    }
}
