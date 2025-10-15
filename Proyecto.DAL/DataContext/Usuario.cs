using System;
using System.Collections.Generic;

namespace Proyecto.DAL.DataContext;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Usuario1 { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public int IdRol { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual Rol IdRolNavigation { get; set; } = null!;

    public virtual ICollection<MovimientoStock> MovimientoStocks { get; set; } = new List<MovimientoStock>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
