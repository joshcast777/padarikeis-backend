using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using PadarikeisAutomotors.Data;
using PadarikeisAutomotors.Models;

namespace PadarikeisAutomotors.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsuarioAutenticadoController : ControllerBase
	{
		private readonly AppDbContext _context;
		private readonly IConfiguration _configuration;

		public UsuarioAutenticadoController(AppDbContext context, IConfiguration configuration)
		{
			_context = context;
			_configuration = configuration;
		}

		// 	// POST: api/UsuarioAutenticado/Login
		// 	// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost("Login")]
		public async Task<ActionResult> PostUsuarioAutentiacdo(UsuarioAutenticado usuarioAutenticado)
		{
			var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email.Equals(usuarioAutenticado.Email) && u.Contrasena.Equals(usuarioAutenticado.Contrasena));

			if (usuario == null) return BadRequest("InvalidEmailOrPassword");
			else return Ok(JsonConvert.SerializeObject(GenerarToken(usuario)));
		}

		// 	// POST: api/UsuarioAutentiado/Register
		// 	// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost("Register")]
		public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
		{
			if (_context.Usuarios == null) return Problem("Entity set 'AppDbContext.Users'  is null.");

			_context.Usuarios.Add(usuario);
			await _context.SaveChangesAsync();

			return Ok(JsonConvert.SerializeObject(GenerarToken(usuario)));
		}

		private string GenerarToken(Usuario usuario)
		{
			var claims = new List<Claim>
			{
				new Claim(ClaimTypes.NameIdentifier, usuario.UsuarioId.ToString()),
				new Claim(ClaimTypes.Email, usuario.Email)
			};

			var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value!));

			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(claims),
				Expires = System.DateTime.Now.AddDays(1),
				SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature)
			};

			var tokenHandler = new JwtSecurityTokenHandler();

			return tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
		}
	}
}