using System;
using System.Collections;
using System.Collections.Generic;
using Lodash.Net.Data.Instance.Abstract;
using Lodash.Net.Methods.Abstract;

namespace Lodash.Net.Data.Instance
{
    public class LodashInstance : ILodashInstance
    {
        private readonly ILodashDate _lodashDate;

        private readonly ILodashMath _lodashMath;

        private readonly ILodashNumber _lodashNumber;

        private readonly ILodashUtil _lodashUtil;
        private readonly ILodashLang _lodashLang;

        public LodashInstance(ILodashDate lodashDate, ILodashMath lodashMath, ILodashNumber lodashNumber, ILodashUtil lodashUtil, ILodashLang lodashLang)
        {
            _lodashDate = lodashDate;
            _lodashMath = lodashMath;
            _lodashNumber = lodashNumber;
            _lodashUtil = lodashUtil;
            _lodashLang = lodashLang;
        }

        public long Now() => _lodashDate.Now();

        public double Add(double augend, double addend) => _lodashMath.Add(augend, addend);

        public double Ceil(double number, int precision = 0) => _lodashMath.Ceil(number, precision);

        public double Divide(double dividend, double divisor) => _lodashMath.Divide(dividend, divisor);

        public double Floor(double number, int precision = 0) => _lodashMath.Floor(number, precision);

        public T Max<T>(IEnumerable<T> enumerable) => _lodashMath.Max(enumerable);

        public TSource MaxBy<TSource, TResult>(IEnumerable<TSource> enumerable, Func<TSource, TResult> iteratee) => _lodashMath.MaxBy(enumerable, iteratee);

        public T MaxBy<T>(IEnumerable<T> enumerable, string iteratee) => _lodashMath.MaxBy(enumerable, iteratee);

        public double Mean<T>(IEnumerable<T> enumerable) => _lodashMath.Mean(enumerable);

        public double MeanBy<T>(IEnumerable<T> enumerable, Func<T, double> iteratee) => _lodashMath.MeanBy(enumerable, iteratee);

        public double MeanBy<T>(IEnumerable<T> enumerable, string iteratee) => _lodashMath.MeanBy(enumerable, iteratee);

        public T Min<T>(IEnumerable<T> enumerable) => _lodashMath.Min(enumerable);

        public TSource MinBy<TSource, TResult>(IEnumerable<TSource> enumerable, Func<TSource, TResult> iteratee) => _lodashMath.MinBy(enumerable, iteratee);

        public T MinBy<T>(IEnumerable<T> enumerable, string iteratee) => _lodashMath.MinBy(enumerable, iteratee);

        public double Multiply(double multiplier, double multiplicand) => _lodashMath.Multiply(multiplier, multiplicand);

        public double Round(double number, int precision = 0) => _lodashMath.Round(number, precision);

        public double Substract(double minuend, double subtrahend) => _lodashMath.Substract(minuend, subtrahend);

        public double Sum<T>(IEnumerable<T> enumerable) => _lodashMath.Sum(enumerable);

        public double SumBy<T>(IEnumerable<T> enumerable, Func<T, double> iteratee) => _lodashMath.SumBy(enumerable, iteratee);

        public double SumBy<T>(IEnumerable<T> enumerable, string iteratee) => _lodashMath.SumBy(enumerable, iteratee);

        public bool InRange(double number, double start, double upper) => _lodashNumber.InRange(number, start, upper);

        public bool InRange(double number, double upper) => _lodashNumber.InRange(number, upper);

        public T Clamp<T>(T number, T lower, T upper) where T : IComparable<T> => _lodashNumber.Clamp(number, lower, upper);

        public bool InRange<T>(T number, T start, T upper) where T : IComparable<T> => _lodashNumber.InRange(number, start, upper);

        public bool InRange<T>(T number, T upper) where T : IComparable<T> => _lodashNumber.InRange(number, upper);

        public double Random(double upper) => _lodashNumber.Random(upper);

        public double Random(double lower, double upper) => _lodashNumber.Random(lower, upper);

        public double Random(double upper, bool floating) => _lodashNumber.Random(upper, floating);

        public double Random(double lower, double upper, bool floating) => _lodashNumber.Random(lower, upper, floating);

        public Func<TObject, TProperty> Property<TObject, TProperty>(params string[] path) => _lodashUtil.Property<TObject, TProperty>(path);

        Func<object, object> ILodashUtil.Property(params string[] path) => _lodashUtil.Property(path);

        public object[] CastArray(object obj) => _lodashLang.CastArray(obj);

        public object[] CastArray(IEnumerable<object> enumerable) => _lodashLang.CastArray(enumerable);

        public T[] CastArray<T>(T arr) => _lodashLang.CastArray(arr);

        public T[] CastArray<T>(IEnumerable<T> enumerable) => _lodashLang.CastArray(enumerable);

        public object Clone(object obj) => _lodashLang.Clone(obj);

        public T Clone<T>(T obj) => _lodashLang.Clone(obj);

        public object CloneDeep(object obj) => _lodashLang.CloneDeep(obj);

        public T CloneDeep<T>(T obj) => _lodashLang.CloneDeep(obj);

        public T CloneDeepWith<T>(T obj, Func<T, T> customizer) => _lodashLang.CloneDeepWith(obj, customizer);

        public T CloneWith<T>(T obj, Func<T, T> customizer) => _lodashLang.CloneWith(obj, customizer);

        public bool ConfromsTo(object obj, object source) => _lodashLang.ConfromsTo(obj, source);

        public bool Eq(object value, object other) => _lodashLang.Eq(value, other);

        public bool Eq<T>(T value, T other) where T : IComparable<T> => _lodashLang.Eq(value, other);

        public bool Gt<T>(T value, T other) where T : IComparable<T> => _lodashLang.Gt(value, other);

        public bool Gte<T>(T value, T other) where T : IComparable<T> => _lodashLang.Gte(value, other);

        public bool IsArguments(object value) => _lodashLang.IsArguments(value);

        public bool IsArray(object obj) => _lodashLang.IsArray(obj);

        public bool IsArrayBuffer(object obj) => _lodashLang.IsArrayBuffer(obj);

        public bool IsArrayLike(object obj) => _lodashLang.IsArrayLike(obj);

        public bool IsArrayLikeObject(object obj) => _lodashLang.IsArrayLike(obj);

        public bool IsBoolean(object obj) => _lodashLang.IsBoolean(obj);

        public bool IsBuffer(object obj) => _lodashLang.IsBuffer(obj);

        public bool IsDate(object obj) => _lodashLang.IsDate(obj);

        public bool IsElement(object obj) => _lodashLang.IsElement(obj);

        public bool IsEmpty(object obj) => _lodashLang.IsEmpty(obj);

        public bool IsEmpty(IEnumerable enumerable) => _lodashLang.IsEmpty(enumerable);

        public bool IsEmpty<T>(IEnumerable<T> enumerable) => _lodashLang.IsEmpty(enumerable);

        public bool IsEqual(object value, object other) => _lodashLang.IsEqual(value, other);

        public bool IsEqualWith(object value, object other, Func<object, bool> customizer) => _lodashLang.IsEqualWith(value, other, customizer);

        public bool IsError(object value) => _lodashLang.IsError(value);

        public bool IsFinite(object value) => _lodashLang.IsFinite(value);

        public bool IsFunction(object value) => _lodashLang.IsFunction(value);

        public bool IsInteger(object obj) => _lodashLang.IsInteger(obj);

        public bool IsLength(object value) => _lodashLang.IsLength(value);

        public bool IsMap(object value) => _lodashLang.IsMap(value);

        public bool IsNumber(object obj) => _lodashLang.IsNumber(obj);

        public bool IsNil(object obj) => _lodashLang.IsNil(obj);

        public bool IsNull(object obj) => _lodashLang.IsNull(obj);

        public bool IsObject(object obj) => _lodashLang.IsObject(obj);

        public bool Lt<T>(T value, T other) where T : IComparable<T> => _lodashLang.Lt(value, other);

        public bool Lte<T>(T value, T other) where T : IComparable<T> => _lodashLang.Lte(value, other);
    }
}
