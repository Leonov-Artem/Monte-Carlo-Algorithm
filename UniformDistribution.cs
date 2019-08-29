using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public static class UniformDistribution
    {
        public static double GetNum(double lower_bound, double upper_bound)
        {
            var random = new Random();
            return random.NextDouble() * (upper_bound - lower_bound + 1) + lower_bound;
        }
    }
}
