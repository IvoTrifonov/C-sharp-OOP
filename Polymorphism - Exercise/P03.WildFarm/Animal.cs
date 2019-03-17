using System;
using System.Collections.Generic;
using System.Text;

namespace P03.WildFarm
{
    public abstract class Animal
    {
        public Animal(string name, double weight, int foodEaten)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = foodEaten;
        }

        public string Name { get; private set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public abstract string ProduceSound();

        public abstract void Eat(Food food);

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}";
        }
    }
}
