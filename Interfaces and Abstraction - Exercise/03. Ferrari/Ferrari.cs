namespace P3.Ferrari
{
    public class Ferrari : Car, ICarable
    {
        public Ferrari(string driverName)
        {
            this.DriverName = driverName;
        }

        public string Model { get; } = "488-Spider";
        public string DriverName { get; private set; }

        public override string ToString()
        {
            return $"{this.Model}/{this.UseBrakes()}/{this.PushTheGasPedal()}/{this.DriverName}";
        }
    }
}
