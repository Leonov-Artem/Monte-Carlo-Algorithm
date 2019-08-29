using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public interface IShape
    {
        double Area { get; }
        bool Contains(Point point);
    }
}
