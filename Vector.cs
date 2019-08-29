using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public class Vector
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Vector(Point start, Point end)
        {
            X = end.X - start.X;
            Y = end.Y - start.Y;
        }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static double PseudoscalarProduct(Vector a, Vector b)
            => a.X * b.Y - b.X * a.Y;
    }
}
