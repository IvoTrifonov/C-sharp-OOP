using System;
using System.Collections.Generic;
using System.Text;

namespace P5.PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private Dictionary<string, double> flourModifiers;
        private Dictionary<string, double> bakingModifiers;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.flourModifiers = new Dictionary<string, double>();
            this.bakingModifiers = new Dictionary<string, double>();
            SetFlourModifiers();
            SetBakingModifiers();
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get => this.flourType;

            private set
            {
                if (!this.flourModifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;

            private set
            {
                if (!this.bakingModifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get => this.weight;

            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double GetCalories()
        {
            return (this.Weight * 2) * this.flourModifiers[this.FlourType.ToLower()] * this.bakingModifiers[this.bakingTechnique.ToLower()];
        }

        public void SetFlourModifiers()
        {
            this.flourModifiers.Add("white", 1.5);
            this.flourModifiers.Add("wholegrain", 1.0);
        }

        public void SetBakingModifiers()
        {
            this.bakingModifiers.Add("crispy", 0.9);
            this.bakingModifiers.Add("chewy", 1.1);
            this.bakingModifiers.Add("homemade", 1.0);
        }

    }


}
