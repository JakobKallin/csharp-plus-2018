using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session19Part2
{
    class Building
    {
        private double temperature;
        public double Temperature
        {
            get { return temperature; }
            set
            {
                if (value >= 18 && value <= 24)
                {
                    temperature = value;
                }
                else
                {
                    throw new ArgumentException("Temperature must be between 18 and 24!");
                }
            }
        }

        public Building(double t)
        {
            Temperature = t;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature: ");
            double t = double.Parse(Console.ReadLine());
            try
            {
                Building house = new Building(t);
            }
            catch
            {
                Console.WriteLine("Could not create building!");
            }
        }
    }
}
