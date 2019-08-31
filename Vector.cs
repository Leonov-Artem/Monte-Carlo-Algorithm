using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public class Vector
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Length { get; private set; }

        public Vector(Point start, Point end)
        {
            X = end.X - start.X;
            Y = end.Y - start.Y;
            Length = Math.Sqrt(X * X + Y * Y);
        }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
            Length = Math.Sqrt(X * X + Y * Y);
        }

        public static double PseudoscalarProduct(Vector a, Vector b)
            => a.X * b.Y - b.X * a.Y;
    }
}
