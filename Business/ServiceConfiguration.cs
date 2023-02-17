using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BusinessLayer;

public static class ServiceConfiguration
{
    public static IServiceCollection AddBussines(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped<IAlbumService, AlbumManager>();
        services.AddScoped<IPlaylistService, PlaylistManager>();
        return services;
    }

}
