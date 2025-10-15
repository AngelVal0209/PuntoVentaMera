using System.ComponentModel.DataAnnotations;

namespace Proyecto.WEB.Models.ViewModels
{
    public class ProductoViewModel
    {
        [Key]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string Nombre { get; set; } = null!;

        [StringLength(250, ErrorMessage = "La descripción no puede exceder los 250 caracteres")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Debe ingresar el precio de compra")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio de compra debe ser mayor que 0")]
        public decimal PrecioCompra { get; set; }

        [Required(ErrorMessage = "Debe ingresar el precio de venta")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio de venta debe ser mayor que 0")]
        public decimal PrecioVenta { get; set; }

        [Required(ErrorMessage = "Debe ingresar el stock disponible")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
        public int? Stock { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una categoría")]
        public int IdCategoria { get; set; }

        public string? NombreCategoria { get; set; }

        [Display(Name = "Activo")]
        public bool Activo { get; set; } = true; 


        [StringLength(50, ErrorMessage = "El código de barras no puede exceder los 50 caracteres")]
        public string? CodigoBarras { get; set; }
    }
}
