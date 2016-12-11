using System;
using Lodash.Net.Data.Instance;
using Lodash.Net.Data.Instance.Abstract;

namespace Lodash.Net.Static
{
    public static class _
    {
        private static readonly Lazy<ILodashInstance> LodashLazy;

        static _()
        {
            LodashLazy = new Lazy<ILodashInstance>(() => new LodashInstance());
        }
        public static ILodashInstance Instance => LodashLazy.Value;

    }
}
