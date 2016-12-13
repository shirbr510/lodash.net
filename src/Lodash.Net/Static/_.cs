using System;
using Lodash.Net.Data.Instance;
using Lodash.Net.Data.Instance.Abstract;
using Lodash.Net.DI;
using Microsoft.Extensions.DependencyInjection;

namespace Lodash.Net.Static
{
    public static class _
    {
        private static readonly Lazy<ILodashInstance> LodashLazy;

        static _()
        {
            LodashLazy = new Lazy<ILodashInstance>(InitializeLodash);
        }

        public static ILodashInstance Instance => LodashLazy.Value;

        private static ILodashInstance InitializeLodash()
        {
            var serviceProvider = LodashServiceProvider.GetServiceProvider();
            var lodashInstance = serviceProvider.GetService<ILodashInstance>();
            return lodashInstance;
        }
    }
}
