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
			if (_context.Capacitaciones == null)
			{
				return NotFound();
			}
			return await _context.Capacitaciones.ToListAsync();
		}

		// GET: api/Capacitacion/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Capacitacion>> GetCapacitacion(int id)
		{
			if (_context.Capacitaciones == null)
			{
				return NotFound();
			}
			var capacitacion = await _context.Capacitaciones.FindAsync(id);

			if (capacitacion == null)
			{
				return NotFound();
			}

			return capacitacion;
		}
	}
}
