using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public class Triangle : IShape
    {
        private Boundaries _boundX;
        private Boundaries _boundY;
        public double Base { get; private set; }
        public double Height { get; private set; }
        public double Area { get; private set; }

        public Triangle(Point b, Point d)
        {
            Base = 2 * (d.Y - b.Y);
            Height = d.X - b.X;
            Area = 0.5 * Base * Height;
            _boundX = new Boundaries(b.X, d.X);
            _boundY = new Boundaries(d.Y - Base, d.Y);
        }

        public bool Contains(Point point)
            => throw new NotImplementedException();
    }
}
