namespace PadarikeisAutomotors.Models;

public partial class Producto
{
	public int ProductoId { get; set; }

	public string Imagen { get; set; } = null!;

	public string Nombre { get; set; } = null!;

	public double Precio { get; set; }

	public int CategoriaProductoId { get; set; }

	public virtual CategoriaProducto CategoriaProducto { get; set; } = null!;

	public virtual ICollection<CompraDetalle> CompraDetalles { get; } = new List<CompraDetalle>();
}
