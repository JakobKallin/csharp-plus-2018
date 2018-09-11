using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter name 1: ");
            string name1 = Console.ReadLine();
            Console.Write("Please enter height 1: ");
            double height1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter weight 1: ");
            double weight1 = double.Parse(Console.ReadLine());
            double bmi1 = BMI(weight1, height1);

            Console.Write("Please enter name 2: ");
            string name2 = Console.ReadLine();
            Console.Write("Please enter height 2: ");
            double height2 = double.Parse(Console.ReadLine());
            Console.Write("Please enter weight 2: ");
            double weight2 = double.Parse(Console.ReadLine());
            double bmi2 = BMI(weight2, height2);

            if (bmi1 > bmi2)
            {
                Console.WriteLine("Highest BMI is: " + bmi1);
                Console.WriteLine("Person: " + name1);
            }
            else
            {
                Console.WriteLine("Highest BMI is: " + bmi2);
                Console.WriteLine("Person: " + name2);
            }

            double averageBmi = BMI(70, 1.70);
        }

        static double BMI(double weight, double height)
        {
            double result = weight / Math.Pow(height, 2);
            return result;
        }

        static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
