using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How do I use this machine?");
            StepOne();
        }

        static void StepOne()
        {
            Console.WriteLine("Ask somebody for help!");
            Console.WriteLine("Did they know the answer?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                StepThree();
            }
            else
            {
                StepTwo();
            }
        }

        static void StepTwo()
        {
            Console.WriteLine("Press a button at random!");
            Console.WriteLine("Did it work?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                StepThree();
            }
            else
            {
                StepTwo();
            }
        }

        static void StepThree()
        {
            Console.WriteLine("Problem solved!");
        }
    }
}
