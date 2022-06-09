using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsInsight.MathLibrary
{
    public partial class Vector
    {
        public int NumberOfElements => Data.Length;

        public double[] Data { get; set; }

        public Vector()
        {
            Data = Array.Empty<double>();
        }

        public Vector(int numberOfElements)
        {
            Data = new double[numberOfElements];
        }

        public Vector(params double[] data)
        {
            Data = data;
        }

        public double this[int index]
        {
            get => Data[index];
            set => Data[index] = value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is null)
            {
                return false;
            }

            if (obj is not Vector)
            {
                return false;
            }

            return IsEqual((Vector)obj);
        }

        public bool Equals(Vector obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is null)
            {
                return false;
            }

            return IsEqual(obj);
        }

        private bool IsEqual(Vector obj)
        {
            return this == obj;
        }

        public override int GetHashCode()
        {
            return Data.GetHashCode();
        }
    }
}
