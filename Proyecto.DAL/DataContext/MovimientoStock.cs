using System;
using System.Collections.Generic;

namespace Proyecto.DAL.DataContext;

public partial class MovimientoStock
{
    public int IdMovimiento { get; set; }

    public int IdProducto { get; set; }

    public string? Tipo { get; set; }

    public int Cantidad { get; set; }

    public DateTime? Fecha { get; set; }

    public int? IdUsuario { get; set; }

    public string? Referencia { get; set; }

    public string? Motivo { get; set; }

    public virtual Producto IdProductoNavigation { get; set; } = null!;

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
