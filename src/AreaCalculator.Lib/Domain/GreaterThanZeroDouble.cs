using System;

namespace AreaCalculator.Lib
{
    public class GreaterThanZeroDouble
    {
        public GreaterThanZeroDouble(double value)
        {
            if (!(value > 0))
                throw new ArgumentOutOfRangeException(nameof(value), value, "value < 0") { Source = typeof(GreaterThanZeroDouble).FullName };
            Value = value;
        }

        public double Value { get; }
    }
}