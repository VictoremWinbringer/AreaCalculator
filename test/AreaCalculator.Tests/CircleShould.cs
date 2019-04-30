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
            var circle = new Circle(new Length(radius));
            var actual = circle.Square.Value;
            var expected = radius * radius * Math.PI;
            Assert.Equal(expected,actual, 3);
        }
    }
}