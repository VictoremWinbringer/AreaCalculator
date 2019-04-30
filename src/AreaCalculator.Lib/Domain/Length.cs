namespace AreaCalculator.Lib
{
    // Тут исходим из идеи что нулевая длинна нам не нужна.
    // Вообще надо у заказчика или аналитика подробнее про это спросить - нужны им фируры с нулевой длинной или нет.
    // Да и вообще весь DDD это про общение с заказчиком
    public struct Length
    {
        private readonly double _prop;

        public Length(double radius)
        {
            if (!(radius > 0))
                throw new LengthIsNotGreaterThanZeroException(radius);

            _prop = radius;
        }

        public double Value => _prop;
    }
}