using SistemaGestionData.DataAccess;
using SistemaGestionEntities;

namespace SistemaGestionBusiness.Business;

public class VentasBusiness
{
    private VentaDataAccess _VentasDataAccess;

    public VentasBusiness(VentaDataAccess VentasDataAccess)
    {
        _VentasDataAccess = VentasDataAccess;
    }
    public List<Venta> GetVentas()
    {
        return _VentasDataAccess.GetVentas();
    }
    public Venta? GetOneVenta(int id)
    {
        return _VentasDataAccess.GetOneVenta(id);
    }
    public void InsertVenta(Venta Venta)
    {
        _VentasDataAccess.InsertVenta(Venta);
    }
    public void UpdateVenta(int id, Venta Venta)
    {
        _VentasDataAccess.UpdateVenta(id, Venta);
    }
    public void DeleteVenta(int id)
    {
        _VentasDataAccess.DeleteVenta(id);
    }
}
