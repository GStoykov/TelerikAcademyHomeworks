using System;

namespace Abstraction
{
    class Rectangle : Figure
    {
        private double width;

        public double Width
        {
            get 
            {
                return width;
            }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentOutOfRangeException("Rectangle`s width must be positive");
                }
                width = value;
            }
        }

        private double height;

        public double Height
        {
            get 
            {
                return height;
            }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentOutOfRangeException("Rectangle`s height must be positive");
                }
                height = value;
            }
        }
        

        public Rectangle(double width, double height)
        {
            if (width <= 0.0 || height <= 0.0)
            {
                throw new ArgumentOutOfRangeException("Rectangle`s sides must be positive");
            }
            this.Width = width;
            this.Height = height;
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
