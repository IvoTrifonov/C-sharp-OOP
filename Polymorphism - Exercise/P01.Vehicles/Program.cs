using System;

namespace P1.Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            var carArgs = Console.ReadLine().Split();
            var car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]));

            var truckArgs = Console.ReadLine().Split();
            var truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var vehicleArgs = Console.ReadLine().Split();
                var command = vehicleArgs[0];
                var vehicleType = vehicleArgs[1];
                double amount = double.Parse(vehicleArgs[2]);

                if (vehicleType == "Car")
                {
                    if (command == "Drive")
                    {
                        Console.WriteLine(car.Drive(amount));
                    }
                    else
                    {
                        car.Refuel(amount);
                    }
                }
                else
                {
                    if (command == "Drive")
                    {
                        Console.WriteLine(truck.Drive(amount));
                    }
                    else
                    {
                        truck.Refuel(amount);
                    }
                }

            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}
