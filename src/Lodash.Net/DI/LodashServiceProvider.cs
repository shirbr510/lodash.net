using System;
using Lodash.Net.Data.Instance;
using Lodash.Net.Data.Instance.Abstract;
using Lodash.Net.Workers;
using Lodash.Net.Workers.Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace Lodash.Net.DI
{
    public static class LodashServiceProvider
    {
        public static IServiceProvider GetServiceProvider()
        {
            var services = new ServiceCollection();

            services.AddTransient<ILodashInstance, LodashInstance>();
            services.AddTransient<ILodashDate, LodashDate>();
            services.AddTransient<ILodashMath, LodashMath>();
            services.AddTransient<ILodashNumber, LodashNumber>();
            return services.BuildServiceProvider();
        }
    }
}
