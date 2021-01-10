using System;

namespace Shapes
{
    public class NegativeOrZeroArgumentException : ArgumentException
    {
        public NegativeOrZeroArgumentException() : base("One of triangles side is negative or zero...") { }
    }
}