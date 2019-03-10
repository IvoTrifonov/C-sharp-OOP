using System;

namespace P6.Animals
{
    public class AnimalFactory
    {
        public Animal Create(string[] animalArgs, string typeOfAnimal)
        {
            if (animalArgs.Length != 3)
            {
                throw new ArgumentException("Invalid input!");
            }

            var name = animalArgs[0];
            var age = int.Parse(animalArgs[1]);
            var gender = animalArgs[2];

            var animal = new Animal();

            switch (typeOfAnimal)
            {
                case "Cat":
                    animal = new Cat(name, age, gender);
                    break;
                case "Dog":
                    animal = new Dog(name, age, gender);
                    break;
                case "Frog":
                    animal = new Frog(name, age, gender);
                    break;
                case "Kitten":
                    animal = new Kitten(name, age);
                    break;
                case "Tomcat":
                    animal = new Tomcat(name, age);
                    break;

                default:
                    throw new ArgumentException("Invalid input!");
            }

            return animal;
        }
    }
}
