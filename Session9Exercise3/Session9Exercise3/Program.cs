using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9Exercise3
{
    class Person
    {
        public string Name;
        public int Age;
        public double Wealth;
        public double Salary;

        public void PaySalary()
        {
            Wealth += Salary;
        }

        public void WinLottery(int prize)
        {
            Wealth += prize;
        }

        public void CelebrateBirthday()
        {
            Age += 1;
            Wealth += 500;
        }

        public void Show()
        {
            Console.WriteLine(Age + "-åriga " + Name + " har en lön på " + Salary + " kronor och " + Wealth + " kronor på banken.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person {
                Name = "Brad Pitt",
                Age = 55,
                Wealth = 500000,
                Salary = 40000
            };
            p.PaySalary();
            p.CelebrateBirthday();
            p.WinLottery(2000);
            p.Show();
        }
    }
}
