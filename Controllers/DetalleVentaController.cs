using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoUsabilidad.Data;
using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Controllers
{
    [Route("api/detalleventa")]
    [ApiController]
    [EnableCors("AllowSpecificOrigin")]
    public class DetalleVentaController : ControllerBase
    {
        private readonly DataContext _context;

        public DetalleVentaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleVenta>>> GetDetalleVenta()
        {
            return await _context.DetalleVenta.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleVenta>> GetDetalleVenta(int id)
        {
            var detalleVenta = await _context.DetalleVenta.FindAsync(id);

            if (detalleVenta == null)
            {
                return NotFound();
            }

            return detalleVenta;
        }

        [HttpPost]
        public async Task<ActionResult<DetalleVenta>> PostDetalleVenta(DetalleVenta detalleVenta)
        {
            _context.DetalleVenta.Add(detalleVenta);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDetalleVenta), new { id = detalleVenta.IdDetalle }, detalleVenta);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleVenta(int id, DetalleVenta detalleVenta)
        {
            if (id != detalleVenta.IdDetalle)
            {
                return BadRequest();
            }

            _context.Entry(detalleVenta).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalleVenta(int id)
        {
            var detalleVenta = await _context.DetalleVenta.FindAsync(id);
            if (detalleVenta == null)
            {
                return NotFound();
            }

            _context.DetalleVenta.Remove(detalleVenta);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
