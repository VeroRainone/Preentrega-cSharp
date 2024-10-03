using SistemaGestionData.DataAccess;
using SistemaGestionEntities;

namespace SistemaGestionBusiness.Business;

public class ProductosVendidosBusiness
{
    private ProductoVendidoDataAccess _productosVendidosDataAccess;

    public ProductosVendidosBusiness(ProductoVendidoDataAccess productosVendidosDataAccess)
    {
        _productosVendidosDataAccess = productosVendidosDataAccess;
    }
    public List<ProductoVendido> GetProductosVendidos()
    {
        return _productosVendidosDataAccess.GetProductosVendidos();
    }
    public ProductoVendido? GetOneProductoVendido(int id)
    {
        return _productosVendidosDataAccess.GetOneProductoVendido(id);
    }
    public void InsertProductoVendido(ProductoVendido productoVendido)
    {
        _productosVendidosDataAccess.InsertProductoVendido(productoVendido);
    }
    public void UpdateProductoVendido(int id, ProductoVendido productoVendido)
    {
        _productosVendidosDataAccess.UpdateProductoVendido(id, productoVendido);
    }
    public void DeleteProductoVendido(int id)
    {
        _productosVendidosDataAccess.DeleteProductoVendido(id);
    }
}
