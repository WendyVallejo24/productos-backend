using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoUsabilidad.Data;
using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Controllers
{
    [Route("api/estadopedido")]
    [ApiController]
    [EnableCors("AllowSpecificOrigin")]
    public class EstadoPedidoController : ControllerBase
    {
        private readonly DataContext _context;

        public EstadoPedidoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoPedidos>>> GetEstadosPedidos()
        {
            return await _context.EstadosPedidos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EstadoPedidos>> GetEstadosPedidos(int id)
        {
            var estadoPedidos = await _context.EstadosPedidos.FindAsync(id);

            if (estadoPedidos == null)
            {
                return NotFound();
            }
            return estadoPedidos;
        }

        [HttpPost]
        public async Task<ActionResult<EstadoPedidos>> PostEstadosPedidos(EstadoPedidos estadoPedidos)
        {
            _context.EstadosPedidos.Add(estadoPedidos);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEstadosPedidos), new { id = estadoPedidos.IdEstado }, estadoPedidos);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstadosPedidos(int id, EstadoPedidos estadoPedidos)
        {
            if (id != estadoPedidos.IdEstado)
            {
                return BadRequest();
            }

            _context.Entry(estadoPedidos).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstadosPedidos(int id)
        {
            var estadosPedidos = await _context.EstadosPedidos.FindAsync(id);
            if (estadosPedidos == null)
            {
                return NotFound();
            }

            _context.EstadosPedidos.Remove(estadosPedidos);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
