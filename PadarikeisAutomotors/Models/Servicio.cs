namespace PadarikeisAutomotors.Models;

public partial class Servicio
{
	public int ServicioId { get; set; }

	public string Imagen { get; set; } = null!;

	public string Nombre { get; set; } = null!;

	public double Precio { get; set; }

	public string Texto { get; set; } = null!;

	public virtual ICollection<ServicioRegistrado> ServiciosRegistrados { get; } = new List<ServicioRegistrado>();
}
