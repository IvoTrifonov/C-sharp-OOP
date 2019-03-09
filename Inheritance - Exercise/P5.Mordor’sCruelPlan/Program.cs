using P5.Mordor_sCruelPlan.Foods;
using P5.Mordor_sCruelPlan.Moods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P5.Mordor_sCruelPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            var foods = new List<Food>();
            var foodFactory = new FoodFactory();
            var foodsInput = Console.ReadLine().Split();

            foreach (var food in foodsInput)
            {
                var currentFood = foodFactory.GetFood(food);
                foods.Add(currentFood);
            }

            var happinessFood = foods.Select(x => x == null ? -1 : x.Happiness).Sum();

            Console.WriteLine(happinessFood);

            if (happinessFood < -5)
            {
                Console.WriteLine(nameof(Angry));
            }
            else if (happinessFood >= -5 && happinessFood <= 0)
            {
                Console.WriteLine(nameof(Sad));
            }
            else if (happinessFood >= 1 && happinessFood <= 15)
            {
                Console.WriteLine(nameof(Happy));
            }
            else if (happinessFood > 15)
            {
                Console.WriteLine(nameof(JavaScript));
            }
        }
    }
}
