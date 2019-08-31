using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Point Generate(Boundaries boundX, Boundaries boundY)
        {
            double x = UniformDistribution.GetNum(boundX);
            double y = UniformDistribution.GetNum(boundY);
            return new Point(x, y);
        }
    }
}
