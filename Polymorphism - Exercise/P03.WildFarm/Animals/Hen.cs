using System;
using System.Collections.Generic;
using System.Text;

namespace P03.WildFarm.Animals
{
    public class Hen : Bird
    {
        private const double IncreaseWeight = 0.35;

        public Hen(string name, double weight, int foodEaten, double wingSize)
            : base(name, weight, foodEaten, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            this.Weight += food.Quantity * IncreaseWeight;
            this.FoodEaten += food.Quantity;
        }

        public override string ProduceSound()
        {
            return $"Cluck";
        }
    }
}
