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
        public double R { get; private set; }
        public double Area { get; private set; }

        public Semicircle(Point b, Point d)
        {
            Center = new Point(d.X, b.Y);
            R = d.Y - b.Y;
            Area = 0.5 * Math.PI * R * R;
            _boundX = new Boundaries(Center.X, Center.X + R);
            _boundY = new Boundaries(d.Y - 2 * R, d.Y);
        }

        public bool Contains(Point point)
        {
            double x = Math.Sqrt(R * R - Math.Pow(point.Y - Center.Y, 2)) + Center.X;
            return point.X <= x;
        }
    }
}
