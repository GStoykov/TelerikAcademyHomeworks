using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Shape
{
    // Fields
    internal double width;
    internal double height;

    // Properties
    public double Width
    {
        get { return width; }
        set { this.width = value; }
    }   

    public double Height
    {
        get { return height; }
        set { this.height = value; }
    }

    // Constructors
    public Shape(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public Shape(double radius)
    {
        this.width = radius;
    }

    // Methods
    public abstract double CalculateSurface();

}
