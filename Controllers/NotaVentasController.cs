using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoUsabilidad.Data;
using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Controllers
{
    [Route("api/notaventa")]
    [ApiController]
    [EnableCors("AllowSpecificOrigin")]
    public class NotaVentasController : ControllerBase
    {
        private readonly DataContext _context;

        public NotaVentasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NotaVentas>>> GetNotaVentas()
        {
            return await _context.NotaVentas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NotaVentas>> GetNotaVentasId(int id)
        {
            var notaVentas = await _context.NotaVentas.FindAsync(id);

            if (notaVentas == null)
            {
                return NotFound();
            }

            return notaVentas;
        }

        [HttpPost]
        public async Task<ActionResult<NotaVentas>> PostNotaVentas(NotaVentas notaVentas)
        {
            _context.NotaVentas.Add(notaVentas);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNotaVentas), new { id = notaVentas.NumeroNota }, notaVentas);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutNotaVentas(int id, NotaVentas notaVentas)
        {
            if (id != notaVentas.NumeroNota)
            {
                return BadRequest();
            }

            _context.Entry(notaVentas).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNotaVentas(int id)
        {
            var notaVentas = await _context.NotaVentas.FindAsync(id);
            if (notaVentas == null)
            {
                return NotFound();
            }

            _context.NotaVentas.Remove(notaVentas);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
