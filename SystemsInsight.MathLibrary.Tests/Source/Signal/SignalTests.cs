namespace SystemsInsight.MathLibrary.Tests
{
    [TestClass]
    public class SignalTests
    {
        [TestMethod]
        public void WriteCsvFile_XXX()
        {
            // Arrange:
            var sampleRate = 50.0e6;
            var pulseWidth = 12.5e-6;
            var duration = 100.0e-6;

            var signal = SignalGenerator.RectangularPulse(sampleRate, pulseWidth, duration);

            var fileName = @"c:\temp\Signal_1.csv";

            // Act:
            signal.WriteSignal(fileName);

            var signal2 = Signal.ReadSignal(fileName);

            // Assert:
            Assert.Inconclusive();
        }
    }
}