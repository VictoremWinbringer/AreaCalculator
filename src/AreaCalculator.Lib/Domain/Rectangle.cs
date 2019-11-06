using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.Lib
{
    public sealed class Rectangle : Shape
    {
        public Rectangle(Height height, Width width)
        {
            Height = height;
            Width = width;
        }

        public override Area Area => new Area(Height.Value * Width.Value);

        public override Perimeter Perimeter => new Perimeter((Height.Value + Width.Value) * 2);

        private Height Height { get; }
        private Width Width { get; }
    }
}
