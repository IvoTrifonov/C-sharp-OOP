namespace P1.Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantuty, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantuty;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public string Drive(double distance)
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
            this.FuelQuantity += fuelAmount;
        }
    }
}
