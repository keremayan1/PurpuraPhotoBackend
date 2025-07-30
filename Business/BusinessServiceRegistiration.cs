using Business.Abstract;
using Business.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    public static class BusinessServiceRegistiration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IAlbumStatusService, AlbumStatusManager>();
            services.AddScoped<IAlbumService, AlbumManager>();
            return services;

        }

    }
}
