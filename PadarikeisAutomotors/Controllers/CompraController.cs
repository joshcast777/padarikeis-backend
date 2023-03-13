using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PadarikeisAutomotors.Data;
using PadarikeisAutomotors.Models;

namespace PadarikeisAutomotors.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CompraController : ControllerBase
	{
		private readonly AppDbContext _context;

		public CompraController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/Compra
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Compra>>> GetCompras()
		{
			if (_context.Compras == null)
			{
				return NotFound();
			}
			return await _context.Compras.ToListAsync();
		}

		// GET: api/Compra/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Compra>> GetCompra(int id)
		{
			if (_context.Compras == null)
			{
				return NotFound();
			}
			var compra = await _context.Compras.FindAsync(id);

			if (compra == null)
			{
				return NotFound();
			}

			return compra;
		}

		// PUT: api/Compra/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutCompra(int id, Compra compra)
		{
			if (id != compra.CompraId)
			{
				return BadRequest();
			}

			_context.Entry(compra).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!CompraExists(id))
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

		// POST: api/Compra
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Compra>> PostCompra(Compra compra)
		{
			if (_context.Compras == null)
			{
				return Problem("Entity set 'AppDbContext.Compras'  is null.");
			}
			_context.Compras.Add(compra);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetCompra", new { id = compra.CompraId }, compra);
		}

		// DELETE: api/Compra/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCompra(int id)
		{
			if (_context.Compras == null)
			{
				return NotFound();
			}
			var compra = await _context.Compras.FindAsync(id);
			if (compra == null)
			{
				return NotFound();
			}

			_context.Compras.Remove(compra);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool CompraExists(int id)
		{
			return (_context.Compras?.Any(e => e.CompraId == id)).GetValueOrDefault();
		}
	}
}
