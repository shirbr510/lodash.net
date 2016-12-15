using System;
using System.Collections.Generic;
using System.Linq;
using Lodash.Net.Extensions;
using Lodash.Net.Methods.Abstract;

namespace Lodash.Net.Methods
{
    public class LodashMath : ILodashMath
    {
        private readonly ILodashUtil _lodashUtil;

        public LodashMath(ILodashUtil lodashUtil)
        {
            _lodashUtil = lodashUtil;
        }

        public double Add(double augend, double addend) => augend + addend;

        public double Ceil(double number, int precision = 0)
        {
            var precisionFactor = Math.Pow(10, precision);
            return Math.Ceiling(number * precisionFactor) / precisionFactor;
        }

        public double Divide(double dividend, double divisor) => dividend / divisor;

        public double Floor(double number, int precision = 0)
        {
            var precisionFactor = Math.Pow(10, precision);
            return Math.Floor(number * precisionFactor) / precisionFactor;
        }

        public T Max<T>(IEnumerable<T> enumerable) => enumerable.Max();

        public TSource MaxBy<TSource, TResult>(IEnumerable<TSource> enumerable, Func<TSource, TResult> iteratee)
        {
            var sources = enumerable as IList<TSource> ?? enumerable.ToList();
            var result = sources.FirstOrDefault();
            foreach (var item in sources)
            {
                if (Comparer<TResult>.Default.Compare(iteratee.Invoke(result), iteratee.Invoke(item)) < 0)
                {
                    result = item;
                }
            }
            return result;
        }

        public T MaxBy<T>(IEnumerable<T> enumerable, string iteratee)
        {
            var func = _lodashUtil.Property<T, object>(iteratee);
            return MaxBy(enumerable, func);
        }

        public double Mean<T>(IEnumerable<T> enumerable) => typeof(T).IsNumeric() ? ToDoubles(enumerable).Average() : double.NaN;

        public double MeanBy<T>(IEnumerable<T> enumerable, Func<T, double> iteratee) => enumerable.Average(iteratee);

        public double MeanBy<T>(IEnumerable<T> enumerable, string iteratee)
        {
            var func = _lodashUtil.Property<T, double>(iteratee);
            return MeanBy(enumerable, func);
        }

        public T Min<T>(IEnumerable<T> enumerable) => enumerable.Min();

        public TSource MinBy<TSource, TResult>(IEnumerable<TSource> enumerable, Func<TSource, TResult> iteratee)
        {
            var sources = enumerable as IList<TSource> ?? enumerable.ToList();
            var result = sources.FirstOrDefault();
            foreach (var item in sources)
            {
                if (Comparer<TResult>.Default.Compare(iteratee.Invoke(result), iteratee.Invoke(item)) > 0)
                {
                    result = item;
                }
            }
            return result;

        }

        public T MinBy<T>(IEnumerable<T> enumerable, string iteratee)
        {
            var func = _lodashUtil.Property<T, object>(iteratee);
            return MinBy(enumerable, func);
        }

        public double Multiply(double multiplier, double multiplicand) => multiplier * multiplicand;

        public double Round(double number, int precision = 0)
        {
            var precisionFactor = Math.Pow(10, precision);
            return Math.Round(number * precisionFactor) / precisionFactor;
        }

        public double Substract(double minuend, double subtrahend) => minuend - subtrahend;

        public double Sum<T>(IEnumerable<T> enumerable) => typeof(T).IsNumeric() ? ToDoubles(enumerable).Sum() : double.NaN;

        public double SumBy<T>(IEnumerable<T> enumerable, Func<T, double> iteratee) => enumerable.Sum(iteratee);

        public double SumBy<T>(IEnumerable<T> enumerable, string iteratee)
        {
            var func = _lodashUtil.Property<T, double>(iteratee);
            return SumBy(enumerable, func);
        }

        private static IEnumerable<double> ToDoubles<T>(IEnumerable<T> enumerable) => enumerable.Select(item => Convert.ToDouble(item));
    }
}
