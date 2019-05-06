using System;

namespace AreaCalculator.Lib
{
    public class IsNotGreaterThanZeroException : Exception
    {
        public double Radius { get; }

        public IsNotGreaterThanZeroException(double radius)
        {
            Radius = radius;
        }
    }
}