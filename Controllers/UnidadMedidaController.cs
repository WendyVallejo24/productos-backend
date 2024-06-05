using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoUsabilidad.Data;
using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Controllers
{
    [Route("api/unidadmedida")]
    [ApiController]
    [EnableCors("AllowSpecificOrigin")]
    public class UnidadMedidaController : ControllerBase
    {
        private readonly DataContext _context;

        public UnidadMedidaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UnidadMedida>>> GetUnidadMedida()
        {
            return await _context.UnidadMedida.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UnidadMedida>> GetUnidadMedida(int id)
        {
            var unidadMedida = await _context.UnidadMedida.FindAsync(id);

            if (unidadMedida == null)
            {
                return NotFound();
            }

            return unidadMedida;
        }

        [HttpPost]
        public async Task<ActionResult<UnidadMedida>> PostUnidadMedida(UnidadMedida unidadMedida)
        {
            _context.UnidadMedida.Add(unidadMedida);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUnidadMedida), new { id = unidadMedida.IdUnidadMed }, unidadMedida);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnidadMedida(int id, UnidadMedida unidadMedida)
        {
            if (id != unidadMedida.IdUnidadMed)
            {
                return BadRequest();
            }

            _context.Entry(unidadMedida).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnidadMedida(int id)
        {
            var unidadMedida = await _context.UnidadMedida.FindAsync(id);
            if (unidadMedida == null)
            {
                return NotFound();
            }

            _context.UnidadMedida.Remove(unidadMedida);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
