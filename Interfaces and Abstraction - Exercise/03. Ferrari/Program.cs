using System;

namespace P3.Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            var driverName = Console.ReadLine();
            var ferrari = new Ferrari(driverName);

            Console.WriteLine(ferrari);
        }
    }
}
