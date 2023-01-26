namespace GeometryLibrary.Tests
{
    public class GeometryTest
    {
        [Test]
        public void Cricle_Square_ReturnRightResult()
        {
            //arrange
            IShape cricle = new Cricle(5);

            //act 
            double expected = 78.53981633974483;
            double actual = cricle.GetSquare();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Square_ReturnRightResult()
        {
            //arrange
            IShape triangle = new Triangle(2,3,2);

            //act 
            double expected = 1.984313483298443;
            double actual = triangle.GetSquare();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RandomShape_Square_ReturnRightResult()
        {
            //arrange
            IShape triangle = new Triangle(2, 3, 2);

            //act 
            double expected = 1.984313483298443;
            double actual = Geometry.CalculateSquare(triangle);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}