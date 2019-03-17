using System;

namespace P1.Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQantity;

        public Vehicle(double fuelQuantuty, double fuelConsumption, int tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantuty;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get => this.fuelQantity;

            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQantity = 0;
                }
                else
                {
                    this.fuelQantity = value;
                }
            }
        }

        public double FuelConsumption { get; protected set; }

        public double TankCapacity { get; private set; }

        public virtual string Drive(double distance)
        {
            if (distance * this.FuelConsumption <= this.FuelQuantity)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }

            double totalFuelAmount = fuelAmount + this.FuelQuantity;

            if (totalFuelAmount > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
            }

            this.FuelQuantity += fuelAmount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
