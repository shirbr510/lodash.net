using System;
using Lodash.Net.Data.Instance;
using Lodash.Net.Data.Instance.Abstract;
using Lodash.Net.Workers;
using Lodash.Net.Workers.Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace Lodash.Net.DI
{
    public class LodashServiceProvider
    {
        private static readonly Lazy<IServiceProvider> LazyServiceProvider;

        static LodashServiceProvider()
        {
            LazyServiceProvider = new Lazy<IServiceProvider>(InitializeServiceProvider);
        }

        public static IServiceProvider Instance => LazyServiceProvider.Value;

        private static IServiceProvider InitializeServiceProvider()
        {
            var services = new ServiceCollection();

            //Singletons
            services.AddSingleton<ILodashInstance, LodashInstance>();

            //Transients
            services.AddTransient<ILodashDate, LodashDate>();
            services.AddTransient<ILodashMath, LodashMath>();
            services.AddTransient<ILodashNumber, LodashNumber>();
            return services.BuildServiceProvider();
        }
    }
}
