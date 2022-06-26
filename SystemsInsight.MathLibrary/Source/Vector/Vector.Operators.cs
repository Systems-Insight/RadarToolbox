﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsInsight.MathLibrary
{
    public partial class Vector
    {
        public Vector Magnitude()
        {
            var result = new Vector(this.NumberOfElements);

            for (int i = 0; i < this.NumberOfElements; i++)
            {
                result.Data[i] = Math.Abs(this.Data[i]);
            }

            return result;
        }

        public Vector Power()
        {
            var result = new Vector(this.NumberOfElements);

            for (int i = 0; i < this.NumberOfElements; i++)
            {
                result.Data[i] = this.Data[i] * this.Data[i];
            }

            return result;
        }

        public Vector Sqrt()
        {
            var result = new Vector(this.NumberOfElements);

            for (int i = 0; i < this.NumberOfElements; i++)
            {
                result.Data[i] = Math.Sqrt(this.Data[i]);
            }

            return result;
        }

        public Vector Squared()
        {
            var result = this * this;

            return result;
        }

        public Vector Pow(double exponent)
        {
            var result = new Vector(this.NumberOfElements);

            for (int i = 0; i < this.NumberOfElements; i++)
            {
                result.Data[i] = Math.Pow(this.Data[i], exponent);
            }

            return result;
        }

        public static Vector Atan2(Vector x, Vector y)
        {
            var result = new Vector(x.NumberOfElements);

            for (int i = 0; i < x.NumberOfElements; i++)
            {
                result.Data[i] = Math.Atan2(y.Data[i], x.Data[i]);
            }

            return result;
        }

        public double Min()
        {
            var result = Data.Min();

            return result;
        }

        public double Max()
        {
            var result = Data.Max();

            return result;
        }

        public static Vector LinearlySpacedVector(double startValue, double endValue, double spacing = 1.0)
        {
            var interval = endValue - startValue;

            var numberOfElements = (int)Math.Round(interval / spacing);

            var result = new Vector(numberOfElements);

            var value = startValue;

            for (int i = 0; i < numberOfElements; i++)
            {
                result.Data[i] = value;

                value += spacing;
            }

            return result;
        }

        public static Vector RandomVectorNormal(int numberOfSamples, double mean, double std)
        {
            var d = MathNet.Numerics.Distributions.Normal.WithMeanStdDev(mean, std);

            var result = new Vector(numberOfSamples);

            d.Samples(result.Data);

            return result;
        }
    }
}
