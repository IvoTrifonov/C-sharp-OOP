using System;
using System.Collections.Generic;
using System.Text;

namespace P03.WildFarm.Animals
{
    public class Mouse : Mammal
    {
        private const double IncreaseWeight = 0.10;

        public Mouse(string name, double weight, int foodEaten, string livingRegion)
            : base(name, weight, foodEaten, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            var foodName = food.GetType().Name;

            if (foodName != "Vegetable" && foodName != "Fruit")
            {
                throw new ArgumentException($"{nameof(Mouse)} does not eat {foodName}!");
            }

            this.Weight += food.Quantity * IncreaseWeight;
            this.FoodEaten += food.Quantity;
        }

        public override string ProduceSound()
        {
            return $"Squeak";
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
