using System;
using AreaCalculator.Lib;
using Xunit;

namespace AreaCalculator.Tests
{
    public class CircleShould
    {
        [Fact]
        public void CalculateValidSquare()
        {
            var radius = 1d;
            var circle = new Circle(new Radius(radius));
            var actual = circle.Area.Value;
            var expected = radius * radius * Math.PI;
            Assert.Equal(expected, actual, 3);
        }
    }
}