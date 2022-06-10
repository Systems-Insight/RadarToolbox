using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsInsight.MathLibrary.Signal
{
    public static class SignalGeneratorFunctions
    {
        public static Signal RectangularPulse(double sampleRate, double pulseWidth, double pulseRepetitionInterval)
        {
            var numberOfSamples = (int)Math.Round(sampleRate / pulseRepetitionInterval);

            var numberOfSamplesPulse = (int)Math.Round(sampleRate / pulseWidth);

            var time = new Vector(numberOfSamples);

            var i = new Vector(numberOfSamples);

            var q = new Vector(numberOfSamples);

            return new Signal(time, i, q);
        }
    }
}
