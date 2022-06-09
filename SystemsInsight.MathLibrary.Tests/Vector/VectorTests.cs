namespace SystemsInsight.MathLibrary.Tests
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void Operator_Add_Int_And_Vector_Expect_Success()
        {
            // Arrange:
            var x = new Vector(1.0, -2.1, 6.5);
            var y = new Vector(3.5,  1.1, 8.9);

            var expectedResult = new Vector(4.5, -1.0, 15.4);

            // Act:
            var result = x + y;

            var isEqual = result == expectedResult;

            // Assert:
            Assert.IsTrue(isEqual);
        }
    }
}