using System;
using System.Collections.Generic;

namespace Proyecto.DAL.DataContext;

public partial class DetalleCompra
{
    public int IdDetalle { get; set; }

    public int IdCompra { get; set; }

    public int IdProducto { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioCompra { get; set; }

    public decimal? Subtotal { get; set; }

    public virtual Compra IdCompraNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
