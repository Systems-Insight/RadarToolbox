using SystemsInsight.Core.CsvUtilities;

namespace SystemsInsight.MathLibrary
{
    public partial class Signal
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

        public Signal(int numberOfSamples)
        {
            Time = new Vector(numberOfSamples);
            I = new Vector(numberOfSamples);
            Q = new Vector(numberOfSamples);
        }

        public Signal(Vector time, Vector i, Vector q)
        {
            Time = time;
            I = i;
            Q = q;
        }

        public IQSampleDataExtended[] ConvertToSampleData()
        {                
            var data = new IQSampleDataExtended[NumberOfSamples];

            for (int i = 0; i < NumberOfSamples; i++)
            {
                data[i] = new IQSampleDataExtended()
                {
                    Time = Time[i],
                    I = I[i],
                    Q = Q[i]
                };
            }

            return data;
        }

        public static Signal ConvertFromSampleData(IQSampleDataExtended[] data)
        {
            var numberOfSamples = data.Length;

            var signal = new Signal(data.Length);

            for (int i = 0; i < numberOfSamples; i++)
            {
                signal.Time[i] = data[i].Time;
                signal.I[i] = data[i].I;
                signal.Q[i] = data[i].Q;
            }

            return signal;
        }

        public void WriteSignal(string fileName)
        {
            var data = ConvertToSampleData().ToList();

            data.WriteCsvFile(fileName);
        }


        public static Signal ReadSignal(string fileName)
        {
            var data = CsvUtilities.ReadCsvFile<IQSampleDataExtended>(fileName).ToArray();

            var signal = Signal.ConvertFromSampleData(data);

            return signal;
        }
    }
}
