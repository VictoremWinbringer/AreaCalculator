using System;
using System.Linq;

namespace AreaCalculator.Lib
{
    public sealed class Triangle : IWithSquare
    {
        public Length ASideLength { get; }
        public Length BSideLength { get; }
        public Length CSideLength { get; }

        public Triangle(Length a, Length b, Length c)
        {
            ASideLength = a;
            BSideLength = b;
            CSideLength = c;
        }

        public Length Square
        {
            get
            {
                var p = (ASideLength.Value + BSideLength.Value + CSideLength.Value) / 2;
                return new Length(Math.Sqrt(p * (p - ASideLength.Value) * (p - BSideLength.Value) *
                                                (p - CSideLength.Value)));
            }
        }

        public bool IsRightAngled
        {
            get
            {
                var sides = new[]
                    {
                        ASideLength,
                        BSideLength,
                        CSideLength
                    }.OrderByDescending(fp => fp.Value)
                    .ToArray();
                
                var c = sides[0].Value;
                var b = sides[1].Value;
                var a = sides[2].Value;
                
                return Math.Abs((c * c) - (a * a + b * b)) < 0.000001;
            }
        }
    }
}