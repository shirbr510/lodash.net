using System;

namespace Lodash.Net.Extensions
{
    public static class DoubleExtensions
    {
        public static bool IsInteger(this double number) => Math.Abs(number % 1) >= double.Epsilon;
    }
}
