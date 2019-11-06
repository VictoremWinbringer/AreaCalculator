using System;

namespace AreaCalculator.Lib
{
    public sealed class Circle : Shape
    {
        public Circle(Radius radius)
        {
            Radius = radius ?? throw new ArgumentNullException(nameof(radius)) { Source = typeof(Circle).FullName };
        }

        public Radius Radius { get; }

        public override Area Area => new Area(Radius.Value * Radius.Value * Math.PI);

        public override Perimeter Perimeter => new Perimeter(Radius.Value * 2 * Math.PI);
    }
}