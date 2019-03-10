using System;
using System.Collections.Generic;

namespace P6.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            var typeOfAnimal = Console.ReadLine();
            var animalFactory = new AnimalFactory();

            while (typeOfAnimal != "Beast!")
            {
                var animalArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    var animal = animalFactory.Create(animalArgs, typeOfAnimal);

                    animals.Add(animal);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                typeOfAnimal = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Print());
            }
        }
    }
}
