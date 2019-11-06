using System;

namespace AreaCalculator.Lib.Domain
{
    public sealed class RectangleCreator : ShapeCreator
    {
        public RectangleCreator(double height , double width)
        {
            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height));
            if (width <= 0)
                throw new ArgumentOutOfRangeException(nameof(width));
            Height = height;
            Width = width;
        }

        private double Height { get; }
        private double Width { get; }

        public override Shape Create() => new Rectangle(Height, Width);
    }
}
