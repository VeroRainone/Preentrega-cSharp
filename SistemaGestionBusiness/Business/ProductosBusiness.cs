using SistemaGestionData.DataAccess;
using SistemaGestionEntities;

namespace SistemaGestionBusiness.Business;

public class ProductosBusiness
{
    private ProductoDataAccess _productosDataAccess;

    public ProductosBusiness(ProductoDataAccess productosDataAccess)
    {
        _productosDataAccess = productosDataAccess;
    }
    public List<Producto> GetProductos()
    {
        return _productosDataAccess.GetProductos();
    }
    public Producto? GetOneProducto(int id)
    {
        return _productosDataAccess.GetOneProducto(id);
    }
    public void InsertProducto(Producto producto)
    {
        _productosDataAccess.InsertProducto(producto);
    }
    public void UpdateProducto(int id, Producto producto)
    {
        _productosDataAccess.UpdateProducto(id, producto);
    }
    public void DeleteProducto(int id)
    {
        _productosDataAccess.DeleteProducto(id);
    }
}