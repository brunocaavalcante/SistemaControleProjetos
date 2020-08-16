using Business.Interfaces;
using Business.Services;
using Data.Context;
using Data.Repository;
using Microsoft.Extensions.DependencyInjection;


namespace Web.Configurations
{
    public static class DependecyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MyDbContext>();
            services.AddScoped<IContaRepository, ContaRepository>();

            services.AddScoped<IContaService, ContaService>();

            return services;
        }
    }
}
