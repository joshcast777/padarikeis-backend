namespace PadarikeisAutomotors.Models;

public partial class CapacitacionRegistrada
{
	public int CapacitacionRegistradaId { get; set; }

	public string Ocupacion { get; set; } = null!;

	public string Lugar { get; set; } = null!;

	public string Hora { get; set; } = null!;

	public string Motivo { get; set; } = null!;

	public int UsuarioId { get; set; }

	public int CapacitacionId { get; set; }

	public virtual Capacitacion? Capacitacion { get; set; } = null!;

	public virtual Usuario? Usuario { get; set; } = null!;
}
