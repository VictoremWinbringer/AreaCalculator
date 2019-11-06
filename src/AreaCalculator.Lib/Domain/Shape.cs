using System;

namespace AreaCalculator.Lib
{
    public abstract class Shape
    {
        public abstract Area Area { get; }
        public abstract Perimeter Perimeter { get; }
    }
}