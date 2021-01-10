using System;

namespace Shapes
{
    public class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new NegativeOrZeroArgumentException();
            
            A = a;
            B = b;
            C = c;
        }

        public double Square()
        {
            if (IsRectangular)
                return .5 * A * B;

            return SquareUsingGeronFormula();
        }

        public bool IsRectangular =>
            Math.Abs(Math.Pow(C, 2) - (Math.Pow(A, 2) + Math.Pow(B, 2))) < .00001;

        private double SquareUsingGeronFormula()
        {
            var p = HalfPerimeter();
            var S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return S;
        }
        
        private double HalfPerimeter() =>
            .5 * (A + B + C);
    }
}