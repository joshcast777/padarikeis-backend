using System;
using System.Collections.Generic;

namespace PadarikeisAutomotors.Models;

public partial class Capacitacione
{
    public int CapacitacionId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Imagen { get; set; } = null!;

    public string Texto { get; set; } = null!;
}
