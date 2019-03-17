using System;
using System.Collections.Generic;
using System.Text;

namespace P03.WildFarm
{
    public abstract class Food
    {
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; private set; }
    }
}
