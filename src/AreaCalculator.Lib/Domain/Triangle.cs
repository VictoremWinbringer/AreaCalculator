using System;
using System.Linq;

namespace AreaCalculator.Lib
{
    interface ITriangle : IFigure
    {
        bool IsRightAngled { get; }
    }

    public sealed class Triangle : ITriangle
    {
        public Length ASideLength { get; }
        public Length BSideLength { get; }
        public Length CSideLength { get; }

        public Triangle(double a, double b, double c)
        {
            if (!((a < b + c) &&
                  (b < a + c) &&
                  (c < a + b)))
                throw new TriangleNotExistException(a, b, c);

            ASideLength = new Length(a);
            BSideLength = new Length(b);
            CSideLength = new Length(c);
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