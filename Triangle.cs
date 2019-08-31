using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public class Triangle : IShape
    {
        public Boundaries boundX;
        public Boundaries boundY;
        private Point d, b, e;
        public double Base { get; private set; }
        public double Height { get; private set; }
        public double Area { get; private set; }

        public Triangle(Point b, Point d)
        {
            Base = 2 * (d.Y - b.Y);
            Height = d.X - b.X;
            Area = 0.5 * Base * Height;

            this.b = b;
            this.d = d;
            this.e = new Point(d.X, d.Y - Base);

            boundX = new Boundaries(b.X, d.X);
            boundY = new Boundaries(d.Y - Base, d.Y);
        }

        public bool Contains(Point point)
        {
            var be = new Vector(b, e);
            var bd = new Vector(b, d);
            var bx = new Vector(b, point);
            return Vector.PseudoscalarProduct(be, bx) >= 0 && 
                   Vector.PseudoscalarProduct(bx, bd) >= 0;
        }
    }
}
