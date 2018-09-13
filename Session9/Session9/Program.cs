using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public double Weight;
        public double Height;

        public double BMI()
        {
            double result = Weight / (Height * Height);
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person
            {
                FirstName = "Brad",
                LastName = "Pitt",
                Age = 55,
                Weight = 80,
                Height = 1.85
            };
            Person p2 = new Person
            {
                FirstName = "Jakob",
                LastName = "Kallin",
                Age = 31,
                Weight = 75,
                Height = 1.95
            };

            double bradBmi = p1.BMI();
            double jakobBmi = p2.BMI();
        }
    }
}
