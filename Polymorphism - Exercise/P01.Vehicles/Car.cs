using System;
using System.Collections.Generic;
using System.Text;

namespace P1.Vehicles
{
    public class Car : Vehicle
    {
        private const double IncreaseConsumption = 0.9;

        public Car(double fuelQuantuty, double fuelConsumption)
            : base(fuelQuantuty, fuelConsumption + IncreaseConsumption)
        {
        }


    }
}
