using System;

namespace P1.Class_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var box = new Box(length, width, height);

            Console.WriteLine($"Surface Area - {box.SurfaceArea:F2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea:F2}");
            Console.WriteLine($"Volume - {box.Volume:F2}");

        }
    }
}
