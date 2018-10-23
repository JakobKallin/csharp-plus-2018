using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session22
{
    interface IProduct
    {
        string Name { get; set; }
        double CalculateVolume();
        void DoSomething();
    }

    class Box : IProduct
    {
        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }

        public double CalculateVolume()
        {
            return Width * Height * Depth;
        }

        public void DoSomething()
        {
            Console.Write("Hello");
        }
    }

    class Ball : IProduct
    {
        public string Name { get; set; }
        public double Radius { get; set; }

        public double CalculateVolume()
        {
            return (Math.Pow(Radius, 3) * Math.PI * 4) / 3;
        }

        public void DoSomething()
        {
            Console.Write("Goodbye");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box smallBox = new Box
            {
                Name = "Shoebox",
                Width = 10,
                Height = 20,
                Depth = 15
            };

            Box largeBox = new Box
            {
                Name = "Banana box",
                Width = 50,
                Height = 40,
                Depth = 80
            };

            Ball tennisBall = new Ball
            {
                Name = "Tennis ball",
                Radius = 7.5
            };

            Ball football = new Ball
            {
                Name = "Ball for playing soccer",
                Radius = 10
            };

            List<IProduct> products = new List<IProduct>
            {
                smallBox,
                largeBox,
                tennisBall,
                football
            };
            double totalVolume = CalculateTotalVolume(products);
        }

        static double CalculateTotalVolume(List<IProduct> products)
        {
            double totalVolume = 0;
            foreach (IProduct p in products)
            {
                totalVolume += p.CalculateVolume();
                p.DoSomething();
                Console.WriteLine(p.Name);
            }
            return totalVolume;
        }
    }
}
