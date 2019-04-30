using System;

namespace AreaCalculator.Lib
{
    public sealed class Triangle : IWithSquare
    {
        public FigureProp ASideLength { get; }
        public FigureProp BSideLength { get; }
        public FigureProp CSideLength { get; }

        public Triangle(FigureProp a, FigureProp b, FigureProp c)
        {
            ASideLength = a;
            BSideLength = b;
            CSideLength = c;
        }

        public FigureProp Square
        {
            get
            {
                var p = (ASideLength.Value + BSideLength.Value + CSideLength.Value) / 2;
                return new FigureProp(Math.Sqrt(p * (p - ASideLength.Value) * (p - BSideLength.Value) *
                                                (p - CSideLength.Value)));
            }
        }
    }
}