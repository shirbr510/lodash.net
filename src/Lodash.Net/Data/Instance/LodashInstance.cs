using System;
using System.Collections.Generic;
using Lodash.Net.Data.Instance.Abstract;
using Lodash.Net.Workers;
using Lodash.Net.Workers.Abstract;

namespace Lodash.Net.Data.Instance
{
    public class LodashInstance : ILodashInstance
    {
        private readonly ILodashDate _lodashDate;

        private readonly ILodashMath _lodashMath;

        public LodashInstance()
        {
            _lodashMath = new LodashMath();
            _lodashDate = new LodashDate();
        }

        public long Now() => _lodashDate.Now();

        public double Add(double augend, double addend) => _lodashMath.Add(augend, addend);

        public double Ceil(double number, int precision = 0) => _lodashMath.Ceil(number, precision);

        public double Divide(double dividend, double divisor) => _lodashMath.Divide(dividend, divisor);

        public double Floor(double number, int precision = 0) => _lodashMath.Floor(number, precision);

        public T Max<T>(IEnumerable<T> enumerable) => _lodashMath.Max(enumerable);

        public T MaxBy<T>(IEnumerable<T> enumerable, Func<T, object> iteratee) => _lodashMath.MaxBy(enumerable, iteratee);

        public T MaxBy<T>(IEnumerable<T> enumerable, string iteratee) => _lodashMath.MaxBy(enumerable, iteratee);

        public T Mean<T>(IEnumerable<T> enumerable) => _lodashMath.Mean(enumerable);

        public T MeanBy<T>(IEnumerable<T> enumerable, Func<T, object> iteratee) => _lodashMath.MeanBy(enumerable, iteratee);

        public T MeanBy<T>(IEnumerable<T> enumerable, string iteratee) => _lodashMath.MeanBy(enumerable, iteratee);

        public T Min<T>(IEnumerable<T> enumerable) => _lodashMath.Min(enumerable);

        public T MinBy<T>(IEnumerable<T> enumerable, Func<T, object> iteratee) => _lodashMath.MinBy(enumerable, iteratee);

        public T MinBy<T>(IEnumerable<T> enumerable, string iteratee) => _lodashMath.MinBy(enumerable, iteratee);

        public double Multiply(double multiplier, double multiplicand) => _lodashMath.Multiply(multiplier, multiplicand);

        public double Round(double number, int precision = 0) => _lodashMath.Round(number, precision);

        public double Substract(double minuend, double subtrahend) => _lodashMath.Substract(minuend, subtrahend);

        public T Sum<T>(IEnumerable<T> enumerable) => _lodashMath.Sum(enumerable);

        public T SumBy<T>(IEnumerable<T> enumerable, Func<T, object> iteratee) => _lodashMath.SumBy(enumerable, iteratee);

        public T SumBy<T>(IEnumerable<T> enumerable, string iteratee) => _lodashMath.SumBy(enumerable, iteratee);
    }
}
