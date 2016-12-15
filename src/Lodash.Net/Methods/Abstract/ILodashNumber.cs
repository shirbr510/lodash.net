using System;

namespace Lodash.Net.Methods.Abstract
{
    public interface ILodashNumber
    {
        /// <summary>
        /// Clamps number within the inclusive lower and upper bounds.
        /// </summary>
        /// <since>4.0.0</since>
        /// <typeparam name="T">the type to clamp by</typeparam>
        /// <param name="number">The number to clamp</param>
        /// <param name="lower">The lower bound</param>
        /// <param name="upper">The upper bound</param>
        /// <returns>Returns the clamped number</returns>
        T Clamp<T>(T number, T lower, T upper) where T : IComparable<T>;

        /// <summary>
        /// Checks if n is between start and up to, but not including, end. If end is not specified, it's set to start with start then set to 0. If start is greater than end the params are swapped to support negative ranges.
        /// </summary>
        /// <since>3.3.0</since>
        /// <typeparam name="T">the type to clamp by</typeparam>
        /// <param name="number">The number to check</param>
        /// <param name="start">The start of the range</param>
        /// <param name="upper">The end of the range</param>
        /// <returns>Returns true if number is in the range, else false</returns>
        bool InRange<T>(T number, T start, T upper) where T : IComparable<T>;

        /// <summary>
        /// Checks if n is between start and up to, but not including, end. If end is not specified, it's set to start with start then set to 0. If start is greater than end the params are swapped to support negative ranges.
        /// </summary>
        /// <since>3.3.0</since>
        /// <typeparam name="T">the type to InRange by</typeparam>
        /// <param name="number">The number to check</param>
        /// <param name="upper">The end of the range</param>
        /// <returns>Returns true if number is in the range, else false</returns>
        bool InRange<T>(T number, T upper) where T : IComparable<T>;

        /// <summary>
        /// Produces a random number between the inclusive lower and upper bounds. If only one argument is provided a number between 0 and the given number is returned. If floating is true, or either lower or upper are floats, a floating-point number is returned instead of an integer.
        /// </summary>
        /// <since>0.7.0</since>
        /// <remarks>JavaScript follows the IEEE-754 standard for resolving floating-point values which can produce unexpected results.</remarks>
        /// <param name="upper">The upper bound</param>
        /// <returns>Returns the random number</returns>
        double Random(double upper);

        /// <summary>
        /// Produces a random number between the inclusive lower and upper bounds. If only one argument is provided a number between 0 and the given number is returned. If floating is true, or either lower or upper are floats, a floating-point number is returned instead of an integer.
        /// </summary>
        /// <since>0.7.0</since>
        /// <remarks>JavaScript follows the IEEE-754 standard for resolving floating-point values which can produce unexpected results.</remarks>
        /// <param name="lower">The lower bound</param>
        /// <param name="upper">The upper bound</param>
        /// <returns>Returns the random number</returns>
        double Random(double lower, double upper);

        /// <summary>
        /// Produces a random number between the inclusive lower and upper bounds. If only one argument is provided a number between 0 and the given number is returned. If floating is true, or either lower or upper are floats, a floating-point number is returned instead of an integer.
        /// </summary>
        /// <since>0.7.0</since>
        /// <remarks>JavaScript follows the IEEE-754 standard for resolving floating-point values which can produce unexpected results.</remarks>
        /// <param name="upper">The upper bound</param>
        /// <param name="floating">Specify returning a floating-point number</param>
        /// <returns>Returns the random number</returns>
        double Random(double upper, bool floating);

        /// <summary>
        /// Produces a random number between the inclusive lower and upper bounds. If only one argument is provided a number between 0 and the given number is returned. If floating is true, or either lower or upper are floats, a floating-point number is returned instead of an integer.
        /// </summary>
        /// <since>0.7.0</since>
        /// <remarks>JavaScript follows the IEEE-754 standard for resolving floating-point values which can produce unexpected results.</remarks>
        /// <param name="lower">The lower bound</param>
        /// <param name="upper">The upper bound</param>
        /// <param name="floating">Specify returning a floating-point number</param>
        /// <returns>Returns the random number</returns>
        double Random(double lower, double upper, bool floating);
    }
}
