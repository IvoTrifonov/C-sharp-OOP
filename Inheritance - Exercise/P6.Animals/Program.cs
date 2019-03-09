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

            while (typeOfAnimal != "Beast!")
            {
                var animalArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    if (animalArgs.Length != 3)
                    {
                        throw new ArgumentException("Invalid input!");
                    }

                    var name = animalArgs[0];
                    var age = int.Parse(animalArgs[1]);
                    var gender = animalArgs[2];

                    var animal = new Animal();

                    if (typeOfAnimal == "Cat")
                    {
                        animal = new Cat(name, age, gender);
                    }
                    else if (typeOfAnimal == "Dog")
                    {
                        animal = new Dog(name, age, gender);
                    }
                    else if (typeOfAnimal == "Frog")
                    {
                        animal = new Frog(name, age, gender);
                    }
                    else if (typeOfAnimal == "Kitten")
                    {
                        animal = new Kitten(name, age);
                    }
                    else if (typeOfAnimal == "Tomcat")
                    {
                        animal = new Tomcat(name, age);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid input!");
                    }

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
