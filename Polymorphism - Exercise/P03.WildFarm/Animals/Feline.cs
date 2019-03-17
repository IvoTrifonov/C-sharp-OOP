using System;
using System.Collections.Generic;
using System.Text;

namespace P03.WildFarm.Animals
{
    public abstract class Feline : Mammal
    {
        public Feline(string name, double weight, int foodEaten, string livingRegion, string breed)
            : base(name, weight, foodEaten, livingRegion)
        {
            this.Breed = breed;
        }
        public string Breed { get; private set; }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
