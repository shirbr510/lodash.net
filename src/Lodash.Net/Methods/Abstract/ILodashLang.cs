using System;
using System.Collections.Generic;

namespace Lodash.Net.Methods.Abstract
{
    public interface ILodashLang
    {
        /// <summary>
        /// Casts value as an array if it's not one.
        /// </summary>
        /// <since>4.4.0</since>
        /// <param name="obj">The value to inspect.</param>
        /// <returns>Returns the cast array.</returns>
        object[] CastArray(object obj);

        /// <summary>
        /// Casts value as an array if it's not one.
        /// </summary>
        /// <since>4.4.0</since>
        /// <param name="enumerable">The value to inspect.</param>
        /// <returns>Returns the cast array.</returns>
        object[] CastArray(IEnumerable<object> enumerable);

        /// <summary>
        /// Casts value as an array if it's not one.
        /// </summary>
        /// <since>4.4.0</since>
        /// <typeparam name="T">the type of the element</typeparam>
        /// <param name="obj">The value to inspect.</param>
        /// <returns>Returns the cast array.</returns>
        T[] CastArray<T>(T obj);

        /// <summary>
        /// Casts value as an array if it's not one.
        /// </summary>
        /// <since>4.4.0</since>
        /// <typeparam name="T">the type of the obj</typeparam>
        /// <param name="enumerable">The value to inspect.</param>
        /// <returns>Returns the cast array.</returns>
        T[] CastArray<T>(IEnumerable<T> enumerable);

        /// <summary>
        /// Creates a shallow clone of value.
        /// </summary>
        /// <remarks>This method is loosely based on the structured clone algorithm and supports cloning arrays, array buffers, booleans, date objects, maps, numbers, Object objects, regexes, sets, strings, symbols, and typed arrays. The own enumerable properties of arguments objects are cloned as plain objects. An empty object is returned for uncloneable values such as error objects, functions, DOM nodes, and WeakMaps.</remarks>
        /// <since>0.1.0</since>
        /// <param name="obj">The value to clone.</param>
        /// <returns>Returns the cloned value.</returns>
        object Clone(object obj);

        /// <summary>
        /// Creates a shallow clone of value.
        /// </summary>
        /// <remarks>This method is loosely based on the structured clone algorithm and supports cloning arrays, array buffers, booleans, date objects, maps, numbers, Object objects, regexes, sets, strings, symbols, and typed arrays. The own enumerable properties of arguments objects are cloned as plain objects. An empty object is returned for uncloneable values such as error objects, functions, DOM nodes, and WeakMaps.</remarks>
        /// <since>0.1.0</since>
        /// <typeparam name="T">the type of the obj</typeparam>
        /// <param name="obj">The value to clone.</param>
        /// <returns>Returns the cloned value.</returns>
        T Clone<T>(T obj);

        /// <summary>
        /// This method is like _.clone except that it recursively clones value.
        /// </summary>
        /// <since>0.1.0</since>
        /// <param name="obj">The value to recursively clone.</param>
        /// <returns>Returns the deep cloned value.</returns>
        object CloneDeep(object obj);

        /// <summary>
        /// This method is like _.clone except that it recursively clones value.
        /// </summary>
        /// <since>0.1.0</since>
        /// <typeparam name="T">the type of the obj</typeparam>
        /// <param name="obj">The value to recursively clone.</param>
        /// <returns>Returns the deep cloned value.</returns>
        T CloneDeep<T>(T obj);

        /// <summary>
        /// Performs a SameValueZero comparison between two values to determine if they are equivalent.
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="value">The value to compare.</param>
        /// <param name="other">The other value to compare.</param>
        /// <returns>Returns true if the values are equivalent, else false.</returns>
        bool Eq(object value, object other);

        /// <summary>
        /// Performs a SameValueZero comparison between two values to determine if they are equivalent.
        /// </summary>
        /// <since>4.0.0</since>
        /// <typeparam name="T">the type of the objects</typeparam>
        /// <param name="value">The value to compare.</param>
        /// <param name="other">The other value to compare.</param>
        /// <returns>Returns true if the values are equivalent, else false.</returns>
        bool Eq<T>(T value, T other) where T : IComparable<T>;

        /// <summary>
        /// Checks if value is greater than other.
        /// </summary>
        /// <since>3.9.0</since>
        /// <typeparam name="T">the type of the objects</typeparam>
        /// <param name="value">The value to compare.</param>
        /// <param name="other">The other value to compare.</param>
        /// <returns>Returns true if value is greater than other, else false.</returns>
        bool Gt<T>(T value, T other) where T : IComparable<T>;

        /// <summary>
        /// Checks if value is greater than or equal to other.
        /// </summary>
        /// <since>3.9.0</since>
        /// <typeparam name="T">the type of the objects</typeparam>
        /// <param name="value">The value to compare.</param>
        /// <param name="other">The other value to compare.</param>
        /// <returns>Returns true if value is greater than or equal to other, else false.</returns>
        bool Gte<T>(T value, T other) where T : IComparable<T>;

        /// <summary>
        /// Checks if value is classified as an Array object.
        /// </summary>
        /// <since>0.1.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is an array, else false.</returns>
        bool IsArray(object obj);

        /// <summary>
        /// Checks if value is array-like. A value is considered array-like if it's not a function and has a value.length that's an integer greater than or equal to 0 and less than or equal to Number.MAX_SAFE_INTEGER.
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is array-like, else false.</returns>
        bool IsArrayLike(object obj);

        /// <summary>
        /// Checks if value is classified as a boolean primitive or object.
        /// </summary>
        /// <since>0.1.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is a boolean, else false.</returns>
        bool IsBoolean(object obj);

        /// <summary>
        /// Checks if value is classified as a Date object.
        /// </summary>
        /// <since>0.1.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is a date object, else false.</returns>
        bool IsDate(object obj);

        /// <summary>
        /// Checks if value is an integer.
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is an integer, else false.</returns>
        bool IsInteger(object obj);

        /// <summary>
        /// Checks if value is classified as a boolean primitive or object.
        /// </summary>
        /// <since>0.1.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is a boolean, else false.</returns>
        bool IsNumber(object obj);

        /// <summary>
        /// Checks if value is null or undefined.
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is nullish, else false.</returns>
        bool IsNil(object obj);

        /// <summary>
        /// Checks if value is null.
        /// </summary>
        /// <since>0.1.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is null, else false.</returns>
        bool IsNull(object obj);

        /// <summary>
        /// Checks if value is the language type of Object. (e.g. arrays, functions, objects, regexes, new Number(0), and new String('')).
        /// </summary>
        /// <since>0.1.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is an object, else false.</returns>
        bool IsObject(object obj);

        /// <summary>
        /// Checks if value is less than other.
        /// </summary>
        /// <since>3.9.0</since>
        /// <typeparam name="T">the type of the objects</typeparam>
        /// <param name="value">The value to compare.</param>
        /// <param name="other">The other value to compare.</param>
        /// <returns>Returns true if value is less than other, else false.</returns>
        bool Lt<T>(T value, T other) where T : IComparable<T>;

        /// <summary>
        /// Checks if value is less than or equal to other.
        /// </summary>
        /// <since>3.9.0</since>
        /// <typeparam name="T">the type of the objects</typeparam>
        /// <param name="value">The value to compare.</param>
        /// <param name="other">The other value to compare.</param>
        /// <returns>Returns true if value is less than or equal to other, else false.</returns>
        bool Lte<T>(T value, T other) where T : IComparable<T>;
    }
}
