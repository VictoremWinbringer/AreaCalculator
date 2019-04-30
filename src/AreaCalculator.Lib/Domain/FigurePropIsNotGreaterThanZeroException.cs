using System;

namespace AreaCalculator.Lib
{
    public sealed class FigurePropIsNotGreaterThanZeroException : Exception
    {
        public double Radius { get; }

        public FigurePropIsNotGreaterThanZeroException(double radius)
        {
            Radius = radius;
        }
    }
}