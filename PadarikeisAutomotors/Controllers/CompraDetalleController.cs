using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PadarikeisAutomotors.Data;
using PadarikeisAutomotors.Models;

namespace PadarikeisAutomotors.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CompraDetalleController : ControllerBase
	{
		private readonly AppDbContext _context;

		public CompraDetalleController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/CompraDetalle
		[HttpGet]
		public async Task<ActionResult<IEnumerable<CompraDetalle>>> GetCompraDetalles()
		{
			if (_context.CompraDetalles == null)
			{
				return NotFound();
			}
			return await _context.CompraDetalles.ToListAsync();
		}

		// GET: api/CompraDetalle/5
		[HttpGet("{id}")]
		public async Task<ActionResult<CompraDetalle>> GetCompraDetalle(int id)
		{
			if (_context.CompraDetalles == null)
			{
				return NotFound();
			}
			var compraDetalle = await _context.CompraDetalles.FindAsync(id);

			if (compraDetalle == null)
			{
				return NotFound();
			}

			return compraDetalle;
		}

		// PUT: api/CompraDetalle/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutCompraDetalle(int id, CompraDetalle compraDetalle)
		{
			if (id != compraDetalle.CompraDetalleId)
			{
				return BadRequest();
			}

			_context.Entry(compraDetalle).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!CompraDetalleExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		// POST: api/CompraDetalle
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<CompraDetalle>> PostCompraDetalle(CompraDetalle compraDetalle)
		{
			if (_context.CompraDetalles == null)
			{
				return Problem("Entity set 'AppDbContext.CompraDetalles'  is null.");
			}
			_context.CompraDetalles.Add(compraDetalle);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetCompraDetalle", new { id = compraDetalle.CompraDetalleId }, compraDetalle);
		}

		// DELETE: api/CompraDetalle/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCompraDetalle(int id)
		{
			if (_context.CompraDetalles == null)
			{
				return NotFound();
			}
			var compraDetalle = await _context.CompraDetalles.FindAsync(id);
			if (compraDetalle == null)
			{
				return NotFound();
			}

			_context.CompraDetalles.Remove(compraDetalle);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool CompraDetalleExists(int id)
		{
			return (_context.CompraDetalles?.Any(e => e.CompraDetalleId == id)).GetValueOrDefault();
		}
	}
}
