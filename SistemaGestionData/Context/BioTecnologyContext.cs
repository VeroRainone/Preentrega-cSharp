using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;

namespace SistemaGestionData.Context;

public class BioTecnologyContext: DbContext
{
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Venta> Ventas { get; set; }
    public DbSet<ProductoVendido> ProductosVendidos { get; set; }
    public BioTecnologyContext()
        : base() { }
    public BioTecnologyContext(DbContextOptions<BioTecnologyContext> options)
        : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-8EA6I4K\\SQLEXPRESS;Initial Catalog=BioTecnology;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
    }
}
