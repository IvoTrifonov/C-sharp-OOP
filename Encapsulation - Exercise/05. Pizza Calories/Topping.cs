using System;
using System.Collections.Generic;
using System.Text;

namespace P5.PizzaCalories
{
    public class Topping
    {
        private double weight;
        private string type;
        private Dictionary<string, double> typeModifiers;

        public Topping(string type, double weight)
        {
            this.typeModifiers = new Dictionary<string, double>();
            SetTypeModifiers();
            this.Type = type;
            this.Weight = weight;
        }

        public double Weight
        {
            get => this.weight;

            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public string Type
        {
            get => this.type;

            private set
            {
                if (!typeModifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public double GetCalories()
        {
            return (this.Weight * 2) * this.typeModifiers[this.Type.ToLower()];
        }

        private void SetTypeModifiers()
        {
            this.typeModifiers.Add("meat", 1.2);
            this.typeModifiers.Add("veggies", 0.8);
            this.typeModifiers.Add("cheese", 1.1);
            this.typeModifiers.Add("sauce", 0.9);
        }
    }
}
