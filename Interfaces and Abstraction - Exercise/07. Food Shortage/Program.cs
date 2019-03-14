using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P7.FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var buyers = new List<Citizen>();
            var buyerFactury = new BuyerFactury();

            for (int i = 0; i < n; i++)
            {
                var buyerArgs = Console.ReadLine().Split();
                var buyer = buyerFactury.Create(buyerArgs);
                buyers.Add(buyer);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                var currentBuyer = buyers.FirstOrDefault(x => x.Name == command);

                if (currentBuyer != null)
                {
                    currentBuyer.BuyFood();
                }

                command = Console.ReadLine();
            }

            var sum = buyers.Select(x => x.Food).Sum();

            Console.WriteLine(sum);
        }
    }
}
