using System;

namespace MonteCarloAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Point(-5, 0);
            var d = new Point(3, 3);
            var figure = new Figure(b, d);

            var exact_area = figure.ExactArea;
            var approximation = figure.MonteCarlo(10e5);

            Console.WriteLine("Точное значение площади: {0}", exact_area);
            Console.WriteLine("Приближенное значение площади: {0}", approximation);
            Console.WriteLine("Относитлеьная погрешность: {0}%", RelativeError(exact_area, approximation));
        }

        static double RelativeError(double exact_value, double approximation)
            => Math.Abs(approximation - exact_value) / exact_value * 100;
    }
}
