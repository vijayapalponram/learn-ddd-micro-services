using WebApi.Message.Handlers;

namespace WebApi.Extensions
{
    public static class LibraryServices
    {
       public static IServiceCollection AddLibraryServices(this IServiceCollection services){
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly( typeof(LibraryServices).Assembly));
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly( typeof(CreateOrderCommandHandler).Assembly));

            return services;
        } 
    }
}