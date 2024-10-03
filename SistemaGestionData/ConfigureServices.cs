using Microsoft.Extensions.DependencyInjection;
using SistemaGestionData.Context;
using SistemaGestionData.DataAccess;

namespace SistemaGestionData;

public static class ConfigureServices
{
    public static IServiceCollection ConfigureDataLayer (this IServiceCollection services)
    {
        services.AddDbContext<BioTecnologyContext>();
        services.AddScoped<ProductoDataAccess>();
        services.AddScoped<UsuariosDataAccess>();
        services.AddScoped<VentaDataAccess>();
        services.AddScoped<ProductoVendidoDataAccess>();
        return services;
    }
}
