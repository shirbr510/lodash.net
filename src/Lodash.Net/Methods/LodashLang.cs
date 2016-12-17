using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Lodash.Net.Methods.Abstract;

namespace Lodash.Net.Methods
{
    public class LodashLang : ILodashLang
    {
        public object[] CastArray(object obj)
        {
            return IsArrayLike(obj) ? CastArray(obj as IEnumerable<object>) : new[] { obj };
        }

        public object[] CastArray(IEnumerable<object> enumerable) => IsArray(enumerable) ? (object[])enumerable : enumerable.ToArray();

        public T[] CastArray<T>(T obj) => new[] { obj };

        public T[] CastArray<T>(IEnumerable<T> enumerable) => IsArray(enumerable) ? (T[])enumerable : enumerable.ToArray();

        public object Clone(object obj)
        {
            throw new NotImplementedException();
        }

        public T Clone<T>(T obj)
        {
            throw new NotImplementedException();
        }

        public object CloneDeep(object obj)
        {
            throw new NotImplementedException();
        }

        public T CloneDeep<T>(T obj)
        {
            throw new NotImplementedException();
        }

        public bool Eq(object value, object other) => SameValueZero(value, other);

        public bool Eq<T>(T value, T other) where T : IComparable<T> => value.CompareTo(other) == 0;

        public bool Gt<T>(T value, T other) where T : IComparable<T> => value.CompareTo(other) > 0;

        public bool Gte<T>(T value, T other) where T : IComparable<T> => Gt(value, other) || Eq(value, other);

        public bool IsArray(object obj) => IsObject(obj) && obj.GetType().IsArray;

        public bool IsArrayLike(object obj) => IsObject(obj) && obj is IEnumerable;

        public bool IsBoolean(object obj) => obj is bool;

        public bool IsDate(object obj) => obj is DateTime;

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
