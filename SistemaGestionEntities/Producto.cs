using System.ComponentModel.DataAnnotations;

namespace SistemaGestionEntities;

public class Producto
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El campo Descripción es requerido.")]
    [MaxLength(250, ErrorMessage = "La Descripción no puede tener más de 250 caracteres.")]
    [MinLength(5, ErrorMessage = "La Descripción debe tener al menos 5 caracteres.")]
    [Display(Name = "Descripción")]
    public string Descripcion { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo Costo es requerido.")]
    [Range(0, double.MaxValue, ErrorMessage = "El Costo debe ser mayor o igual a 0.")]
    [Display(Name = "Costo")]
    public double Costo { get; set; }

    [Required(ErrorMessage = "El campo Precio de Venta es requerido.")]
    [Range(0, double.MaxValue, ErrorMessage = "El Precio de Venta debe ser mayor o igual a 0.")]
    [Display(Name = "Precio de Venta")]
    public double PrecioVenta { get; set; }

    [Required(ErrorMessage = "El campo Stock es requerido.")]
    [Range(0, double.MaxValue, ErrorMessage = "El Stock debe ser mayor o igual a 0.")]
    public int Stock { get; set; }

    [Required(ErrorMessage = "El campo Id de Usuario es requerido.")]
    [Range(0, double.MaxValue, ErrorMessage = "El Id de Usuario debe ser mayor o igual a 0.")]
    public int IdUsuario { get; set; }
}