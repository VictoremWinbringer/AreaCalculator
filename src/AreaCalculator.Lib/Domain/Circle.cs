using System;

namespace AreaCalculator.Lib
{
    public sealed class Circle : IFigure
    {
        public Circle(Length radius)
        {
            Radius = radius;
        }

        public Length Radius { get; }

        public Length Square => new Length(Radius.Value * Radius.Value * Math.PI);
    }
}