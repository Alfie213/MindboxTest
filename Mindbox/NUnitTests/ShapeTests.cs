using Mindbox;

namespace NUnitTests
{
    [TestFixture]
    public class ShapeTests
    {
        private double epsilon = 0.0001;

        [Test]
        public void TestGetAreaZeroRadius()
        {
            // Arrange
            Circle circle = new Circle(0);
            double expected = 0;

            // Act
            double actual = circle.GetArea();

            // Assert
            Assert.AreEqual(expected, actual, epsilon, "CalculateArea is incorrect");
        }

        [Test]
        public void TestGetAreaNonZeroRadius()
        {
            // Arrange
            Circle circle = new Circle(5);
            double expected = 78.539816;

            // Act
            double actual = circle.GetArea();

            // Assert
            Assert.AreEqual(expected, actual, epsilon, "CalculateArea is incorrect");
        }

        [Test]
        public void TestGetAreaZeroABC()
        {
            // Arrange
            Triangle triangle = new Triangle(0, 0, 0);
            double expected = 0.0;

            // Act
            double actual = triangle.GetArea();

            // Assert
            Assert.AreEqual(expected, actual, epsilon, "CalculateArea is incorrect");
        }

        [Test]
        public void TestGetAreaNonZeroABC1()
        {
            // Arrange
            Triangle triangle = new Triangle(1, 1, 1);
            double expected = 0.4330127018922193;

            // Act
            double actual = triangle.GetArea();

            // Assert
            Assert.AreEqual(expected, actual, epsilon, "CalculateArea is incorrect");
        }

        [Test]
        public void TestGetAreaNonZeroABC2()
        {
            // Arrange
            Triangle triangle = new Triangle(5, 5, 5);
            double expected = 10.825317547305483;

            // Act
            double actual = triangle.GetArea();

            // Assert
            Assert.AreEqual(expected, actual, epsilon, "CalculateArea is incorrect");
        }

        [Test]
        public void TestIsRightTriangle1()
        {
            // Arrange
            Triangle triangle = new Triangle(1, 1, 1);
            bool expected = false;

            // Act
            bool actual = triangle.IsRightTriangle();

            // Assert
            Assert.AreEqual(expected, actual, "IsRightTriangle is incorrect");
        }

        [Test]
        public void TestIsRightTriangle2()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);
            bool expected = true;

            // Act
            bool actual = triangle.IsRightTriangle();

            // Assert
            Assert.AreEqual(expected, actual, "IsRightTriangle is incorrect");
        }
    }
}