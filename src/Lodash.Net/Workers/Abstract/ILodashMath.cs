using System;
using System.Collections.Generic;

namespace Lodash.Net.Workers.Abstract
{
    public interface ILodashMath
    {
        /// <summary>
        /// Adds two numbers.
        /// </summary>
        /// <since>3.4.0</since>
        /// <param name="augend">The first number in an addition.</param>
        /// <param name="addend">The second number in an addition.</param>
        /// <returns>Returns the total.</returns>
        double Add(double augend, double addend);

        /// <summary>
        /// Computes number rounded up to precision.
        /// </summary>
        /// <since>3.10.0</since>
        /// <param name="number">The number to round up.</param>
        /// <param name="precision">The precision to round up to.</param>
        /// <returns>Returns the rounded up number.</returns>
        double Ceil(double number, int precision = 0);

        /// <summary>
        /// Divide two numbers.
        /// </summary>
        /// <since>4.7.0</since>
        /// <param name="dividend">The first number in a division.</param>
        /// <param name="divisor">The second number in a division.</param>
        /// <returns>Returns the quotient.</returns>
        double Divide(double dividend, double divisor);

        /// <summary>
        /// Computes number rounded down to precision.
        /// </summary>
        /// <since>3.10.0</since>
        /// <param name="number">The number to round down.</param>
        /// <param name="precision">The precision to round down to.</param>
        /// <returns>Returns the rounded down number.</returns>
        double Floor(double number, int precision = 0);

        /// <summary>
        /// Computes the maximum value of array. If array is empty or falsey, undefined is returned.
        /// </summary>
        /// <since>0.1.0</since>
        /// <param name="enumerable">The array to iterate over.</param>
        /// <returns>Returns the maximum value.</returns>
        T Max<T>(IEnumerable<T> enumerable);

        /// <summary>
        /// This method is like _.max except that it accepts iteratee which is invoked for each element in array to generate the criterion by which the value is ranked. The iteratee is invoked with one argument: (value).
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="enumerable">The array to iterate over.</param>
        /// <param name="iteratee">The iteratee invoked per element</param>
        /// <returns>Returns the maximum value.</returns>
        TSource MaxBy<TSource, TResult>(IEnumerable<TSource> enumerable, Func<TSource, TResult> iteratee);

        /// <summary>
        /// This method is like _.max except that it accepts iteratee which is invoked for each element in array to generate the criterion by which the value is ranked. The iteratee is invoked with one argument: (value).
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="enumerable">The array to iterate over.</param>
        /// <param name="iteratee">The property iteratee invoked per element</param>
        /// <returns>Returns the maximum value.</returns>
        T MaxBy<T>(IEnumerable<T> enumerable, string iteratee);

        /// <summary>
        /// Computes the mean of the values in array.
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="enumerable">The array to iterate over.</param>
        /// <returns>Returns the mean.</returns>
        double Mean<T>(IEnumerable<T> enumerable);

        /// <summary>
        /// This method is like _.mean except that it accepts iteratee which is invoked for each element in array to generate the criterion by which the value is ranked. The iteratee is invoked with one argument: (value).
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="enumerable">The array to iterate over.</param>
        /// <param name="iteratee">The iteratee invoked per element</param>
        /// <returns>Returns the mean.</returns>
        double MeanBy<T>(IEnumerable<T> enumerable, Func<T, double> iteratee);

        /// <summary>
        /// This method is like _.mean except that it accepts iteratee which is invoked for each element in array to generate the value to be averaged. The iteratee is invoked with one argument: (value).
        /// </summary>
        /// <since>4.7.0</since>
        /// <param name="enumerable">The array to iterate over.</param>
        /// <param name="iteratee">The property iteratee invoked per element</param>
        /// <returns>Returns the mean.</returns>
        double MeanBy<T>(IEnumerable<T> enumerable, string iteratee);

        /// <summary>
        /// Computes the minimum value of array. If array is empty or falsey, null is returned.
        /// </summary>
        /// <since>0.1.0</since>
        /// <param name="enumerable">The array to iterate over.</param>
        /// <returns>Returns the minimum value.</returns>
        T Min<T>(IEnumerable<T> enumerable);

        /// <summary>
        /// This method is like _.min except that it accepts iteratee which is invoked for each element in array to generate the criterion by which the value is ranked. The iteratee is invoked with one argument: (value).
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="enumerable">The array to iterate over.</param>
        /// <param name="iteratee">The iteratee invoked per element</param>
        /// <returns>Returns the minimum value.</returns>
        TSource MinBy<TSource, TResult>(IEnumerable<TSource> enumerable, Func<TSource, TResult> iteratee);

        /// <summary>
        /// This method is like _.min except that it accepts iteratee which is invoked for each element in array to generate the criterion by which the value is ranked. The iteratee is invoked with one argument: (value).
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="enumerable">The array to iterate over.</param>
        /// <param name="iteratee">The property iteratee invoked per element</param>
        /// <returns>Returns the minimum value.</returns>
        T MinBy<T>(IEnumerable<T> enumerable, string iteratee);

        /// <summary>
        /// Multiply two numbers.
        /// </summary>
        /// <since>4.7.0</since>
        /// <param name="multiplier">The first number in a multiplication.</param>
        /// <param name="multiplicand">The second number in a multiplication.</param>
        /// <returns>Returns the product.</returns>
        double Multiply(double multiplier, double multiplicand);

        /// <summary>
        /// Computes number rounded to precision.
        /// </summary>
        /// <since>3.10.0</since>
        /// <param name="number">The number to round.</param>
        /// <param name="precision">The precision to round to.</param>
        /// <returns>Returns the rounded number.</returns>
        double Round(double number, int precision = 0);

        /// <summary>
        /// Subtract two numbers.
        /// </summary>
        /// <since>3.4.0</since>
        /// <param name="minuend">The first number in a subtraction.</param>
        /// <param name="subtrahend">The second number in a subtraction.</param>
        /// <returns>Returns the difference.</returns>
        double Substract(double minuend, double subtrahend);

        /// <summary>
        /// Computes the sum of the values in array.
        /// </summary>
        /// <since>3.4.0</since>
        /// <param name="enumerable">The array to iterate over.</param>
        /// <returns>Returns the sum.</returns>
        double Sum<T>(IEnumerable<T> enumerable);

        /// <summary>
        /// This method is like _.sum except that it accepts iteratee which is invoked for each element in array to generate the value to be summed. The iteratee is invoked with one argument: (value).
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="enumerable">The array to iterate over.</param>
        /// <param name="iteratee">The iteratee invoked per element</param>
        /// <returns>Returns the sum.</returns>
        double SumBy<T>(IEnumerable<T> enumerable, Func<T, double> iteratee);

        /// <summary>
        /// This method is like _.sum except that it accepts iteratee which is invoked for each element in array to generate the criterion by which the value is ranked. The iteratee is invoked with one argument: (value).
        /// </summary>
        /// <since>4.0.0</since>
        /// <param name="enumerable">The array to iterate over.</param>
        /// <param name="iteratee">The property iteratee invoked per element</param>
        /// <returns>Returns the sum.</returns>
        double SumBy<T>(IEnumerable<T> enumerable, string iteratee);
    }
}
