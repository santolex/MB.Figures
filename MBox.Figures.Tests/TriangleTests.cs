using Xunit;
using System;

namespace MBox.Figures.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(10, 3, 10.44)]
        [InlineData(7, 3, 7.62)]
        [InlineData(7, 6, 9.220)]
        public void TriangleExistsPosiveTest(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.True(true);
        }
        
        [Theory]
        [InlineData(1, 1, 3)]
        [InlineData(3, 4, 77)]
        [InlineData(0, 4, 77)]
        [InlineData(3, 4, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, 4, 5)]
        public void TriangleExistsNegativeTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(3,  4, 5,6)]
        [InlineData(10, 3, 10.44,15)]
        [InlineData(7,  3, 7.62,10.5)]
        [InlineData(7,  6, 9.220,21)]
        public void TriangleFindAreaPositiveTest(double a, double b, double c ,double res)
        {
            IFindArea findArea = new Triangle(a, b, c);

            var area = findArea.FindArea();
            Assert.True(Math.Abs(area-res)<0.1);
        }
        
        [Theory]
        [InlineData(3,4,5,1)]
        [InlineData(10, 3, 10.44,0.1)]
        [InlineData(7, 3, 7.62,0.1)]
        [InlineData(7, 6, 9.220,0.1)]
        public void TriangleIsRightPositiveTest(double a, double b, double c, double tol)
        {
            var triangle = new Triangle(a, b, c,tol);

            var res = triangle.IsRight;

            Assert.Equal(true, res);
        }
        
        [Theory]
        [InlineData(3,  4, 6,     1)]
        [InlineData(10, 3, 11.44, 0.1)]
        [InlineData(7,  3, 9.62,  0.1)]
        [InlineData(7,  6, 10.220, 0.1)]
        public void TriangleIsRighNegativeTest(double a, double b, double c, double tol)
        {
            var triangle = new Triangle(a, b, c,tol);

            var res = triangle.IsRight;

            Assert.False(res);
        }
    }
}
