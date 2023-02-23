using System;
using System.Collections.Generic;

namespace PadarikeisAutomotors.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string Cedula { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public string Celular { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Contrasena { get; set; } = null!;
}
