using System;
using Lodash.Net.Data.Instance;
using Lodash.Net.Data.Instance.Abstract;
using Lodash.Net.Logics.Cloners;
using Lodash.Net.Logics.Cloners.Abstract;
using Lodash.Net.Logics.Randomizers;
using Lodash.Net.Logics.Randomizers.Abstract;
using Lodash.Net.Methods;
using Lodash.Net.Methods.Abstract;
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
            services.AddSingleton<IRandomizer<double>, FloatingRandomizer>();
            services.AddSingleton<IDeepCloner, DeepObjectCloner>();
            services.AddSingleton<IShallowCloner, ShallowObjectCloner>();

            //Transients
            services.AddTransient<ILodashDate, LodashDate>();
            services.AddTransient<ILodashLang, LodashLang>();
            services.AddTransient<ILodashMath, LodashMath>();
            services.AddTransient<ILodashNumber, LodashNumber>();
            services.AddTransient<ILodashUtil, LodashUtil>();
            return services.BuildServiceProvider();
        }
    }
}
