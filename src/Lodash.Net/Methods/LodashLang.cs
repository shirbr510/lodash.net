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
    }
}
