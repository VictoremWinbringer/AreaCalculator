using System;

namespace AreaCalculator.Lib
{
    public sealed class Circle : Shape
    {
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius));
            Radius = radius;
        }

        private double Radius { get; }

        public override double Area => Radius * Radius * Math.PI;

        public override double Perimeter => Radius * 2 * Math.PI;
    }
}