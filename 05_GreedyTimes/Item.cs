using System;
using System.Collections.Generic;
using System.Text;

namespace P05_GreedyTimes
{
    public class Item
    {
        public Item(string name)
        {
            this.Name = name;
            this.Quantity = 0;
        }

        public string Name { get; private set; }

        public long Quantity { get; set; }
    }
}
