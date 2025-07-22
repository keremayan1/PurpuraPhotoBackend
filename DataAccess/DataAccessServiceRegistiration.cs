using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Context;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class DataAccessServiceRegistiration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
        {
            services.AddDbContext<SQLContext>();
            services.AddScoped<IAlbumStatusDal, AlbumStatusDal>();
            return services;
        }

    }
}
