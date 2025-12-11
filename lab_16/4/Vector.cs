using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Vector
    {
        private double[] elements;

        public Vector(params double[] values)
        {
            elements = values;
        }
        public double this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        public int Length => elements.Length;
        public static double operator *(Vector a, Vector b)
        {
            if (a.Length != b.Length)
                throw new ArgumentException("Нужно совпаденние размеров.");

            double result = 0;
            for (int i = 0; i < a.Length; i++)
                result += a[i] * b[i];

            return result;
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", elements)}]";
        }
    }
}