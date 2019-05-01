using AreaCalculator.Lib;
using Xunit;

namespace AreaCalculator.Tests
{
    public class TriangleShould
    {
        [Fact]
        public void CalculateValidSquare()
        {
            var triangle = new Triangle(2, 2, 2);
            var expected = 1.73d;
            Assert.Equal(expected, triangle.Square.Value,2);
        }

        [Fact]
        public void DontCreateNotValidTriangle()
        {
            Assert.Throws<TriangleNotExistException>(()=>
                new Triangle(1, 2, 3));
        }

        [Fact]
        public void RightAngledPropertyReturnFalseForNotRightAngled()
        {
            var triangle = new Triangle(2, 2, 2);
            Assert.False(triangle.IsRightAngled);
        }
        
        [Fact]
        public void RightAngledPropertyReturnTrueForRightAngled()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightAngled);
        }
    }
}