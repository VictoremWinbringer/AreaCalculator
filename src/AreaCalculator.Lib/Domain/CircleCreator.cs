using System;

namespace AreaCalculator.Lib
{
    public sealed class CircleCreator : ShapeCreator
    {
        public override Shape Create(string input)
        {
            input = input?.Trim();
            if (!double.TryParse(input, out var radius))
                throw new ArgumentException($"{nameof(Circle)} Input: {input} for double radius has bad format");
            return new Circle(radius);
        }
    }
}