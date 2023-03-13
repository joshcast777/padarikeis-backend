using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PadarikeisAutomotors.Data;
using PadarikeisAutomotors.Models;

namespace PadarikeisAutomotors.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServicioRegistradoController : ControllerBase
	{
		private readonly AppDbContext _context;

		public ServicioRegistradoController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/ServicioRegistrado/5
		[HttpGet("{usuarioId}")]
		public async Task<ActionResult<IEnumerable<ServicioRegistrado>>> GetServiciosRegistrados(int usuarioId)
		{
			if (_context.ServiciosRegistrados == null)
			{
				return NotFound();
			}
			return await _context.ServiciosRegistrados.ToListAsync();
		}

		// GET: api/ServicioRegistrado/5/6
		[HttpGet("{usuarioId}/{id}")]
		public async Task<ActionResult<ServicioRegistrado>> GetServicioRegistrado(int usuarioId, int id)
		{
			if (_context.ServiciosRegistrados == null)
			{
				return NotFound();
			}
			var servicioRegistrado = await _context.ServiciosRegistrados.FindAsync(id);

			if (servicioRegistrado == null)
			{
				return NotFound();
			}

			return servicioRegistrado;
		}

		// PUT: api/ServicioRegistrado/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutServicioRegistrado(int id, ServicioRegistrado servicioRegistrado)
		{
			if (id != servicioRegistrado.ServicioRegistradoId)
			{
				return BadRequest();
			}

			_context.Entry(servicioRegistrado).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!ServicioRegistradoExists(id))
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

		// POST: api/ServicioRegistrado
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<ServicioRegistrado>> PostServicioRegistrado(ServicioRegistrado servicioRegistrado)
		{
			if (_context.ServiciosRegistrados == null)
			{
				return Problem("Entity set 'AppDbContext.ServiciosRegistrados'  is null.");
			}
			_context.ServiciosRegistrados.Add(servicioRegistrado);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetServicioRegistrado", new { id = servicioRegistrado.ServicioRegistradoId }, servicioRegistrado);
		}

		// DELETE: api/ServicioRegistrado/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteServicioRegistrado(int id)
		{
			if (_context.ServiciosRegistrados == null)
			{
				return NotFound();
			}
			var servicioRegistrado = await _context.ServiciosRegistrados.FindAsync(id);
			if (servicioRegistrado == null)
			{
				return NotFound();
			}

			_context.ServiciosRegistrados.Remove(servicioRegistrado);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool ServicioRegistradoExists(int id)
		{
			return (_context.ServiciosRegistrados?.Any(e => e.ServicioRegistradoId == id)).GetValueOrDefault();
		}
	}
}
