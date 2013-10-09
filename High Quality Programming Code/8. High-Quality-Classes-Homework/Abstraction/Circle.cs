using System;

namespace Abstraction
{
    class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get 
            {
                return radius;
            }
            set 
            {
                if (value <= 0.0)
                {
                    throw new ArgumentOutOfRangeException("The radius must be positive number");
                }
                radius = value;
            }
        }
        

        public Circle(double radius)
        {
            if (radius <= 0.0)
            {
                throw new ArgumentOutOfRangeException("The radius must be positive number");
            }
            this.Radius = radius;
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
