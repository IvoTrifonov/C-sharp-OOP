using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05_GreedyTimes
{
    public class OutputProccessor
    {
        public OutputProccessor()
        {

        }

        public string Output(Bag bag)
        {
            var sb = new StringBuilder();

            foreach (var category in bag.Categories)
            {
                sb.AppendLine($"<{category.Name}> ${category.getSum()}");
                foreach (var item in category.Items.OrderByDescending(x => x.Name).ThenBy(y => y.Quantity))
                {
                    sb.AppendLine($"##{item.Name} - {item.Quantity}");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
