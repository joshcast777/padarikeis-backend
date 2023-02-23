using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PadarikeisAutomotors.Data;
using PadarikeisAutomotors.Models;

namespace PadarikeisAutomotors.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServicioController : ControllerBase
	{
		private readonly AppDbContext _context;

		public ServicioController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/Servicios
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Servicio>>> GetServicios()
		{
			if (_context.Servicios == null)
			{
				return NotFound();
			}
			return await _context.Servicios.ToListAsync();
		}

		// GET: api/Servicios/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Servicio>> GetServicio(int id)
		{
			if (_context.Servicios == null)
			{
				return NotFound();
			}
			var servicio = await _context.Servicios.FindAsync(id);

			if (servicio == null)
			{
				return NotFound();
			}

			return servicio;
		}

		// PUT: api/Servicios/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		// [HttpPut("{id}")]
		// public async Task<IActionResult> PutServicio(int id, Servicio servicio)
		// {
		// 	if (id != servicio.ServicioId)
		// 	{
		// 		return BadRequest();
		// 	}

		// 	_context.Entry(servicio).State = EntityState.Modified;

		// 	try
		// 	{
		// 		await _context.SaveChangesAsync();
		// 	}
		// 	catch (DbUpdateConcurrencyException)
		// 	{
		// 		if (!ServicioExists(id))
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

		// POST: api/Servicios
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		// [HttpPost]
		// public async Task<ActionResult<Servicio>> PostServicio(Servicio servicio)
		// {
		// 	if (_context.Servicios == null)
		// 	{
		// 		return Problem("Entity set 'AppDbContext.Servicios'  is null.");
		// 	}
		// 	_context.Servicios.Add(servicio);
		// 	await _context.SaveChangesAsync();

		// 	return CreatedAtAction("GetServicio", new { id = servicio.ServicioId }, servicio);
		// }

		// DELETE: api/Servicios/5
		// [HttpDelete("{id}")]
		// public async Task<IActionResult> DeleteServicio(int id)
		// {
		// 	if (_context.Servicios == null)
		// 	{
		// 		return NotFound();
		// 	}
		// 	var servicio = await _context.Servicios.FindAsync(id);
		// 	if (servicio == null)
		// 	{
		// 		return NotFound();
		// 	}

		// 	_context.Servicios.Remove(servicio);
		// 	await _context.SaveChangesAsync();

		// 	return NoContent();
		// }

		// private bool ServicioExists(int id)
		// {
		// 	return (_context.Servicios?.Any(e => e.ServicioId == id)).GetValueOrDefault();
		// }
	}
}
