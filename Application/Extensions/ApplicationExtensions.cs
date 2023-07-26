using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Ports;
using Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Extensions;

namespace Application.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services){
            services.AddScoped<IOrderService, OrderService>();
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly( typeof(ApplicationExtensions).Assembly));

            return services;
        }
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration){
            services.AddPersistenceContext(configuration);
            services.AddPeristenceRepositories();
            return services;
        }
    }
}