using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using SystemsInsight.MathLibrary;

namespace SystemsInsight.Benchmarks
{
    [SimpleJob(RuntimeMoniker.Net60)]
    //[RPlotExporter]
    public class SignalGeneratorBenchmarks
    {
        [Params(1.0e-3, 1.0)]
        public double duration;

        [Params(10e6, 100e6)]
        public double sampleRate;

        [Benchmark]
        public void GenerateEmptySignal()
        {
            var signal = SignalGenerator.EmptySignal(sampleRate, duration);
        }

        //[Benchmark]
        //public void GenerateRandomSignalNormal()
        //{
        //    var meanNoisePower = 1.0;

        //    var signal = SignalGenerator.RandomNoise(sampleRate, duration, meanNoisePower);
        //}
    }
}