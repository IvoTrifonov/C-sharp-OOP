using System;
using System.Collections.Generic;
using System.Text;

namespace P03.WildFarm.Animals
{
    public class Dog : Mammal
    {
        private const double IncreaseWeight = 0.40;

        public Dog(string name, double weight, int foodEaten, string livingRegion)
            : base(name, weight, foodEaten, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            var foodName = food.GetType().Name;

            if (foodName != "Meat")
            {
                throw new ArgumentException($"{nameof(Dog)} does not eat {foodName}!");
            }

            this.Weight += food.Quantity * IncreaseWeight;
            this.FoodEaten += food.Quantity;
        }

        public override string ProduceSound()
        {
            return $"Woof!";
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
