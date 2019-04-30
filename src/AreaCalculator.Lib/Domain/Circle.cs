using System;

namespace AreaCalculator.Lib
{
    public sealed class Circle : IWithSquare
    {
        public Circle(FigureProp radius)
        {
            Radius = radius;
        }

        public FigureProp Radius { get; }

        public FigureProp Square => new FigureProp(Radius.Value * Radius.Value * Math.PI);
    }
}