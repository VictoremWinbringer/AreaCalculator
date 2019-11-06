namespace AreaCalculator.Lib
{
    public sealed class CircleCreator : ShapeCreator
    {
        public CircleCreator(double radius)
        {
            Radius = radius;
        }

        private double Radius { get; }

        public override Shape Create()
        {
            return new Circle(Radius);
        }
    }
}