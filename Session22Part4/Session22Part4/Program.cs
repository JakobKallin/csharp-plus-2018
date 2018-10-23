using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session22Part4
{
    interface IPersonA
    {
        string Name { get; set; }
        int Age { get; set; }
        string Summary();
    }

    class StudentA : IPersonA
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        
        public string Summary()
        {
            return Name + " is " + Age + " and has score " + Score;
        }
    }

    class TeacherA : IPersonA
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int HourlySalary { get; set; }

        public string Summary()
        {
            return Name + " is " + Age + " and earns " + HourlySalary + " per hour";
        }
    }

    class AdministratorA : IPersonA
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int MonthlySalary { get; set; }

        public string Summary()
        {
            return Name + " is " + Age + " and earns " + MonthlySalary + " per month";
        }
    }

    class PersonB
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual string Summary()
        {
            return Name + " is " + Age;
        }
    }

    class StudentB : PersonB
    {
        public int Score { get; set; }

        public override string Summary()
        {
            return Name + " is " + Age + " and has score " + Score;
        }
    }

    class TeacherB : PersonB
    {
        public int HourlySalary { get; set; }

        public override string Summary()
        {
            return Name + " is " + Age + " and earns " + HourlySalary + " per hour";
        }
    }

    class AdministratorB : PersonB
    {
        public int MonthlySalary { get; set; }

        public override string Summary()
        {
            return Name + " is " + Age + " and earns " + MonthlySalary + " per month";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void ShowPeopleA(IPersonA[] people)
        {
            foreach (IPersonA p in people)
            {
                Console.WriteLine(p.Summary());
            }
        }

        static void ShowPeopleB(PersonB[] people)
        {
            foreach (PersonB p in people)
            {
                Console.WriteLine(p.Summary());
            }
        }
    }
}
