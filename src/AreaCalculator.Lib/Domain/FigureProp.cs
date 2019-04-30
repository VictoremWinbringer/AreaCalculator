namespace AreaCalculator.Lib
{
    public struct FigureProp
    {
        private readonly double _prop;

        public FigureProp(double radius)
        {
            if (!(radius > 0))
                throw new FigurePropIsNotGreaterThanZeroException(radius);

            _prop = radius;
        }

        public double Value => _prop;
    }
}