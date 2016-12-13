using Lodash.Net.Data.Instance.Abstract;
using Lodash.Net.DI;
using Microsoft.Extensions.DependencyInjection;

namespace Lodash.Net.Static
{
    public static class _
    {
        public static ILodashInstance Instance => LodashServiceProvider.Instance.GetService<ILodashInstance>();
    }
}
