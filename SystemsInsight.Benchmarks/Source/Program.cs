using BenchmarkDotNet.Running;

namespace SystemsInsight.Benchmarks
{
    public class Program
    {
        public static void Main()
        {
            var summary = BenchmarkRunner.Run<SignalGeneratorBenchmarks>();
        }
    }
}