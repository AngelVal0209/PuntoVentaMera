using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.WEB.Models.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre de usuario no puede exceder los 50 caracteres")]
        [Display(Name = "Usuario")]
        public string Usuario1 { get; set; } = null!;

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [StringLength(100, ErrorMessage = "La contraseña no puede exceder los 100 caracteres")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Clave { get; set; } = null!;

        [Required(ErrorMessage = "Debe seleccionar un rol")]
        [Display(Name = "Rol")]
        public int IdRol { get; set; }

        [Display(Name = "Nombre del Rol")]
        public string? NombreRol { get; set; }

        [Display(Name = "Fecha de Creación")]
        [DataType(DataType.Date)]
        public DateTime? FechaCreacion { get; set; }

        [Display(Name = "Activo")]
        public bool Activo { get; set; } = true;
    }
}
