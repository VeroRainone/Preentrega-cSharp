using System.ComponentModel.DataAnnotations;

namespace SistemaGestionEntities;

public class ProductoVendido
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El campo Id del Producto es requerido.")]
    [Range(0, double.MaxValue, ErrorMessage = "El Id del Producto debe ser mayor o igual a 0.")]
    public int IdProducto { get; set; }


    [Required(ErrorMessage = "El campo Stock es requerido.")]
    [Range(0, double.MaxValue, ErrorMessage = "El Stock debe ser mayor o igual a 0.")]
    public int Stock { get; set; }

    [Required(ErrorMessage = "El campo Id Venta es requerido.")]
    [Range(0, double.MaxValue, ErrorMessage = "El Id Venta debe ser mayor o igual a 0.")]
    public int IdVenta { get; set; }
}