using SystemsInsight.RadarLibrary;
using SystemsInsight.Core;

namespace SystemsInsight.Core.Tests.Source
{
    [TestClass]
    public class JsonUtilitiesTests
    {
        [TestMethod]
        public void ConvertToJsonString_Test_1()
        {
            // Arrange:
            var waveform = new Waveform()
            {
                WaveformName = "Waveform 1",
                PulseWidth = 1.0e-6,
                PulseBandwidth = 50.0e6,
                PulseRepetitionFrequency = 1000.0
            };

            // Act:
            var s = waveform.ConvertToJsonString();

            var waveform2 = s.ConvertFromJsonString<Waveform>();

            // Assert:
            var isEqual = waveform2 == waveform;

            Assert.IsTrue(isEqual);
        }

        [TestMethod]
        public void WriteJsonString_Test_1()
        {
            // Arrange:
            var waveform = new Waveform()
            {
                WaveformName = "Waveform 1",
                PulseWidth = 1.0e-6,
                PulseBandwidth = 50.1e6,
                PulseRepetitionFrequency = 1000.123
            };

            var path = @"c:\temp\Waveform_1.json";

            // Act:
            waveform.WriteJsonFile(path);

            var waveform2 = JsonUtilities.ReadJsonFile<Waveform>(path);

            // Assert:
            var isEqual = waveform2 == waveform;

            Assert.IsTrue(isEqual);
        }
    }
}