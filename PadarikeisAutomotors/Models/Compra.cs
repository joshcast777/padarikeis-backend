namespace PadarikeisAutomotors.Models;

public partial class Compra
{
	public int CompraId { get; set; }

	public string NombreTarjeta { get; set; } = null!;

	public string NumeroTarjeta { get; set; } = null!;

	public string CodigoSeguridad { get; set; } = null!;

	public string FechaVencimiento { get; set; } = null!;

	public int UsuarioId { get; set; }

	public virtual Usuario? Usuario { get; set; } = null!;
}
