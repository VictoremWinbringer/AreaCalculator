using System;

namespace AreaCalculator.Lib
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            Radius = new GreaterThanZeroDouble(radius);
        }

        public GreaterThanZeroDouble Radius { get; }

        public GreaterThanZeroDouble Square => new GreaterThanZeroDouble(Radius.Value * Radius.Value * Math.PI);
    }
}