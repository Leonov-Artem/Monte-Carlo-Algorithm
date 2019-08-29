using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public interface IShape
    {
        double Area { get; }
        bool Сontains(Point point);
    }
}
