using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsInsight.RadarLibrary
{
    public record Waveform
    {
        public string WaveformName { get; init; } = "";

        public double PulseWidth { get; init; }

        public double PulseBandwidth { get; init; }

        public double PulseRepetitionFrequency { get; init; }

        public double PulseRepetitionInterval => 1.0 / PulseRepetitionFrequency;

        public double PulseCompressionRatio => PulseWidth * PulseBandwidth;

        public double PulseWidthCompressed => PulseWidth / PulseCompressionRatio;

        public double DutyRatio => PulseWidth * PulseRepetitionFrequency;

        public double DutyRatioPercent => DutyRatio * 100.0;
    }
}
