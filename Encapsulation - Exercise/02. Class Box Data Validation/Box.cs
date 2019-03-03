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
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        private bool IsValid(double value)
        {
            if (value <= 0)
            {
                return false;
            }
            return true;
        }

        public double GetSurfaceArea() => (2 * this.Length * this.Width) +
            (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

        public double GetVolume() => this.Length * this.Width * this.Height;

        public double GetLateralSurfaceArea() => (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
    }
}
