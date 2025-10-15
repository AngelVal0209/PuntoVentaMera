using System;
using System.Collections.Generic;

namespace Proyecto.DAL.DataContext;

public partial class PagoFiado
{
    public int IdPago { get; set; }

    public int IdVenta { get; set; }

    public DateTime? FechaPago { get; set; }

    public decimal MontoPagado { get; set; }

    public string? Observacion { get; set; }

    public virtual Ventum IdVentaNavigation { get; set; } = null!;
}
