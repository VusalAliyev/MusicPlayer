using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer;

public static class ServiceConfiguration
{
    public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DbConnection")));
        services.AddScoped<IAlbumRepository, AlbumRepository>();
        services.AddScoped<IPlaylistRepository, PlaylistRepository>();


        return services;
    }
}
