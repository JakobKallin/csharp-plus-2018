using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session10
{
    class Product
    {
        public string Serial;
        public string Name;
        public string Description;
        public int Price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Products.txt");
            List<Product> products = new List<Product> { };
            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                Product p = new Product
                {
                    Name = values[1],
                    Description = values[2],
                    Serial = values[0],
                    Price = int.Parse(values[3])
                };
                products.Add(p);
            }

            Console.WriteLine("Följande produkter finns i butiken:");

            foreach (Product p in products)
            {
                Console.WriteLine(p.Serial + ": " + p.Name + " - " + p.Description + " (" + p.Price + " kr)");
            }

            int totalSum = 0;
            while (true)
            {
                Console.Write("Ange serienummer att köpa: ");
                string serialToBuy = Console.ReadLine();

                Console.Write("Ange antal att köpa: ");
                int amountToBuy = int.Parse(Console.ReadLine());

                foreach (Product p in products)
                {
                    if (p.Serial == serialToBuy)
                    {
                        int currentSum = p.Price * amountToBuy;
                        totalSum += currentSum;
                        Console.WriteLine("Please pay " + totalSum + " kr");
                    }
                }
            }
         }
    }
}
