using System;
using System.Collections.Generic;
using System.Text;

namespace P5.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (value == string.Empty || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public int NumberOfToppings => this.toppings.Count;


        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);

            if (NumberOfToppings > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }

        public double GetTotalCalories()
        {
            double sum = 0;

            foreach (var topping in this.toppings)
            {
                sum += topping.GetCalories();
            }

            return sum + dough.GetCalories();
        }
    }
}
