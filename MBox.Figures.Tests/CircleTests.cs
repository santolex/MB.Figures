using Xunit;
using System;

namespace MBox.Figures.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(314.159, 10)]
        [InlineData(28.274, 3)]

        public void CircleFindAreaPositiveTest(double expected,double radius)
        {
            IFindArea figure = new Circle(radius);

            var area = figure.FindArea();

            Assert.Equal(expected, area);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CircleIncorectRadiusTest(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}
