using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session22Exercise1
{
    interface IProduct
    {
        string Name { get; set; }
        int Price { get; set; }
    }

    class Food : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }
        public double Protein { get; set; }
    }

    class Car : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Horsepowers { get; set; }
        public string Color { get; set; }
    }

    class Shoe : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
    }

    class Program
    {
        static int TotalPrice(IProduct[] products)
        {
            int sum = 0;
            foreach (IProduct p in products)
            {
                sum += p.Price;
            }
            return sum;
        }

        static void Main(string[] args)
        {

        }
    }
}
