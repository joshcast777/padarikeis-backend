using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PadarikeisAutomotors.Data;
using PadarikeisAutomotors.Models;

namespace PadarikeisAutomotors.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductoController : ControllerBase
	{
		private readonly AppDbContext _context;

		public ProductoController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/Producto
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
		{
			if (_context.Productos == null)
			{
				return NotFound();
			}
			return await _context.Productos.ToListAsync();
		}

		// GET: api/Producto/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Producto>> GetProducto(int id)
		{
			if (_context.Productos == null)
			{
				return NotFound();
			}
			var producto = await _context.Productos.FindAsync(id);

			if (producto == null)
			{
				return NotFound();
			}

			return producto;
		}

		// PUT: api/Producto/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		// [HttpPut("{id}")]
		// public async Task<IActionResult> PutProducto(int id, Producto producto)
		// {
		// 	if (id != producto.ProductoId)
		// 	{
		// 		return BadRequest();
		// 	}

		// 	_context.Entry(producto).State = EntityState.Modified;

		// 	try
		// 	{
		// 		await _context.SaveChangesAsync();
		// 	}
		// 	catch (DbUpdateConcurrencyException)
		// 	{
		// 		if (!ProductoExists(id))
		// 		{
		// 			return NotFound();
		// 		}
		// 		else
		// 		{
		// 			throw;
		// 		}
		// 	}

		// 	return NoContent();
		// }

		// POST: api/Producto
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		// [HttpPost]
		// public async Task<ActionResult<Producto>> PostProducto(Producto producto)
		// {
		// 	if (_context.Productos == null)
		// 	{
		// 		return Problem("Entity set 'AppDbContext.Productos'  is null.");
		// 	}
		// 	_context.Productos.Add(producto);
		// 	await _context.SaveChangesAsync();

		// 	return CreatedAtAction("GetProducto", new { id = producto.ProductoId }, producto);
		// }

		// DELETE: api/Producto/5
		// [HttpDelete("{id}")]
		// public async Task<IActionResult> DeleteProducto(int id)
		// {
		// 	if (_context.Productos == null)
		// 	{
		// 		return NotFound();
		// 	}
		// 	var producto = await _context.Productos.FindAsync(id);
		// 	if (producto == null)
		// 	{
		// 		return NotFound();
		// 	}

		// 	_context.Productos.Remove(producto);
		// 	await _context.SaveChangesAsync();

		// 	return NoContent();
		// }

		// private bool ProductoExists(int id)
		// {
		// 	return (_context.Productos?.Any(e => e.ProductoId == id)).GetValueOrDefault();
		// }
	}
}
