namespace SystemsInsight.MathLibrary.Tests
{
    [TestClass]
    public class SignalGeneratorTests
    {
        [TestMethod]
        public void RectangularPulse_XXX()
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
