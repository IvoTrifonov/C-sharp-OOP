using System;
using System.Linq;

namespace P5.PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var pizzaArgs = Console.ReadLine().Split();
                var pizzaName = pizzaArgs[1];
                var doughArgs = Console.ReadLine().Split();
                var doughFlourType = doughArgs[1];
                var doughBakingTechnique = doughArgs[2];
                var pizzaWeight = double.Parse(doughArgs[3]);

                var dough = new Dough(doughFlourType, doughBakingTechnique, pizzaWeight);
                var pizza = new Pizza(pizzaName, dough);

                var command = Console.ReadLine();

                while (command != "END")
                {
                    var toppingArgs = command.Split();
                    var toppingName = toppingArgs[1];
                    var toppingWeight = double.Parse(toppingArgs[2]);
                    var topping = new Topping(toppingName, toppingWeight);

                    pizza.AddTopping(topping);

                    command = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
