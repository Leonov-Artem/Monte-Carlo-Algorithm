using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public class Rectangle : IShape
    {
        private double _minX;
        private double _maxX;
        private double _minY;
        private double _maxY;
        public double Length { get; private set; }
        public double Width { get; private set; }

        public Rectangle(Point b, Point d)
        {
            _minX = b.X;
            _maxY = d.Y;
            _maxX = _minX + (d.X - b.X) + (d.Y - b.Y);
            _minY = _maxY - 2 * (d.Y - b.Y);

            Length = _maxX - _minX;
            Width = _maxY - _minY;
        }

        public double Area()
            => Length * Width;

        public bool Сontains(Point point)
            => throw new NotImplementedException();
    }
}
