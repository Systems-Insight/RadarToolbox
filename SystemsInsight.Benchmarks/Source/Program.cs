using BenchmarkDotNet.Running;
using SystemsInsight.MathLibrary;

namespace SystemsInsight.Benchmarks
{
    public class Program
    {
        public static void Main()
        {
            var summary = BenchmarkRunner.Run<SignalGeneratorBenchmarks>();

            //var sampleRate = 10e6;
            //var duration = 1.0;

            //var s = SignalGenerator.RandomNoise(sampleRate, duration, 1.0);

            //var fileName = @"c:\temp\signal_1.csv";

            //s.WriteSignal(fileName);
        }
    }
}