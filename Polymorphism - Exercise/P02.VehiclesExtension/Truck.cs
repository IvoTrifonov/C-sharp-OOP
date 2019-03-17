using System;
using System.Collections.Generic;
using System.Text;

namespace P1.Vehicles
{
    class Truck : Vehicle
    {
        private const double IncreaseConsumption = 1.6;
        private const double amountWasted = 0.05;

        public Truck(double fuelQuantuty, double fuelConsumption, int tankCapacity)
            : base(fuelQuantuty, fuelConsumption + IncreaseConsumption, tankCapacity)
        {
        }

        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount);
            this.FuelQuantity -= fuelAmount * amountWasted;
        }
    }
}
