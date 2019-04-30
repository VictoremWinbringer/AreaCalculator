using System;

namespace AreaCalculator.Lib
{
   public class TriangleNotExistException:Exception
    {
        public double ASideLength { get;}
        public double BSideLength { get;}
        public double CSideLength { get;}

        public TriangleNotExistException(double a, double b, double c)
        {
            ASideLength = a;
            BSideLength = b;
            CSideLength = c;
        }
    }
}