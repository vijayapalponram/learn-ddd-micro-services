using Domain.Ports;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence.Extensions
{
    public static class PersistenceExtensions
    {
        public static void AddPersistenceContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryDBContext>(
                options => options.UseSqlServer("Data Source=localhost,1433;Initial Catalog=Shopping;User ID=sa;Password=reallyStrongPwd123;Integrated Security=false;Trust Server Certificate=false;Encrypt=false",
                b => b.MigrationsAssembly(typeof(RepositoryDBContext).Assembly.FullName)));

            services.AddScoped<IRepositoryDBContext, RepositoryDBContext>();
        }

        public static IServiceCollection AddPeristenceRepositories(this IServiceCollection services){
            
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>))
            .AddScoped<IOrderRepository, OrderRepository>();
            return services;
        }

    }
}