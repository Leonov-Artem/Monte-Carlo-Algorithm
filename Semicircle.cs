using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public class Semicircle : IShape
    {
        private Boundaries _boundX;
        private Boundaries _boundY;
        public Point Center { get; private set; }
        public double Radius { get; private set; }
        public double Area { get; private set; }

        public Semicircle(Point b, Point d)
        {
            Center = new Point(d.X, b.Y);
            Radius = d.Y - b.Y;
            Area = 0.5 * Math.PI * Radius * Radius;
            _boundX = new Boundaries(Center.X, Center.X + Radius);
            _boundY = new Boundaries(d.Y - 2 * Radius, d.Y);
        }

        public bool Contains(Point point)
            => throw new NotImplementedException();
    }
}
