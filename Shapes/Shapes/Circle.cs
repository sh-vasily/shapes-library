using System;

namespace Shapes
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new NegativeOrZeroArgumentException();
            
            Radius = radius;
        }

        public double Radius { get; }

        public double Square() =>
            Math.PI * Math.Pow(Radius, 2);
    }
}