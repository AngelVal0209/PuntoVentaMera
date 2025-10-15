using System;
using System.Collections.Generic;

namespace Proyecto.DAL.DataContext;

public partial class Ventum
{
    public int IdVenta { get; set; }

    public int? IdCliente { get; set; }

    public int IdUsuario { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal Total { get; set; }

    public bool? EsFiado { get; set; }

    public decimal? SaldoPendiente { get; set; }

    public bool? Pagado { get; set; }

    public DateOnly? FechaPagoEstimada { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<PagoFiado> PagoFiados { get; set; } = new List<PagoFiado>();
}
