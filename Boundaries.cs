using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public class Boundaries
    {
        public double Min { get; private set; }
        public double Max { get; private set; }
        public double Length { get; private set; }

        public Boundaries(double min, double max)
        {
            Min = min;
            Max = max;
            Length = max - min;
        }
    }
}
