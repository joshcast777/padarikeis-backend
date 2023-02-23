using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PadarikeisAutomotors.Data;
using PadarikeisAutomotors.Models;

namespace PadarikeisAutomotors.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CapacitacionController : ControllerBase
	{
		private readonly AppDbContext _context;

		public CapacitacionController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/Capacitacion
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Capacitacion>>> GetCapacitacion()
		{
			if (_context.Capacitacion == null)
			{
				return NotFound();
			}
			return await _context.Capacitacion.ToListAsync();
		}

		// GET: api/Capacitacion/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Capacitacion>> GetCapacitacion(int id)
		{
			if (_context.Capacitacion == null)
			{
				return NotFound();
			}
			var capacitacion = await _context.Capacitacion.FindAsync(id);

			if (capacitacion == null)
			{
				return NotFound();
			}

			return capacitacion;
		}

		// PUT: api/Capacitacion/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutCapacitacion(int id, Capacitacion capacitacion)
		{
			if (id != capacitacion.CapacitacionId)
			{
				return BadRequest();
			}

			_context.Entry(capacitacion).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!CapacitacionExists(id))
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

		// POST: api/Capacitacion
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Capacitacion>> PostCapacitacion(Capacitacion capacitacion)
		{
			if (_context.Capacitacion == null)
			{
				return Problem("Entity set 'AppDbContext.Capacitacion'  is null.");
			}
			_context.Capacitacion.Add(capacitacion);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetCapacitacion", new { id = capacitacion.CapacitacionId }, capacitacion);
		}

		// DELETE: api/Capacitacion/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCapacitacion(int id)
		{
			if (_context.Capacitacion == null)
			{
				return NotFound();
			}
			var capacitacion = await _context.Capacitacion.FindAsync(id);
			if (capacitacion == null)
			{
				return NotFound();
			}

			_context.Capacitacion.Remove(capacitacion);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool CapacitacionExists(int id)
		{
			return (_context.Capacitacion?.Any(e => e.CapacitacionId == id)).GetValueOrDefault();
		}
	}
}
