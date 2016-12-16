using System;
using Lodash.Net.Extensions;
using Lodash.Net.Methods.Abstract;
using Lodash.Net.Randomizers.Abstract;

namespace Lodash.Net.Methods
{
    public class LodashNumber : ILodashNumber
    {
        private readonly IRandomizer<double> _random;

        private readonly ILodashMath _lodashMath;
        private readonly ILodashLang _lodashLang;

        public LodashNumber(ILodashMath lodashMath, ILodashLang lodashLang, IRandomizer<double> random)
        {
            _lodashLang = lodashLang;
            _lodashMath = lodashMath;
            _random = random;
        }

        public T Clamp<T>(T number, T lower, T upper) where T : IComparable<T>
        {
            ValidateLowerSmallerThenUpper(ref lower, ref upper);
            return number.CompareTo(lower) < 0 ? lower : (number.CompareTo(upper) > 0 ? upper : number);
        }

        public bool InRange<T>(T number, T start, T upper) where T : IComparable<T>
        {
            ValidateLowerSmallerThenUpper(ref start, ref upper);
            return _lodashLang.Lte(start, number) && _lodashLang.Lt(number, upper);
        }

        public bool InRange<T>(T number, T upper) where T : IComparable<T> => InRange(number, default(T), upper);

        public double Random(double upper) => Random(0, upper);

        public double Random(double lower, double upper)
        {
            var floating = !(lower.IsInteger() && upper.IsInteger());
            return Random(lower, upper, floating);
        }

        public double Random(double upper, bool floating) => Random(0, upper, floating);

        public double Random(double lower, double upper, bool floating)
        {
            var result = lower + _random.Random() * upper;
            return floating ? result : (result < 0 ? _lodashMath.Ceil(result) : _lodashMath.Floor(result));
        }

        private void ValidateLowerSmallerThenUpper<T>(ref T lower, ref T upper) where T : IComparable<T>
        {
            if (_lodashLang.Gt(lower, upper))
            {
                var temp = lower;
                lower = upper;
                upper = temp;
            }
        }
    }
}
