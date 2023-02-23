using System;
using System.Collections.Generic;

namespace PadarikeisAutomotors.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string Imagen { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public double Precio { get; set; }

    public int CategoriaProductoId { get; set; }

    public virtual CategoriaProducto CategoriaProducto { get; set; } = null!;
}
