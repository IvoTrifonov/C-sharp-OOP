using System;
using System.Collections.Generic;
using System.Linq;

namespace P4.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            var products = new List<Product>();

            try
            {
                var peopleArgs = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                var productsArgs = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < peopleArgs.Length; i++)
                {
                    var currentPerson = peopleArgs[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                    var personName = currentPerson[0];
                    var money = decimal.Parse(currentPerson[1]);
                    var person = new Person(personName, money);
                    people.Add(person);
                }

                for (int i = 0; i < productsArgs.Length; i++)
                {
                    var currentProduct = productsArgs[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                    var productName = currentProduct[0];
                    var price = decimal.Parse(currentProduct[1]);
                    var product = new Product(productName, price);
                    products.Add(product);
                }

                string command = Console.ReadLine();

                while (command != "END")
                {
                    var purchaseArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    var personName = purchaseArgs[0];
                    var productName = purchaseArgs[1];

                    var buyer = people.FirstOrDefault(x => x.Name == personName);
                    var product = products.FirstOrDefault(x => x.Name == productName);

                    if (buyer.Money - product.Cost >= 0)
                    {
                        Console.WriteLine($"{personName} bought {productName}");
                        buyer.Money -= product.Cost;
                        buyer.Bag.Add(new Product(productName, product.Cost));
                    }
                    else
                    {
                        Console.WriteLine($"{personName} can't afford {productName}");
                    }

                    command = Console.ReadLine();
                }

                foreach (var p in people)
                {
                    Console.WriteLine($"{p.Name} - {p.ToString()}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
