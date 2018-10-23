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
        public string Species { get; set; }

        public void ShowDescription()
        {
            Console.WriteLine("This is a " + Species);
        }

        public int CalculateAgeInDogYears()
        {
            return Age * 7;
        }
    }

    class Dog : Animal
    {
    }

    class Cat : Animal
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal
            {
                Name = "Kalle",
                Age = 5,
                Species = "animal"
            };

            Dog d = new Dog
            {
                Name = "Fido",
                Age = 17,
                Species = "dog"
            };

            Cat c = new Cat
            {
                Name = "Jakob",
                Age = 31,
                Species = "cat"
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
