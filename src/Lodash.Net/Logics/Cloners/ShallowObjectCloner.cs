using System;
using System.Collections.Generic;
using System.Reflection;
using Lodash.Net.Logics.Cloners.Abstract;

namespace Lodash.Net.Logics.Cloners
{
    public class ShallowObjectCloner : IShallowCloner
    {
        public object Clone(object source)
        {
            var clone = Activator.CreateInstance(source.GetType());
            var fields = source.GetType().GetTypeInfo().GetFields(BindingFlags.Public | BindingFlags.Instance);
            return ApplyFields(source, fields, clone);
        }

        public T Clone<T>(T source)
        {
            var clone = Activator.CreateInstance<T>();
            var fields = typeof(T).GetTypeInfo().GetFields(BindingFlags.Public | BindingFlags.Instance);
            return ApplyFields(source, fields, clone);
        }

        private static T ApplyFields<T>(T source, IEnumerable<FieldInfo> fields, T clone)
        {
            foreach (var field in fields)
            {
                var value = field.GetValue(source);
                field.SetValue(clone, value);
            }
            return clone;
        }
    }
}
