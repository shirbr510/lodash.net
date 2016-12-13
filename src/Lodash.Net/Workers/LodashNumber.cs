using System;
using Lodash.Net.Workers.Abstract;

namespace Lodash.Net.Workers
{
    public class LodashNumber : ILodashNumber
    {
        public double Clamp(double number, double lower, double upper)
        {
            throw new NotImplementedException();
        }

        public bool InRange(double number, double start, double upper)
        {
            throw new NotImplementedException();
        }

        public bool InRange(double number, double upper)
        {
            throw new NotImplementedException();
        }

        public double Random(double lower = 0, double upper = 1, bool floating = false)
        {
            throw new NotImplementedException();
        }
    }
}
