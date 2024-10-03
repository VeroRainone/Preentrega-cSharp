using System.ComponentModel.DataAnnotations;

namespace SistemaGestionEntities;

public class Venta
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El campo Comentarios es requerido.")]
    [MaxLength(250, ErrorMessage = "Los Comentarios no puede tener más de 250 caracteres.")]
    [MinLength(5, ErrorMessage = "Los Comentarios debe tener al menos 5 caracteres.")]
    [Display(Name = "Comentarios")]
    public string Comentarios { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo Id de Usuario es requerido.")]
    [Range(0, double.MaxValue, ErrorMessage = "El Id de Usuario debe ser mayor o igual a 0.")]
    public int IdUsuario { get; set; }
}
