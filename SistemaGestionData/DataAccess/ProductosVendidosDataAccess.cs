using SistemaGestionData.Context;
using SistemaGestionEntities;

namespace SistemaGestionData.DataAccess;

public class ProductoVendidoDataAccess
{
    private BioTecnologyContext _context;
    public ProductoVendidoDataAccess(BioTecnologyContext context)
    {
        _context = context;
    }
    public List<ProductoVendido> GetProductosVendidos()
    {
        return _context.ProductosVendidos.ToList();
    }
    public ProductoVendido? GetOneProductoVendido(int id)
    {
        return _context.ProductosVendidos.FirstOrDefault(productoVendido => productoVendido.Id == id); ;
    }
    public void InsertProductoVendido(ProductoVendido productoVendido)
    {
        _context.ProductosVendidos.Add(productoVendido);
        _context.SaveChanges();
    }
    public void UpdateProductoVendido(int id, ProductoVendido productoVendido)
    {
        ProductoVendido? productoVendidoAEditar = GetOneProductoVendido(id);
        if (productoVendidoAEditar != null)
        {
            productoVendidoAEditar.IdProducto = productoVendido.IdProducto;
            productoVendidoAEditar.Stock = productoVendido.Stock;
            productoVendidoAEditar.IdVenta = productoVendido.IdVenta;

            _context.SaveChanges();
        }
    }
    public void DeleteProductoVendido(int id)
    {
        ProductoVendido? productoVendidoAEliminar = GetOneProductoVendido(id);
        if (productoVendidoAEliminar != null)
        {
            _context.ProductosVendidos.Remove(productoVendidoAEliminar);
            _context.SaveChanges();
        }
    }
}