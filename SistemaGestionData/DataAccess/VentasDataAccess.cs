using SistemaGestionData.Context;
using SistemaGestionEntities;

namespace SistemaGestionData.DataAccess;

public class VentaDataAccess
{
    private BioTecnologyContext _context;
    public VentaDataAccess(BioTecnologyContext context)
    {
        _context = context;
    }
    public List<Venta> GetVentas()
    {
        return _context.Ventas.ToList();
    }
    public Venta? GetOneVenta(int id)
    {
        return _context.Ventas.FirstOrDefault(Venta => Venta.Id == id); ;
    }
    public void InsertVenta(Venta Venta)
    {
        _context.Ventas.Add(Venta);
        _context.SaveChanges();
    }
    public void UpdateVenta(int id, Venta Venta)
    {
        Venta? VentaAEditar = GetOneVenta(id);
        if (VentaAEditar != null)
        {
            VentaAEditar.Comentarios = Venta.Comentarios;
            VentaAEditar.IdUsuario = Venta.IdUsuario;

            _context.SaveChanges();
        }
    }
    public void DeleteVenta(int id)
    {
        Venta? VentaAEliminar = GetOneVenta(id);
        if (VentaAEliminar != null)
        {
            _context.Ventas.Remove(VentaAEliminar);
            _context.SaveChanges();
        }
    }
}