using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PadarikeisAutomotors.Data;
using PadarikeisAutomotors.Models;

namespace PadarikeisAutomotors.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CapacitacionRegistradaController : ControllerBase
	{
		private readonly AppDbContext _context;

		public CapacitacionRegistradaController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/CapacitacionRegistrada/5
		[HttpGet("{usuarioId}")]
		public async Task<ActionResult<IEnumerable<CapacitacionRegistrada>>> GetCapacitacionesRegistradas(int usuarioId)
		{
			if (_context.CapacitacionesRegistradas == null)
			{
				return NotFound();
			}
			return await _context.CapacitacionesRegistradas
				.Where(capacitacionRegistrada => capacitacionRegistrada.UsuarioId == usuarioId)
				.Include(capacitacionRegistrada => capacitacionRegistrada.Capacitacion)
				.ToListAsync();
		}

		// GET: api/CapacitacionRegistrada/5/6
		[HttpGet("{usuarioId}/{id}")]
		public async Task<ActionResult<CapacitacionRegistrada>> GetCapacitacionRegistrada(int id)
		{
			if (_context.CapacitacionesRegistradas == null)
			{
				return NotFound();
			}
			var capacitacionRegistrada = await _context.CapacitacionesRegistradas.FindAsync(id);

			if (capacitacionRegistrada == null)
			{
				return NotFound();
			}

			return capacitacionRegistrada;
		}

		// PUT: api/CapacitacionRegistrada/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutCapacitacionRegistrada(int id, CapacitacionRegistrada capacitacionRegistrada)
		{
			if (id != capacitacionRegistrada.CapacitacionRegistradaId)
			{
				return BadRequest();
			}

			_context.Entry(capacitacionRegistrada).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!CapacitacionRegistradaExists(id))
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

		// POST: api/CapacitacionRegistrada
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<CapacitacionRegistrada>> PostCapacitacionRegistrada(CapacitacionRegistrada capacitacionRegistrada)
		{
			if (_context.CapacitacionesRegistradas == null)
			{
				return Problem("Entity set 'AppDbContext.CapacitacionesRegistradas'  is null.");
			}
			_context.CapacitacionesRegistradas.Add(capacitacionRegistrada);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetCapacitacionRegistrada", new { id = capacitacionRegistrada.CapacitacionRegistradaId }, capacitacionRegistrada);
		}

		// DELETE: api/CapacitacionRegistrada/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCapacitacionRegistrada(int id)
		{
			if (_context.CapacitacionesRegistradas == null)
			{
				return NotFound();
			}
			var capacitacionRegistrada = await _context.CapacitacionesRegistradas.FindAsync(id);
			if (capacitacionRegistrada == null)
			{
				return NotFound();
			}

			_context.CapacitacionesRegistradas.Remove(capacitacionRegistrada);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool CapacitacionRegistradaExists(int id)
		{
			return (_context.CapacitacionesRegistradas?.Any(e => e.CapacitacionRegistradaId == id)).GetValueOrDefault();
		}
	}
}
