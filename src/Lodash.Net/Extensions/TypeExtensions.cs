using System;

namespace Lodash.Net.Extensions
{
    internal static class TypeExtensions
    {
        public static bool IsNumeric(this Type type)
        {
            return type != null && type != typeof(DateTime) &&
                   (type == typeof(short) || type == typeof(int) || type == typeof(long) || type == typeof(decimal) ||
                    type == typeof(float) || type == typeof(double) || type == typeof(bool));
        }
    }
}