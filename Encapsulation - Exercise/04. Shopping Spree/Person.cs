using System;
using System.Collections.Generic;
using System.Text;

namespace P4.ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<Product>();
        }

        public List<Product> Bag { get; private set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Money cannot be negative");
                }

                this.money = value;
            }
        }

        public override string ToString()
        {
            if (Bag.Count > 0)
            {
                return string.Join(", ", Bag);
            }

            return $"Nothing bought";
        }
    }
}
