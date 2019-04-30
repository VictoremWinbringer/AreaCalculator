namespace AreaCalculator.Lib
{
    // Тут исходим из идеи что нулевая длинна нам не нужна.
    // Вообще надо у заказчика или аналитика подробнее про это спросить - нужны им фируры с нулевой длинной или нет.
    public struct Length
    {
        private readonly double _value;

        public Length(double length)
        {
            if (!(length > 0))
                throw new LengthIsNotGreaterThanZeroException(length);

            _value = length;
        }

        public double Value => _value;
    }
}