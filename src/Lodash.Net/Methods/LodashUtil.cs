using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Lodash.Net.Methods.Abstract;

namespace Lodash.Net.Methods
{
    public class LodashUtil : ILodashUtil
    {
        public Func<object, object> Property(params string[] path) => obj => GetProperty(obj, SplitProperties(path));

        public Func<TObject, TProperty> Property<TObject, TProperty>(params string[] path) => obj => GetProperty<TObject, TProperty>(obj, SplitProperties(path));

        private static TProperty GetProperty<TObject, TProperty>(TObject obj, IEnumerable<string> path) => GetProperty<TProperty>(obj, path);

        private static TProperty GetProperty<TProperty>(object obj, IEnumerable<string> path)
        {
            var property = GetProperty(obj, path);
            return (TProperty)property;
        }

        private static object GetProperty(object obj, IEnumerable<string> path)
        {
            var leaf = obj;
            foreach (var property in path)
            {
                leaf = leaf.GetType().GetTypeInfo().GetProperty(property).GetValue(leaf);
            }
            return leaf;
        }

        private static IEnumerable<string> SplitProperties(IEnumerable<string> path) => path.SelectMany(str => str.Split('.'));
    }
}
