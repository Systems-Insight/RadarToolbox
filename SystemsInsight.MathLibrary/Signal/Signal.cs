using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SystemsInsight.MathLibrary.Signal
{
    public class Signal
    {
        public string Name { get; set; }

        public IQSample[] IQData { get; set; }

        public Signal()
        {
            Name = "";
            IQData = Array.Empty<IQSample>();
        }
    }
}
