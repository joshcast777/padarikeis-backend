namespace PadarikeisAutomotors.Models;

public partial class CategoriaProducto
{
	public int CategoriaProductoId { get; set; }

	public string Nombre { get; set; } = null!;

	public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
