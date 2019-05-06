namespace AreaCalculator.Lib
{
    public class GreaterThanZeroDouble
    {
        private readonly double _value;

        public GreaterThanZeroDouble(double length)
        {
            if (!(length > 0))
                throw new IsNotGreaterThanZeroException(length);

            _value = length;
        }

        public double Value => _value;
    }
}