using System;
using System.Collections.Generic;
using System.Text;

namespace P03.WildFarm.Animals
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight, int foodEaten, double wingSize)
            : base(name, weight, foodEaten)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; private set; }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
