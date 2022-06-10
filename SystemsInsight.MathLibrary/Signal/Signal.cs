namespace SystemsInsight.MathLibrary.Signal
{
    public class Signal
    {
        public Vector Time { get; set; }

        public Vector I { get; set; }

        public Vector Q { get; set; }

        public int NumberOfSamples => Time.NumberOfElements;

        public double SampleInterval => Duration / (NumberOfSamples-1);

        public double SampleRate => 1.0 / SampleInterval;

        public double StartTime => Time[0];

        public double EndTime => Time[Time.NumberOfElements-1];

        public double Duration => EndTime - StartTime;

        public Vector Magnitude => Power.Sqrt();

        public double MagnitudeMin => Magnitude.Min();

        public double MagnitudeMax => Magnitude.Max();

        public Vector Power => I * I + Q * Q;

        public double PowerMin => Power.Min();

        public double PowerMax => Power.Max();

        public Vector Phase => Vector.Atan2(Q, I);

        public Vector PhaseDeg => Phase * 180.0 / Math.PI;

        public Signal()
        {
            Time = new Vector();
            I = new Vector();
            Q = new Vector();
        }

        public Signal(Vector time, Vector i, Vector q)
        {
            Time = time;
            I = i;
            Q = q;
        }
    }
}
