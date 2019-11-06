using System;

namespace AreaCalculator.Lib
{
    public sealed class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height));
            if (width <= 0)
                throw new ArgumentOutOfRangeException(nameof(width));
            Height = height;
            Width = width;
        }

        public override double Area => (Height * Width);

        public override double Perimeter => ((Height + Width) * 2);

        private double Height { get; }
        private double Width { get; }
    }
}
