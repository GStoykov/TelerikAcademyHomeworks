using System;

namespace Abstraction
{
    abstract class Figure
    {
        public virtual double CalcPerimeter()
        {
            throw new NotImplementedException("Object Firuge doesn`t have perimeter.");
        }
        public virtual double CalcSurface()
        {
            throw new NotImplementedException("Object Firuge doesnt`t have surface.");
        }
    }
}
