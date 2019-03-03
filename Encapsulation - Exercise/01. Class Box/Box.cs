using System;
using System.Collections.Generic;
using System.Text;

namespace P1.Class_Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double SurfaceArea => (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.width * this.height);

        public double Volume => this.length * this.width * this.height;

        public double LateralSurfaceArea => (2 * this.length * this.height) + (2 * this.width * this.height);


    }
}
