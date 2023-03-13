using Microsoft.EntityFrameworkCore;
using PadarikeisAutomotors.Models;

namespace PadarikeisAutomotors.Data;

public partial class AppDbContext : DbContext
{
	public virtual DbSet<Capacitacion> Capacitaciones { get; set; } = null!;

	public virtual DbSet<CapacitacionRegistrada> CapacitacionesRegistradas { get; set; } = null!;

	public virtual DbSet<CategoriaProducto> CategoriaProductos { get; set; } = null!;

	public virtual DbSet<Compra> Compras { get; set; } = null!;

	public virtual DbSet<CompraDetalle> CompraDetalles { get; set; } = null!;

	public virtual DbSet<Producto> Productos { get; set; } = null!;

	public virtual DbSet<Servicio> Servicios { get; set; } = null!;

	public virtual DbSet<ServicioRegistrado> ServiciosRegistrados { get; set; } = null!;

	public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

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

		modelBuilder.Entity<CapacitacionRegistrada>(entity =>
		{
			entity.HasKey(e => e.CapacitacionRegistradaId).HasName("PRIMARY");

			entity.ToTable("capacitaciones_registradas");

			entity.HasIndex(e => e.CapacitacionId, "fk_capacitaciones_registradas_capacitaciones");

			entity.HasIndex(e => e.UsuarioId, "fk_capacitaciones_registradas_usuarios");

			entity.Property(e => e.CapacitacionRegistradaId)
				.HasColumnType("int(11)")
				.HasColumnName("capacitacion_registrada_id");
			entity.Property(e => e.CapacitacionId)
				.HasColumnType("int(11)")
				.HasColumnName("capacitacion_id");
			entity.Property(e => e.Hora)
				.HasMaxLength(50)
				.HasColumnName("hora");
			entity.Property(e => e.Lugar)
				.HasMaxLength(20)
				.HasColumnName("lugar");
			entity.Property(e => e.Motivo)
				.HasMaxLength(225)
				.HasColumnName("motivo");
			entity.Property(e => e.Ocupacion)
				.HasMaxLength(30)
				.HasColumnName("ocupacion");
			entity.Property(e => e.UsuarioId)
				.HasColumnType("int(11)")
				.HasColumnName("usuario_id");

			entity.HasOne(d => d.Capacitacion).WithMany()
				.HasForeignKey(d => d.CapacitacionId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_capacitaciones_registradas_capacitaciones");

			entity.HasOne(d => d.Usuario).WithMany()
				.HasForeignKey(d => d.UsuarioId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_capacitaciones_registradas_usuarios");
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

		modelBuilder.Entity<Compra>(entity =>
		{
			entity.HasKey(e => e.CompraId).HasName("PRIMARY");

			entity.ToTable("compras");

			entity.HasIndex(e => e.UsuarioId, "fk_compras_usuarios");

			entity.Property(e => e.CompraId)
				.HasColumnType("int(11)")
				.HasColumnName("compra_id");
			entity.Property(e => e.CodigoSeguridad)
				.HasMaxLength(5)
				.HasColumnName("codigo_seguridad");
			entity.Property(e => e.FechaVencimiento)
				.HasMaxLength(10)
				.HasColumnName("fecha_vencimiento");
			entity.Property(e => e.NombreTarjeta)
				.HasMaxLength(100)
				.HasColumnName("nombre_tarjeta");
			entity.Property(e => e.NumeroTarjeta)
				.HasMaxLength(16)
				.HasColumnName("numero_tarjeta");
			entity.Property(e => e.UsuarioId)
				.HasColumnType("int(11)")
				.HasColumnName("usuario_id");

			entity.HasOne(d => d.Usuario).WithMany()
				.HasForeignKey(d => d.UsuarioId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_compras_usuarios");
		});

		modelBuilder.Entity<CompraDetalle>(entity =>
		{
			entity.HasKey(e => e.CompraDetalleId).HasName("PRIMARY");

			entity.ToTable("compra_detalles");

			entity.HasIndex(e => e.CompraId, "fk_compra_detalles_compras");

			entity.HasIndex(e => e.ProductoId, "fk_compra_detalles_productos");

			entity.Property(e => e.CompraDetalleId)
				.HasColumnType("int(11)")
				.HasColumnName("compra_detalle_id");
			entity.Property(e => e.Cantidad)
				.HasColumnType("int(11)")
				.HasColumnName("cantidad");
			entity.Property(e => e.CompraId)
				.HasColumnType("int(11)")
				.HasColumnName("compra_id");
			entity.Property(e => e.ProductoId)
				.HasColumnType("int(11)")
				.HasColumnName("producto_id");

			entity.HasOne(d => d.Compra).WithMany()
				.HasForeignKey(d => d.CompraId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_compra_detalles_compras");

			entity.HasOne(d => d.Producto).WithMany(p => p.CompraDetalles)
				.HasForeignKey(d => d.ProductoId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_compra_detalles_productos");
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

		modelBuilder.Entity<ServicioRegistrado>(entity =>
		{
			entity.HasKey(e => e.ServicioRegistradoId).HasName("PRIMARY");

			entity.ToTable("servicios_registrados");

			entity.HasIndex(e => e.ServicioId, "fk_servicios_registrados_servicios");

			entity.HasIndex(e => e.UsuarioId, "fk_servicios_registrados_usuarios");

			entity.Property(e => e.ServicioRegistradoId)
				.HasColumnType("int(11)")
				.HasColumnName("servicio_registrado_id");
			entity.Property(e => e.AnioVehiculo)
				.HasColumnType("int(11)")
				.HasColumnName("anio_vehiculo");
			entity.Property(e => e.MarcaVehiculo)
				.HasMaxLength(30)
				.HasColumnName("marca_vehiculo");
			entity.Property(e => e.PlacaVehiculo)
				.HasMaxLength(20)
				.HasColumnName("placa_vehiculo");
			entity.Property(e => e.ServicioId)
				.HasColumnType("int(11)")
				.HasColumnName("servicio_id");
			entity.Property(e => e.UsuarioId)
				.HasColumnType("int(11)")
				.HasColumnName("usuario_id");

			entity.HasOne(d => d.Servicio).WithMany()
				.HasForeignKey(d => d.ServicioId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_servicios_registrados_servicios");

			entity.HasOne(d => d.Usuario).WithMany()
				.HasForeignKey(d => d.UsuarioId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_servicios_registrados_usuarios");
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
}
