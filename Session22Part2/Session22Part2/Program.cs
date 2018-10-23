using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session22Part2
{
    /*interface IAnimal
    {
        void ShowDescription();
        int CalculateAgeInDogYears();
    }*/

    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void ShowDescription()
        {
            Console.WriteLine("This is an animal");
        }

        public int CalculateAgeInDogYears()
        {
            return Age * 7;
        }
    }

    class Dog : Animal
    {
        public override void ShowDescription()
        {
            Console.WriteLine("This is a dog");
        }

        public void Bark()
        {
            Console.WriteLine("Ruff!");
        }
    }

    class Cat : Animal
    {
        public override void ShowDescription()
        {
            Console.WriteLine("This is a cat");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal
            {
                Name = "Kalle",
                Age = 5
            };

            Dog d = new Dog
            {
                Name = "Fido",
                Age = 17
            };

            Cat c = new Cat
            {
                Name = "Jakob",
                Age = 31
            };

            List<Animal> animals = new List<Animal>
            {
                a,
                d,
                c
            };

            foreach (Animal animal in animals)
            {
                animal.ShowDescription();
            }
        }
    }
}
