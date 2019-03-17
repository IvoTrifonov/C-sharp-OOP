using P03.WildFarm.Animals;
using P03.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.WildFarm
{
    class Program
    {
        public static string[] Mammals = new string[] { "Cat", "Tiger", "Dog", "Mouse" };
        public static string[] Foods = new string[] { "Vegetable", "Fruit", "Meat", "Seeds" };

        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            var command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command.Split();
                var animalType = tokens[0];
                var name = tokens[1];
                var weight = double.Parse(tokens[2]);

                if (Mammals.Contains(animalType))
                {
                    var livingRegion = tokens[3];

                    switch (animalType)
                    {
                        case "Cat":
                            var catBreed = tokens[4];
                            var cat = new Cat(name, weight, 0, livingRegion, catBreed);
                            animals.Add(cat);
                            FeedAnimal(cat);
                            break;
                        case "Tiger":
                            var tigerBreed = tokens[4];
                            var tiger = new Tiger(name, weight, 0, livingRegion, tigerBreed);
                            animals.Add(tiger);
                            FeedAnimal(tiger);
                            break;
                        case "Dog":
                            var dog = new Dog(name, weight, 0, livingRegion);
                            animals.Add(dog);
                            FeedAnimal(dog);
                            break;
                        case "Mouse":
                            var mouse = new Mouse(name, weight, 0, livingRegion);
                            animals.Add(mouse);
                            FeedAnimal(mouse);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    var wingSize = double.Parse(tokens[3]);

                    switch (animalType)
                    {
                        case "Owl":
                            var owl = new Owl(name, weight, 0, wingSize);
                            animals.Add(owl);
                            FeedAnimal(owl);
                            break;
                        case "Hen":
                            var hen = new Hen(name, weight, 0, wingSize);
                            animals.Add(hen);
                            FeedAnimal(hen);
                            break;
                        default:
                            break;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static void FeedAnimal(Animal animal)
        {
            Console.WriteLine(animal.ProduceSound());

            try
            {
                var food = ReadFood();
                animal.Eat(food);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static Food ReadFood()
        {
            var foodArgs = Console.ReadLine().Split();
            var foodName = foodArgs[0];
            var quantity = int.Parse(foodArgs[1]);

            if (Foods.Contains(foodName))
            {
                switch (foodName)
                {
                    case "Vegetable":
                        return new Vegetable(quantity);
                    case "Fruit":
                        return new Fruit(quantity);
                    case "Meat":
                        return new Meat(quantity);
                    case "Seeds":
                        return new Seeds(quantity);
                    default:
                        break;
                }
            }

            return null;
        }
    }
}
