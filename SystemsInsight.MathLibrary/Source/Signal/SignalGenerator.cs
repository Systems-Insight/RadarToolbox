using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsInsight.MathLibrary
{
    public static class SignalGenerator
    {
        public static Signal EmptySignal(double sampleRate, double duration)
        {
            var sampleInterval = 1.0 / sampleRate;

            var numberOfSamples = (int)Math.Round(duration * sampleRate);

            var time = Vector.LinearlySpacedVector(0, duration, sampleInterval);

            var i = new Vector(numberOfSamples);
            var q = new Vector(numberOfSamples);

            return new Signal(time, i, q);
        }

        public static Signal RandomNoise(double sampleRate, double duration, double meanPower)
        {
            var sampleInterval = 1.0 / sampleRate;

            var numberOfSamples = (int)Math.Round(duration * sampleRate);

            var time = Vector.LinearlySpacedVector(0, duration, sampleInterval);

            var meanAmplitude = Math.Sqrt(meanPower / 2);

            var i = Vector.RandomVectorNormal(numberOfSamples, 0.0, meanAmplitude);
            var q = Vector.RandomVectorNormal(numberOfSamples, 0.0, meanAmplitude);

            return new Signal(time, i, q);
        }

        public static Signal RectangularPulse(double sampleRate, double pulseWidth, double duration)
        {
            var sampleInterval = 1.0 / sampleRate;

            var numberOfSamplesTotal = (int)Math.Round(duration * sampleRate);

            var numberOfSamplesPulse = (int)Math.Round(pulseWidth * sampleRate);

            var time = Vector.LinearlySpacedVector(0, duration, sampleInterval);

            var i = new Vector(numberOfSamplesTotal);

            var q = new Vector(numberOfSamplesTotal);

            var iPulse = new Vector(numberOfSamplesPulse);

            iPulse += 1.0;

            i[0, numberOfSamplesPulse] = iPulse;
            
            return new Signal(time, i, q);
        }
    }
}
