using System;

namespace P1.Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            var carArgs = Console.ReadLine().Split();
            var carFuelQuantity = double.Parse(carArgs[1]);
            var carFuelConsumption = double.Parse(carArgs[2]);
            var carTankCapacity = int.Parse(carArgs[3]);

            var car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);

            var truckArgs = Console.ReadLine().Split();
            var truckFuelQuantity = double.Parse(truckArgs[1]);
            var truckFuelConsumption = double.Parse(truckArgs[2]);
            var truckTankCapacity = int.Parse(truckArgs[3]);

            var truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);

            var busArgs = Console.ReadLine().Split();
            var busFuelQuantity = double.Parse(busArgs[1]);
            var busFuelConsumption = double.Parse(busArgs[2]);
            var busTankCapacity = int.Parse(busArgs[3]);

            var bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var vehicleArgs = Console.ReadLine().Split();
                var command = vehicleArgs[0];
                var vehicleType = vehicleArgs[1];
                double amount = double.Parse(vehicleArgs[2]);

                try
                {
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
                    else if (vehicleType == "Truck")
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
                    else if (vehicleType == "Bus")
                    {
                        if (command == "Drive")
                        {
                            Console.WriteLine(bus.Drive(amount));
                        }
                        else if (command == "DriveEmpty")
                        {
                            Console.WriteLine(bus.DriveEmpty(amount));
                        }
                        else
                        {
                            truck.Refuel(amount);
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
