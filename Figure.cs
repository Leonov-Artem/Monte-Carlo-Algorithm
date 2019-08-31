using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloAlgorithm
{
    public class Figure
    {
        private Rectangle rectangle;
        private Triangle triangle;
        private Semicircle semicircle;
        public double ExactArea { get; private set; }

        public Figure(Point b, Point d)
        {
            rectangle = new Rectangle(b, d);
            triangle = new Triangle(b, d);
            semicircle = new Semicircle(b, d);
            ExactArea = triangle.Area + semicircle.Area;
        }

        public double MonteCarlo(double amount_points)
        {
            int hit_count = GetHitCount(amount_points);
            return (hit_count / amount_points) * rectangle.Area;
        }

        private int GetHitCount(double amount_points)
        {
            int hit_count = 0;

            for (int i = 0; i < amount_points; i++)
            {
                var point = Point.Generate(rectangle.boundX, rectangle.boundY);

                if (IsBetween(triangle.boundX, point.X))
                {
                    if (triangle.Contains(point))
                        hit_count++;
                }
                else 
                {
                    if (semicircle.Contains(point))
                        hit_count++;
                }
            }

            return hit_count;
        }

        private bool IsBetween(Boundaries boundaries, double num)
            => num >= boundaries.Min && num < boundaries.Max;
    }
}
