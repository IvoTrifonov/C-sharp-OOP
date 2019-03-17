using System;
using System.Collections.Generic;
using System.Text;

namespace P1.Vehicles
{
    class Bus : Vehicle
    {
        private const double IncreaseConsumption = 1.4;

        public Bus(double fuelQuantuty, double fuelConsumption, int tankCapacity)
                    : base(fuelQuantuty, fuelConsumption + IncreaseConsumption, tankCapacity)
        {
        }



        public string DriveEmpty(double distance)
        {
            this.FuelConsumption -= IncreaseConsumption;
            return base.Drive(distance);
        }
    }
}
