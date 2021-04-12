using Mathematics3D;
using Xunit;

namespace MathematicsTests
{
    public class Mathematics3dTests
    {
        [Fact]
        public void BoxVolume()
        {
            var box = new Box(10);

            var result = box.Volume();

            Assert.Equal(1000, result);
        }

        [Fact]
        public void BallVolume()
        {
            var ball = new Ball(10);

            var result = ball.Volume();

            Assert.Equal(418.879, result, 3);
        }

        [Fact]
        public void CylinderVolume()
        {
            Shape cylinder = new Cylinder(5, 10);

            var result = cylinder.Volume();

            Assert.Equal(785.398, result, 3);
        }

        [Fact]
        public void PyramidVolume()
        {
            Shape pyramid = new Pyramid(5, 10);

            var result = pyramid.Volume();

            Assert.Equal(16.667, result, 3);
        }

        [Theory]
        [InlineData(10, 10, true)]
        [InlineData(5, 10, false)]
        public void BoxAddShape(double containerHeight, double ballRadius, bool expectedResult)
        {
            var box = new Box(containerHeight);
            Shape ball = new Ball(ballRadius);
            var actualResult = box.Add(ball);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
