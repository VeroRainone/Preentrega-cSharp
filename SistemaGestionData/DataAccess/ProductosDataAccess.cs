using SistemaGestionData.Context;
using SistemaGestionEntities;

namespace SistemaGestionData.DataAccess;

public class ProductoDataAccess
{
    private BioTecnologyContext _context;
    public ProductoDataAccess(BioTecnologyContext context)
    {
        _context = context;
    }
    public List<Producto> GetProductos()
    {
        return _context.Productos.ToList();
    }
    public Producto? GetOneProducto(int id)
    {
        return _context.Productos.FirstOrDefault(producto => producto.Id == id); ;
    }
    public void InsertProducto(Producto producto)
    {
        _context.Productos.Add(producto);
        _context.SaveChanges();
    }
    public void UpdateProducto(int id, Producto producto)
    {
        Producto? productoAEditar = GetOneProducto(id);
        if (productoAEditar != null)
        {
            productoAEditar.Descripcion = producto.Descripcion;
            productoAEditar.Costo = producto.Costo;
            productoAEditar.PrecioVenta = producto.PrecioVenta;
            productoAEditar.Stock = producto.Stock;
            productoAEditar.IdUsuario = producto.IdUsuario;

            _context.SaveChanges();
        }
    }
    public void DeleteProducto(int id)
    {
        Producto? productoAEliminar = GetOneProducto(id);
        if (productoAEliminar != null)
        {
            _context.Productos.Remove(productoAEliminar);
            _context.SaveChanges();
        }
    }
}