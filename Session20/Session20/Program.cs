using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session20
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateBMI();
            CalculateWeirdName();
        }

        static void CalculateBMI()
        {
            Console.Write("Weight: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine("Your BMI is: " + bmi);
        }

        static void CalculateWeirdName()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            string alteredName = "";
            foreach (char c in name)
            {
                if (c == 'a' || c == 'e' || c == 'o' || c == 'i' || c == 'u' || c == 'y')
                {
                    alteredName += 'a';
                }
                else
                {
                    alteredName += c;
                }
            }
            Console.WriteLine("Your name with only A vowels is: " + alteredName);
        }
    }
}
