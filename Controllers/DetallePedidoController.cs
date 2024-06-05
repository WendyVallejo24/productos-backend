using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoUsabilidad.Data;
using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Controllers
{
    [Route("api/detallepedido")]
    [ApiController]
    [EnableCors("AllowSpecificOrigin")]
    public class DetallePedidoController : ControllerBase
    {
        private readonly DataContext _context;

        public DetallePedidoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetallePedido>>> GetDetallePedido()
        {
            return await _context.DetallePedido
                .Include(dp => dp.Estado)
                .ToListAsync();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DetallePedido>> GetDetallePedido(int id)
        {
            var detallePedido = await _context.DetallePedido.FindAsync(id);

            if (detallePedido == null)
            {
                return NotFound();
            }

            return detallePedido;
        }

        [HttpPost]
        public async Task<ActionResult<DetallePedido>> PostDetallePedido(DetallePedido detallePedido)
        {
            _context.DetallePedido.Add(detallePedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDetallePedido), new { id = detallePedido.IdDetallePedido }, detallePedido);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetallePedido(int id, DetallePedido detallePedido)
        {
            if (id != detallePedido.IdDetallePedido)
            {
                return BadRequest();
            }

            _context.Entry(detallePedido).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetallePedido(int id)
        {
            var detallePedido = await _context.DetallePedido.FindAsync(id);
            if (detallePedido == null)
            {
                return NotFound();
            }

            _context.DetallePedido.Remove(detallePedido);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
