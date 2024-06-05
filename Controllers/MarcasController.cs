using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoUsabilidad.Data;
using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Controllers
{
    [Route("api/marcas")]
    [ApiController]
    [EnableCors("AllowSpecificOrigin")]
    public class MarcasController : ControllerBase
    {
        private readonly DataContext _context;

        public MarcasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Marcas>>> GetMarcas()
        {
            return await _context.Marcas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Marcas>> GetMarcas(int id)
        {
            var marca = await _context.Marcas.FindAsync(id);

            if (marca == null)
            {
                return NotFound();
            }

            return marca;
        }

        [HttpPost]
        public async Task<ActionResult<Marcas>> PostMarcas(Marcas marca)
        {
            _context.Marcas.Add(marca);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMarcas), new { id = marca.IdMarca }, marca);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMarcas(int id, Marcas marca)
        {
            if (id != marca.IdMarca)
            {
                return BadRequest();
            }

            _context.Entry(marca).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMarcas(int id)
        {
            var marca = await _context.Marcas.FindAsync(id);
            if (marca == null)
            {
                return NotFound();
            }

            _context.Marcas.Remove(marca);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
