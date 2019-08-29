using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public static class UniformDistribution
    {
        public static double GetNum(Boundaries boundaries)
        {
            var random = new Random();
            return random.NextDouble() * (boundaries.Length + 1) + boundaries.Min;
        }
    }
}
