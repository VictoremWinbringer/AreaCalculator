namespace AreaCalculator.Lib
{
    // Тут исходим из идеи что нулевая длинна нам не нужна.
    // Вообще надо у заказчика или аналитика подробнее про это спросить - нужны им фируры с нулевой длинной или нет.
    // Ну собственно так как это структура то мы конечно можешь создать с конструктором по умолчанию с значением 0
    // Просто мы в коде вызываем только наш конструктор а конструктор по умолчанию стараемся не использовать
    // Почему не class? потому что Class по умолчанию может быть null и тут еще и проверку на null придеться мутить
    // Ждем c# 8
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