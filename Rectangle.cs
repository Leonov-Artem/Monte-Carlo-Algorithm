using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public class Rectangle : IShape
    {
        public Boundaries boundX;
        public Boundaries boundY;
        public double Length { get; private set; }
        public double Width { get; private set; }
        public double Area { get; private set; }

        public Rectangle(Point b, Point d)
        {
            var triangle = new Triangle(b, d);

            Width = triangle.Base;
            Length = triangle.Height + triangle.Base / 2;
            Area = Length * Width;
            boundX = new Boundaries(b.X, b.X + Length);
            boundY = new Boundaries(d.Y - triangle.Base, d.Y);
        }

        public bool Contains(Point point)
            => throw new NotImplementedException();
    }
}
