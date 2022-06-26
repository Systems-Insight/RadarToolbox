using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Math;

namespace SystemsInsight.MathLibrary
{
    public record IQSampleDataExtended
    {
        public double Time { get; init; }

        public double I { get; init; }

        public double Q { get; init; }

        public double Magnitude => Sqrt(Power);

        public double Phase => Atan2(Q, I);

        public double PhaseDeg => Phase * 180.0 / Math.PI;

        public double Power => I * I + Q * Q;
    }
}