using Mathematics2D;
using Xunit;

namespace MathematicsTests
{
    public class Mathematics2dTests
    {
        [Fact]
        public void PolygonPerimeterTriangle()
        {
            var a = new Point("A", 1, 3);
            var b = new Point("B", 1, 1);
            var c = new Point("C", 3, 1);
            var polygon = new Polygon(a, b, c);

            var result = polygon.Perimeter();

            Assert.Equal(6,result);
        }

        [Fact]
        public void PolygonPerimeterQuadrangle()
        {
            var a = new Point("A", 1, 3);
            var b = new Point("B", 1, 1);
            var c = new Point("C", 3, 1);
            var d = new Point("D", 3, 3);
            var polygon = new Polygon(a, b, c, d);

            var result = polygon.Perimeter();

            Assert.Equal(8, result);
        }

        [Fact]
        public void PolygonPerimeterPentagon()
        {
            var a = new Point("A", 1, 3);
            var b = new Point("B", 1, 1);
            var c = new Point("C", 3, 1);
            var d = new Point("D", 3, 3);
            var e = new Point("E", 2, 5);
            var polygon = new Polygon(a, b, c, d, e);

            var result = polygon.Perimeter();

            Assert.Equal(10, result);
        }

        [Fact]
        public void VectorLength()
        {
            var vector = new Vector("a", 1, 2, 3);

            var result = vector.VectorLength();

            Assert.Equal(3.742, result, 3);
        }

        [Fact]
        public void VectorsScalar()
        {
            var vectorA = new Vector("a", 1, 2, 3);
            var vectorB = new Vector("b", 0, -1, 2);

            var result = Vector.VectorsScalar(vectorA, vectorB);

            Assert.Equal(4, result, 0);
        }

        [Fact]
        public void VectorsProduct()
        {
            var vectorA = new Vector("a", 1, 2, 3);
            var vectorB = new Vector("b", 0, -1, 2);

            var vectorC = Vector.VectorsProduct(vectorA, vectorB, "C");

            Assert.Equal(7, vectorC.X);
            Assert.Equal(-2, vectorC.Y);
            Assert.Equal(-1, vectorC.Z);
        }

        [Fact]
        public void VectorsSum()
        {
            var vectorA = new Vector("a", 1, 2, 3);
            var vectorB = new Vector("b", 0, -1, 2);

            var vectorD = Vector.VectorsSum(vectorA, vectorB, "D");

            Assert.Equal(1, vectorD.X);
            Assert.Equal(1, vectorD.Y);
            Assert.Equal(5, vectorD.Z);
        }

        [Fact]
        public void VectorsSubtraction()
        {
            var vectorA = new Vector("a", 1, 2, 3);
            var vectorB = new Vector("b", 0, -1, 2);

            var vectorD = Vector.VectorsSubtraction(vectorA, vectorB, "D");

            Assert.Equal(1, vectorD.X);
            Assert.Equal(3, vectorD.Y);
            Assert.Equal(1, vectorD.Z);
        }
    }
}
