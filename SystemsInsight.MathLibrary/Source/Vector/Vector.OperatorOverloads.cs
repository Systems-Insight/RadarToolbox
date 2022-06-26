using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsInsight.MathLibrary
{
    public partial class Vector
    {
        public static Vector operator +(double x, Vector y)
        {
            var result = new Vector(y.NumberOfElements);

            for (int i = 0; i < y.NumberOfElements; i++)
            {
                result.Data[i] = x + y.Data[i];
            }

            return result;
        }

        public static Vector operator +(Vector x, double y)
        {
            var result = new Vector(x.NumberOfElements);

            for (int i = 0; i < x.NumberOfElements; i++)
            {
                result.Data[i] = x.Data[i] + y;
            }

            return result;
        }

        public static Vector operator +(Vector x, Vector y)
        {
            var result = new Vector(x.NumberOfElements);

            for (int i = 0; i < y.NumberOfElements; i++)
            {
                result.Data[i] = x.Data[i] + y.Data[i];
            }

            return result;
        }

        public static Vector operator -(Vector x)
        {
            var result = new Vector(x.NumberOfElements);

            for (int i = 0; i < x.NumberOfElements; i++)
            {
                result.Data[i] = -x.Data[i];
            }

            return result;
        }

        public static Vector operator -(double x, Vector y)
        {
            var result = new Vector(y.NumberOfElements);

            for (int i = 0; i < y.NumberOfElements; i++)
            {
                result.Data[i] = x - y.Data[i];
            }

            return result;
        }

        public static Vector operator -(Vector x, double y)
        {
            var result = new Vector(x.NumberOfElements);

            for (int i = 0; i < x.NumberOfElements; i++)
            {
                result.Data[i] = x.Data[i] - y;
            }

            return result;
        }

        public static Vector operator -(Vector x, Vector y)
        {
            var result = new Vector(x.NumberOfElements);

            for (int i = 0; i < y.NumberOfElements; i++)
            {
                result.Data[i] = x.Data[i] - y.Data[i];
            }

            return result;
        }

        public static Vector operator *(double x, Vector y)
        {
            var result = new Vector(y.NumberOfElements);

            for (int i = 0; i < y.NumberOfElements; i++)
            {
                result.Data[i] = x * y.Data[i];
            }

            return result;
        }

        public static Vector operator *(Vector x, double y)
        {
            var result = new Vector(x.NumberOfElements);

            for (int i = 0; i < x.NumberOfElements; i++)
            {
                result.Data[i] = x.Data[i] * y;
            }

            return result;
        }

        public static Vector operator *(Vector x, Vector y)
        {
            var result = new Vector(x.NumberOfElements);

            for (int i = 0; i < y.NumberOfElements; i++)
            {
                result.Data[i] = x.Data[i] * y.Data[i];
            }

            return result;
        }

        public static Vector operator /(double x, Vector y)
        {
            var result = new Vector(y.NumberOfElements);

            for (int i = 0; i < y.NumberOfElements; i++)
            {
                result.Data[i] = x / y.Data[i];
            }

            return result;
        }

        public static Vector operator /(Vector x, double y)
        {
            var result = new Vector(x.NumberOfElements);

            for (int i = 0; i < x.NumberOfElements; i++)
            {
                result.Data[i] = x.Data[i] / y;
            }

            return result;
        }

        public static Vector operator /(Vector x, Vector y)
        {
            var result = new Vector(x.NumberOfElements);

            for (int i = 0; i < y.NumberOfElements; i++)
            {
                result.Data[i] = x.Data[i] / y.Data[i];
            }

            return result;
        }

        public static bool operator ==(Vector x, Vector y)
        {
            return Enumerable.SequenceEqual(x.Data, y.Data);
        }

        public static bool operator !=(Vector x, Vector y)
        {
            return !Enumerable.SequenceEqual(x.Data, y.Data);
        }
    }
}
