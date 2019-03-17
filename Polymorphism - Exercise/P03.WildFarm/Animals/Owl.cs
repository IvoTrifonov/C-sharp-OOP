using System;
using System.Collections.Generic;
using System.Text;

namespace P03.WildFarm.Animals
{
    public class Owl : Bird
    {
        private const double IncreaseWeight = 0.25;

        public Owl(string name, double weight, int foodEaten, double wingSize)
            : base(name, weight, foodEaten, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            var foodName = food.GetType().Name;

            if (foodName != "Meat")
            {
                throw new ArgumentException($"{nameof(Owl)} does not eat {foodName}!");
            }

            this.Weight += food.Quantity * IncreaseWeight;
            this.FoodEaten += food.Quantity;
        }

        public override string ProduceSound()
        {
            return $"Hoot Hoot";
        }
    }
}
