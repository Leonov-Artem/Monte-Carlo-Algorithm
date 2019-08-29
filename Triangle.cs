using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public class Triangle : IShape
    {
        public double Base { get; private set; }
        public double Height { get; private set; }

        public Triangle(Point b, Point d)
        {
            Base = (d.Y - b.Y) * 2;
            Height = d.X - b.X;
        }

        public double Area()
            => 0.5 * Base * Height;

        public bool Сontains(Point point)
            => throw new NotImplementedException();
    }
}
