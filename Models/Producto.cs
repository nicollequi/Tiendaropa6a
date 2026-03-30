using System.ComponentModel.DataAnnotations;

namespace TiendaRopa.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La talla es obligatoria")]
        [StringLength(10)]
        public string Talla { get; set; } = string.Empty;

        [Required(ErrorMessage = "El color es obligatorio")]
        [StringLength(50)]
        public string Color { get; set; } = string.Empty;

        [Required]
        [Range(0, 1000000, ErrorMessage = "El precio debe ser mayor a 0")]
        public double Precio { get; set; }

        [Range(0, 100, ErrorMessage = "El stock no puede ser negativo")]
        public int Stock { get; set; }

        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}