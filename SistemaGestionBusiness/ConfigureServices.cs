using Microsoft.Extensions.DependencyInjection;
using SistemaGestionBusiness.Business;
using SistemaGestionData;

namespace SistemaGestionBusiness;

public static class ConfigureServices
{   
    public static IServiceCollection ConfigureBusinessLayer(this IServiceCollection services)
    {
        services.ConfigureDataLayer();
        services.AddScoped<ProductosBusiness> ();
        services.AddScoped<UsuariosBusiness>();
        services.AddScoped<VentasBusiness>();
        services.AddScoped<ProductosVendidosBusiness>();

        return services;
    }
}
