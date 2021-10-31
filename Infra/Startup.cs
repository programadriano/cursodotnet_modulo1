using API.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infra
{
    public static class Message
    {
        public static void ConfigureInfrastruture(this IServiceCollection services)
        {
            #region [DI]
            services.AddSingleton<ILifecycleService, LifecycleService>();
            services.AddSingleton<Lifecycle2Service>();

            //services.AddTransient<ILifecycleService, LifecycleService>();
            //services.AddTransient<Lifecycle2Service>();

            //services.AddScoped<ILifecycleService, LifecycleService>();
            //services.AddScoped<Lifecycle2Service>();

            #endregion
        }
    }
}
