using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.Lib.Domain
{
    public sealed class RectangleCreator : ShapeCreator
    {
        public RectangleCreator(Height height , Width width)
        {
            Height = height;
            Width = width;
        }

        private Height Height { get; }
        private Width Width { get; }

        public override Shape Create() => new Rectangle(Height, Width);
    }
}
