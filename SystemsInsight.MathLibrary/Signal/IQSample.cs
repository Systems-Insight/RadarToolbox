using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsInsight.MathLibrary.Signal
{
    public record IQSample
    {
        public double Time { get; init; }

        public double I { get; init; }

        public double Q { get; init; }
    }
}
