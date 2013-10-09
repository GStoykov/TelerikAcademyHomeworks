using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Figure
{
    private double width;
    private double height;

    public double Width
    {
        get 
        {
            return width;
        }
        set 
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("The width must be positive");
            }
            width = value;
        }
    }

    public double Height
    {
        get 
        {
            return height;
        }
        set 
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("The height must be positive");
            }
            height = value;
        }
    }

    public Figure(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public Figure Rotate(Figure figure, double angleForRotate)
    {
        double newWidth = Math.Abs(Math.Cos(angleForRotate)) * figure.Width +
            Math.Abs(Math.Sin(angleForRotate)) * figure.Height;
        double newHeight = Math.Abs(Math.Sin(angleForRotate)) * figure.Width +
            Math.Abs(Math.Cos(angleForRotate)) * figure.Height;
        figure = new Figure(newWidth, newHeight);
        return figure;
    }
}
