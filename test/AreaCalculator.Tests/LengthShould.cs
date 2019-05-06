using System;
using AreaCalculator.Lib;
using Xunit;

namespace AreaCalculator.Tests
{
    public class LengthShould
    {
        [Fact]
        public void DontCrateNotValidLength()
        {
            Assert.Throws<IsNotGreaterThanZeroException>(() =>
            {
                var length = new GreaterThanZeroDouble(-1);
            });
        }

        [Fact]
        public void ValueReturnExpectedValue()
        {
            var value = 1;
            var length = new GreaterThanZeroDouble(value);
            Assert.Equal(value,length.Value, 1);
        }
    }
}