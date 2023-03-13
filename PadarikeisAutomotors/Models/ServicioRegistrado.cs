namespace PadarikeisAutomotors.Models;

public partial class ServicioRegistrado
{
	public int ServicioRegistradoId { get; set; }

	public string PlacaVehiculo { get; set; } = null!;

	public string MarcaVehiculo { get; set; } = null!;

	public int AnioVehiculo { get; set; }

	public int UsuarioId { get; set; }

	public int ServicioId { get; set; }

	public virtual Servicio? Servicio { get; set; } = null!;

	public virtual Usuario? Usuario { get; set; } = null!;
}
