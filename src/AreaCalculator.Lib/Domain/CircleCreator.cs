namespace AreaCalculator.Lib
{
    public sealed class CircleCreator : ShapeCreator
    {
        public CircleCreator(Radius radius)
        {
            Radius = radius;
        }

        private Radius Radius { get; }

        public override Shape Create()
        {
            return new Circle(Radius);
        }
    }    
}