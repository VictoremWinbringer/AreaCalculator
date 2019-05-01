using System;

namespace AreaCalculator.Lib
{
    public sealed class Circle : IFigure
    {
        public Circle(double radius)
        {
            Radius = new Length(radius);
        }

        public Length Radius { get; }

        public Length Square => new Length(Radius.Value * Radius.Value * Math.PI);
    }
}