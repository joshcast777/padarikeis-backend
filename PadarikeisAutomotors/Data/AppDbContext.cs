using Microsoft.EntityFrameworkCore;
using PadarikeisAutomotors.Models;

namespace PadarikeisAutomotors.Data;

public partial class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	public virtual DbSet<Capacitacion> Capacitaciones { get; set; }

	public virtual DbSet<CategoriaProducto> CategoriaProductos { get; set; }

	public virtual DbSet<Producto> Productos { get; set; }

	public virtual DbSet<Servicio> Servicios { get; set; }

	public virtual DbSet<Usuario> Usuarios { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder
			.UseCollation("utf8_general_ci")
			.HasCharSet("utf8");

		modelBuilder.Entity<Capacitacion>(entity =>
		{
			entity.HasKey(e => e.CapacitacionId).HasName("PRIMARY");

			entity.ToTable("capacitaciones");

			entity.Property(e => e.CapacitacionId)
				.HasColumnType("int(11)")
				.HasColumnName("capacitacion_id");
			entity.Property(e => e.Imagen)
				.HasMaxLength(255)
				.HasColumnName("imagen");
			entity.Property(e => e.Nombre)
				.HasMaxLength(100)
				.HasColumnName("nombre");
			entity.Property(e => e.Texto)
				.HasMaxLength(500)
				.HasColumnName("texto");
		});

		modelBuilder.Entity<CategoriaProducto>(entity =>
		{
			entity.HasKey(e => e.CategoriaProductoId).HasName("PRIMARY");

			entity.ToTable("categoria_productos");

			entity.Property(e => e.CategoriaProductoId)
				.HasColumnType("int(11)")
				.HasColumnName("categoria_producto_id");
			entity.Property(e => e.Nombre)
				.HasMaxLength(50)
				.HasColumnName("nombre");
		});

		modelBuilder.Entity<Producto>(entity =>
		{
			entity.HasKey(e => e.ProductoId).HasName("PRIMARY");

			entity.ToTable("productos");

			entity.HasIndex(e => e.CategoriaProductoId, "fk_productos_categoria_productos");

			entity.Property(e => e.ProductoId)
				.HasColumnType("int(11)")
				.HasColumnName("producto_id");
			entity.Property(e => e.CategoriaProductoId)
				.HasColumnType("int(11)")
				.HasColumnName("categoria_producto_id");
			entity.Property(e => e.Imagen)
				.HasMaxLength(255)
				.HasColumnName("imagen");
			entity.Property(e => e.Nombre)
				.HasMaxLength(50)
				.HasColumnName("nombre");
			entity.Property(e => e.Precio)
				.HasColumnType("double(5,2)")
				.HasColumnName("precio");

			entity.HasOne(d => d.CategoriaProducto).WithMany(p => p.Productos)
				.HasForeignKey(d => d.CategoriaProductoId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_productos_categoria_productos");
		});

		modelBuilder.Entity<Servicio>(entity =>
		{
			entity.HasKey(e => e.ServicioId).HasName("PRIMARY");

			entity.ToTable("servicios");

			entity.Property(e => e.ServicioId)
				.HasColumnType("int(11)")
				.HasColumnName("servicio_id");
			entity.Property(e => e.Imagen)
				.HasMaxLength(255)
				.HasColumnName("imagen");
			entity.Property(e => e.Nombre)
				.HasMaxLength(100)
				.HasColumnName("nombre");
			entity.Property(e => e.Precio)
				.HasColumnType("double(5,2)")
				.HasColumnName("precio");
			entity.Property(e => e.Texto)
				.HasMaxLength(500)
				.HasColumnName("texto");
		});

		modelBuilder.Entity<Usuario>(entity =>
		{
			entity.HasKey(e => e.UsuarioId).HasName("PRIMARY");

			entity.ToTable("usuarios");

			entity.Property(e => e.UsuarioId)
				.HasColumnType("int(11)")
				.HasColumnName("usuario_id");
			entity.Property(e => e.Apellido)
				.HasMaxLength(30)
				.HasColumnName("apellido");
			entity.Property(e => e.Cedula)
				.HasMaxLength(10)
				.HasColumnName("cedula");
			entity.Property(e => e.Celular)
				.HasMaxLength(10)
				.HasColumnName("celular");
			entity.Property(e => e.Ciudad)
				.HasMaxLength(30)
				.HasColumnName("ciudad");
			entity.Property(e => e.Contrasena)
				.HasMaxLength(60)
				.HasColumnName("contrasena");
			entity.Property(e => e.Email)
				.HasMaxLength(50)
				.HasColumnName("email");
			entity.Property(e => e.Nombre)
				.HasMaxLength(30)
				.HasColumnName("nombre");
		});

		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

	public DbSet<PadarikeisAutomotors.Models.Capacitacion> Capacitacion { get; set; } = default!;
}
