using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsInsight.MathLibrary
{
    public partial class Signal
    {
        public static Signal operator +(double x, Signal y)
        {
            var result = new Signal(y.NumberOfSamples);

            result.Time = y.Time;

            result.I = y.I + x;
            result.Q = y.Q;

            return result;
        }

        public static Signal operator +(Signal x, double y)
        {
            var result = new Signal(x.NumberOfSamples);

            result.Time = x.Time;

            result.I = x.I + y;
            result.Q = x.Q;

            return result;
        }

        public static Signal operator +(Signal x, Signal y)
        {
            var result = new Signal(x.NumberOfSamples);

            result.Time = x.Time;

            result.I = x.I + y.I;
            result.Q = x.Q + y.Q;

            return result;
        }
    }
}
