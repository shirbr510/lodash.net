using System;
using System.Collections;
using System.Collections.Generic;
using Lodash.Net.Logics.Cloners.Abstract;

namespace Lodash.Net.Methods.Abstract
{
    public interface ILodashLang : ICloner
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
        /// <typeparam name="T">the type of the enumerable</typeparam>
        /// <param name="obj">The value to recursively clone.</param>
        /// <returns>Returns the deep cloned value.</returns>
        T CloneDeep<T>(T obj);

        /// <summary>
        /// This method is like _.cloneWith except that it recursively clones value.
        /// </summary>
        /// <since>4.0.0</since>
        /// <typeparam name="T">the type of the enumerable</typeparam>
        /// <param name="obj">The value to recursively clone.</param>
        /// <param name="customizer">The function to customize cloning</param>
        /// <returns>Returns the deep cloned value.</returns>
        T CloneDeepWith<T>(T obj, Func<T, T> customizer);

        /// <summary>
        /// This method is like _.clone except that it accepts customizer which is invoked to produce the cloned value. If customizer returns undefined, cloning is handled by the method instead. The customizer is invoked with up to four arguments; (value [, index|key, object, stack]).
        /// </summary>
        /// <since>4.0.0</since>
        /// <typeparam name="T">the type of the enumerable</typeparam>
        /// <param name="obj">The value to recursively clone.</param>
        /// <param name="customizer">The function to customize cloning</param>
        /// <returns>Returns the deep cloned value.</returns>
        T CloneWith<T>(T obj, Func<T, T> customizer);

        /// <summary>
        /// Checks if object conforms to source by invoking the predicate properties of source with the corresponding property values of object.
        /// </summary>
        /// <since>4.14.0</since>
        /// <remarks>This method is equivalent to _.conforms when source is partially applied</remarks>
        /// <typeparam name="T">the type of the enumerable</typeparam>
        /// <param name="obj">The object to inspect.</param>
        /// <param name="source">The object of property predicates to conform to.</param>
        /// <returns>Returns true if object conforms, else false.</returns>
        bool ConfromsTo(object obj, object source);

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
        /// Checks if value is likely an arguments object.
        /// </summary>
        /// <since>0.1.0</since>
        /// <param name="value">The value to check.</param>
        /// <returns>Returns true if value is an arguments object, else false.</returns>
        bool IsArguments(object value);

        /// <summary>
        /// Checks if value is classified as an Array object.
        /// </summary>
        /// <since>0.1.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is an array, else false.</returns>
        bool IsArray(object obj);

        /// <summary>
        /// Checks if value is classified as an ArrayBuffer object.
        /// </summary>
        /// <since>4.3.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is an array buffer, else false.</returns>
        bool IsArrayBuffer(object obj);

        /// <summary>
        /// Checks if value is array-like. A value is considered array-like if it's not a function and has a value.length that's an integer greater than or equal to 0 and less than or equal to Number.MAX_SAFE_INTEGER.
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is array-like, else false.</returns>
        bool IsArrayLike(object obj);

        /// <summary>
        /// This method is like _.isArrayLike except that it also checks if value is an object.
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is array-like, else false.</returns>
        bool IsArrayLikeObject(object obj);

        /// <summary>
        /// Checks if value is classified as a boolean primitive or object.
        /// </summary>
        /// <since>0.1.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is a boolean, else false.</returns>
        bool IsBoolean(object obj);

        /// <summary>
        /// Checks if value is a buffer.
        /// </summary>
        /// <since>4.3.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is a buffer, else false.</returns>
        bool IsBuffer(object obj);

        /// <summary>
        /// Checks if value is classified as a Date object.
        /// </summary>
        /// <since>0.1.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is a date object, else false.</returns>
        bool IsDate(object obj);

        /// <summary>
        /// Checks if value is likely a DOM element.
        /// </summary>
        /// <since>0.1.0</since>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is a DOM element, else false.</returns>
        bool IsElement(object obj);

        /// <summary>
        /// Checks if value is an empty object, collection, map, or set.
        /// </summary>
        /// <since>0.1.0</since>
        /// <remarks>Objects are considered empty if they have no own enumerable string keyed properties. Array-like values such as arguments objects, arrays, buffers, strings, or jQuery-like collections are considered empty if they have a length of 0. Similarly, maps and sets are considered empty if they have a size of 0.</remarks>
        /// <param name="obj">The value to check.</param>
        /// <returns>Returns true if value is empty, else false.</returns>
        bool IsEmpty(object obj);

        /// <summary>
        /// Checks if value is an empty object, collection, map, or set.
        /// </summary>
        /// <since>0.1.0</since>
        /// <remarks>Objects are considered empty if they have no own enumerable string keyed properties. Array-like values such as arguments objects, arrays, buffers, strings, or jQuery-like collections are considered empty if they have a length of 0. Similarly, maps and sets are considered empty if they have a size of 0.</remarks>
        /// <param name="enumerable">The value to check.</param>
        /// <returns>Returns true if value is empty, else false.</returns>
        bool IsEmpty(IEnumerable enumerable);

        /// <summary>
        /// Checks if value is an empty object, collection, map, or set.
        /// </summary>
        /// <since>0.1.0</since>
        /// <typeparam name="T">the type of the objects</typeparam>
        /// <remarks>Objects are considered empty if they have no own enumerable string keyed properties. Array-like values such as arguments objects, arrays, buffers, strings, or jQuery-like collections are considered empty if they have a length of 0. Similarly, maps and sets are considered empty if they have a size of 0.</remarks>
        /// <param name="enumerable">The value to check.</param>
        /// <returns>Returns true if value is empty, else false.</returns>
        bool IsEmpty<T>(IEnumerable<T> enumerable);

        /// <summary>
        /// Performs a deep comparison between two values to determine if they are equivalent.
        /// </summary>
        /// <since>0.1.0</since>
        /// <remarks>This method supports comparing arrays, array buffers, booleans, date objects, error objects, maps, numbers, Object objects, regexes, sets, strings, symbols, and typed arrays. Object objects are compared by their own, not inherited, enumerable properties. Functions and DOM nodes are not supported.</remarks>
        /// <param name="value">The value to compare</param>
        /// <param name="other">The other value to compare</param>
        /// <returns>Returns true if the values are equivalent, else false.</returns>
        bool IsEqual(object value, object other);

        /// <summary>
        /// This method is like _.isEqual except that it accepts customizer which is invoked to compare values. If customizer returns undefined, comparisons are handled by the method instead. The customizer is invoked with up to six arguments: (objValue, othValue [, index|key, object, other, stack]).
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="value">The value to compare</param>
        /// <param name="other">The other value to compare</param>
        /// <param name="customizer">The function to customize comparisons</param>
        /// <returns>Returns true if the values are equivalent, else false.</returns>
        bool IsEqualWith(object value, object other, Func<object, bool> customizer);

        /// <summary>
        /// Checks if value is an Error, EvalError, RangeError, ReferenceError, SyntaxError, TypeError, or URIError object.
        /// </summary>
        /// <since>3.0.0</since>
        /// <param name="value">The value to check.</param>
        /// <returns>Returns true if value is an error object, else false.</returns>
        bool IsError(object value);

        /// <summary>
        /// Checks if value is a finite primitive number.
        /// </summary>
        /// <since>0.1.0</since>
        /// <remarks>This method is based on Number.isFinite.</remarks>
        /// <param name="value">The value to check.</param>
        /// <returns>Returns true if value is a finite number, else false.</returns>
        bool IsFinite(object value);

        /// <summary>
        /// Checks if value is classified as a Function object.
        /// </summary>
        /// <since>0.1.0</since>
        /// <remarks>This method is based on Number.isFinite.</remarks>
        /// <param name="value">The value to check.</param>
        /// <returns>Returns true if value is a function, else false.</returns>
        bool IsFunction(object value);

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
