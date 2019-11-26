using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;
using AutoMapper;

namespace PubgStats.AppCore.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddAspDependencies(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
