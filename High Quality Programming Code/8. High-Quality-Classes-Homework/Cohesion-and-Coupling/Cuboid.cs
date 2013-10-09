using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    public class Cuboid
    {
        private double width;
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentOutOfRangeException("The width must be positive");
                }

                this.width = value;
            }
        }

        private double height;
        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentOutOfRangeException("The height must be positive");
                }

                this.height = value;
            }
        }

        private double depth;
        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentOutOfRangeException("The depth must be positive");
                }
                this.depth = value;
            }
        }

        public Cuboid(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double CalculateVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

    }
}
