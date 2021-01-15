using Microsoft.Extensions.DependencyInjection;
using System;

namespace HotelERP
{
    public static class Framework
    {
        private static IServiceProvider serviceProvider;

        public static IServiceProvider provider => serviceProvider;
        public static void StartUp()
        {
            var services = new ServiceCollection();


            //helpers
            services.AddScoped<IShortCuts, ShortCuts>();
            services.AddScoped<Login>();
            services.AddScoped<MainForm>();

            serviceProvider = services.BuildServiceProvider();
        }
    }
}
