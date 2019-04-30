using System;

namespace AreaCalculator.Lib
{
    public sealed class LengthIsNotGreaterThanZeroException : Exception
    {
        public double Radius { get; }

        public LengthIsNotGreaterThanZeroException(double radius)
        {
            Radius = radius;
        }
    }
}