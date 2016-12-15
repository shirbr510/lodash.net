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
        /// <typeparam name="T">the type of the enumerable</typeparam>
        /// <param name="enumerable">The value to inspect.</param>
        /// <returns>Returns the cast array.</returns>
        T[] CastArray<T>(IEnumerable<T> enumerable);

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
    }
}
