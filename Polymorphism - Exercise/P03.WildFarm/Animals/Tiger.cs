using System;
using System.Collections.Generic;
using System.Text;

namespace P03.WildFarm.Animals
{
    public class Tiger : Feline
    {
        private const double IncreaseWeight = 1.00;

        public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed)
            : base(name, weight, foodEaten, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            var foodName = food.GetType().Name;

            if (foodName != "Meat")
            {
                throw new ArgumentException($"{nameof(Tiger)} does not eat {foodName}!");
            }

            this.Weight += food.Quantity * IncreaseWeight;
            this.FoodEaten += food.Quantity;
        }

        public override string ProduceSound()
        {
            return $"ROAR!!!";
        }
    }
}
