using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session22Exercise2
{
    interface IProduct
    {
        string Name { get; set; }
        int Price { get; set; }
        void Enlarge(int steps);
    }

    class Food : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }
        public double Protein { get; set; }

        public void Enlarge(int steps) {
            // Each "step" is 50 grams of fat
            Fat += steps * 50;
        }
    }

    class Car : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Horsepowers { get; set; }
        public string Color { get; set; }

        public void Enlarge(int steps)
        {
            // Each "step" is 20 horsepowers
            Horsepowers += steps * 20;
        }
    }

    class Shoe : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }

        public void Enlarge(int steps)
        {
            // Each "step" is a single shoe size
            Size += steps;
        }
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

        static void Supersize(IProduct[] products)
        {
            foreach (IProduct p in products)
            {
                p.Enlarge(2);
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
