using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9Exercise2
{
    class Company
    {
        public string Name;
        public string City;
        public int Age;

        public Company MergeWith(Company otherCompany)
        {
            Company mergedCompany = new Company
            {
                Name = Name + "-" + otherCompany.Name, // eller this.Name + "-" + otherCompany.Name
                City = City, // eller this.City
                Age = 0
            };
            return mergedCompany;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Company 1 name: ");
            string name1 = Console.ReadLine();
            Console.Write("Company 1 city: ");
            string city1 = Console.ReadLine();
            Console.Write("Company 1 age: ");
            int age1 = int.Parse(Console.ReadLine());
            Company company1 = new Company
            {
                Name = name1,
                City = city1,
                Age = age1
            };

            Console.Write("Company 2 name: ");
            string name2 = Console.ReadLine();
            Console.Write("Company 2 city: ");
            string city2 = Console.ReadLine();
            Console.Write("Company 2 age: ");
            int age2 = int.Parse(Console.ReadLine());
            Company company2 = new Company
            {
                Name = name2,
                City = city2,
                Age = age2
            };

            Company merged = company1.MergeWith(company2);
            Console.WriteLine("The merged company is named " + merged.Name + " and based in " + merged.City);
        }
    }
}
