using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Lodash.Net.Logics.Cloners.Abstract;
using Lodash.Net.Methods.Abstract;
using Microsoft.AspNetCore.Html;

namespace Lodash.Net.Methods
{
    public class LodashLang : ILodashLang
    {
        private readonly IShallowCloner _cloner;

        private readonly IDeepCloner _deepCloner;

        public LodashLang(IShallowCloner cloner, IDeepCloner deepCloner)
        {
            _cloner = cloner;
            _deepCloner = deepCloner;
        }

        public object[] CastArray(object obj)
        {
            return IsArrayLike(obj) ? CastArray(obj as IEnumerable<object>) : new[] { obj };
        }

        public object[] CastArray(IEnumerable<object> enumerable) => IsArray(enumerable) ? (object[])enumerable : enumerable.ToArray();

        public T[] CastArray<T>(T obj) => new[] { obj };

        public T[] CastArray<T>(IEnumerable<T> enumerable) => IsArray(enumerable) ? (T[])enumerable : enumerable.ToArray();


        /// <summary>
        /// Creates a shallow clone of value.
        /// </summary>
        /// <remarks>This method is loosely based on the structured clone algorithm and supports cloning arrays, array buffers, booleans, date objects, maps, numbers, Object objects, regexes, sets, strings, symbols, and typed arrays. The own enumerable properties of arguments objects are cloned as plain objects. An empty object is returned for uncloneable values such as error objects, functions, DOM nodes, and WeakMaps.</remarks>
        /// <since>0.1.0</since>
        /// <param name="obj">The value to clone.</param>
        /// <returns>Returns the cloned value.</returns>
        public object Clone(object obj) => _cloner.Clone(obj);

        /// <summary>
        /// Creates a shallow clone of value.
        /// </summary>
        /// <remarks>This method is loosely based on the structured clone algorithm and supports cloning arrays, array buffers, booleans, date objects, maps, numbers, Object objects, regexes, sets, strings, symbols, and typed arrays. The own enumerable properties of arguments objects are cloned as plain objects. An empty object is returned for uncloneable values such as error objects, functions, DOM nodes, and WeakMaps.</remarks>
        /// <since>0.1.0</since>
        /// <typeparam name="T">the type of the enumerable</typeparam>
        /// <param name="obj">The value to clone.</param>
        /// <returns>Returns the cloned value.</returns>
        public T Clone<T>(T obj) => _cloner.Clone(obj);

        public object CloneDeep(object obj) => _deepCloner.Clone(obj);

        public T CloneDeep<T>(T obj) => _deepCloner.Clone(obj);

        public T CloneDeepWith<T>(T obj, Func<T, T> customizer)
        {
            throw new NotImplementedException();
        }

        public T CloneWith<T>(T obj, Func<T, T> customizer)
        {
            throw new NotImplementedException();
        }

        public bool ConfromsTo(object obj, object source)
        {
            throw new NotImplementedException();
        }

        public bool Eq(object value, object other) => SameValueZero(value, other);

        public bool Eq<T>(T value, T other) where T : IComparable<T> => value.CompareTo(other) == 0;

        public bool Gt<T>(T value, T other) where T : IComparable<T> => value.CompareTo(other) > 0;

        public bool Gte<T>(T value, T other) where T : IComparable<T> => Gt(value, other) || Eq(value, other);

        public bool IsArguments(object value)
        {
            throw new NotImplementedException();
        }

        public bool IsArray(object obj) => IsObject(obj) && obj.GetType().IsArray;

        public bool IsArrayBuffer(object obj)
        {
            return obj is byte[];
        }

        public bool IsArrayLike(object obj) => obj is IEnumerable;

        public bool IsArrayLikeObject(object obj) => IsObject(obj) && IsArrayLike(obj);

        public bool IsBoolean(object obj) => obj is bool;

        public bool IsBuffer(object obj)
        {
            throw new NotImplementedException();
        }

        public bool IsDate(object obj) => obj is DateTime;

        public bool IsElement(object obj)
        {
            return obj is IHtmlContent;
        }

        public bool IsEmpty(object obj)
        {
            var enumerable = obj as IEnumerable;
            return enumerable != null && IsEmpty(enumerable);
        }

        public bool IsEmpty(IEnumerable enumerable) => IsEmpty(enumerable.Cast<object>());

        public bool IsEmpty<T>(IEnumerable<T> enumerable) => !enumerable.Any();
        public bool IsEqual(object value, object other)
        {
            throw new NotImplementedException();
        }

        public bool IsEqualWith(object value, object other, Func<object, bool> customizer)
        {
            throw new NotImplementedException();
        }

        public bool IsError(object value) => value is Exception;

        public bool IsFinite(object value)
        {
            if (!IsNumber(value))
            {
                return false;
            }
            var num = (double)value;
            return !(double.IsInfinity(num) || double.IsNaN(num));
        }

        public bool IsFunction(object value) => value is Delegate;

        public bool IsInteger(object obj)
        {
            if (IsNull(obj) || IsDate(obj))
            {
                return false;
            }
            return IsBoolean(obj) ||
                   obj is sbyte ||
                   obj is byte ||
                   obj is short ||
                   obj is ushort ||
                   obj is int ||
                   obj is char;
        }

        public bool IsLength(object value)
        {
            long valueAsLong;
            return IsNumber(value) &&
                long.TryParse(value.ToString(), out valueAsLong) &&
                valueAsLong > 0;
        }

        public bool IsNumber(object obj) => IsInteger(obj) ||
                                            obj is uint ||
                                            obj is long ||
                                            obj is float ||
                                            obj is double ||
                                            obj is decimal;

        public bool IsNil(object obj) => IsNull(obj);

        public bool IsNull(object obj) => obj == null;

        public bool IsObject(object obj) => !IsNull(obj);

        public bool Lt<T>(T value, T other) where T : IComparable<T> => value.CompareTo(other) < 0;

        public bool Lte<T>(T value, T other) where T : IComparable<T> => Lt(value, other) || Eq(value, other);

        /// <summary>
        /// 
        /// </summary>
        /// <seealso cref="http://ecma-international.org/ecma-262/7.0/#sec-samevaluezero"/>
        /// <param name="value"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        private bool SameValueZero(object value, object other)
        {
            if (value.GetType() != other.GetType())
            {
                return false;
            }
            if (!IsNumber(value))
            {
                return SameValueNonNumber(value, other);
            }
            var x = (double)value;
            var y = (double)other;
            return double.IsNaN(x) && double.IsNaN(y) || Math.Abs(x - y) < double.Epsilon;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <seealso cref="http://ecma-international.org/ecma-262/7.0/#sec-samevaluenonnumber"/>
        /// <param name="value"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        private bool SameValueNonNumber(object value, object other)
        {
            if (IsNumber(value))
            {
                throw new ArgumentException("argument is a number although it shouldn't be", nameof(value));
            }
            if (value.GetType() != other.GetType())
            {
                throw new ArgumentException("arguments should be of Identical types", nameof(other));
            }
            if (value is string)
            {
                return (string)value == (string)other;
            }
            if (value is bool)
            {
                return (bool)value == (bool)other;
            }
            if (value is char)
            {
                return (char)value == (char)other;
            }
            return value == other;
        }
    }
}
