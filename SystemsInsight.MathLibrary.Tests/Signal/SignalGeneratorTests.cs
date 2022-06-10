namespace SystemsInsight.MathLibrary.Tests
{
    [TestClass]
    public class SignalGeneratorTests
    {
        [TestMethod]
        public void Operator_Add_Int_And_Vector_Expect_Success()
        {
            // Arrange:
            var sampleRate = 50.0e6;
            var pulseWidth = 12.5e-6;
            var duration = 100.0e-6;

            // Act:
            var signal = SignalGenerator.RectangularPulse(sampleRate, pulseWidth, duration);

            // Assert:
            Assert.Inconclusive();
        }
    }
}
