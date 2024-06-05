using Microsoft.AspNetCore.Mvc;
using proyectoUsabilidad.Models;
using proyectoUsabilidad.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;

namespace proyectoUsabilidad.Controllers
{
    [Route("api/estadopago")]
    [ApiController]
    [EnableCors("AllowSpecificOrigin")]
    public class EstadoPagoController : ControllerBase
    {
        private readonly DataContext _context;

        public EstadoPagoController(DataContext context)
        {
            _context = context;
        }

        // GET: api/estadopago
        [HttpGet]
        public ActionResult<IEnumerable<EstadoPago>> GetEstadoPagoList()
        {
            return _context.EstadoPago.ToList();
        }

        // GET: api/estadopago/5
        [HttpGet("{id}")]
        public ActionResult<EstadoPago> GetEstadoPagoDetails(int id)
        {
            var estadoPago = _context.EstadoPago.Find(id);

            if (estadoPago == null)
            {
                return NotFound();
            }

            return estadoPago;
        }

        // POST: api/estadopago
        [HttpPost]
        public ActionResult<EstadoPago> PostEstadoPago(EstadoPago estadoPago)
        {
            _context.EstadoPago.Add(estadoPago);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetEstadoPagoDetails), new { id = estadoPago.IdEstadoPago }, estadoPago);
        }

        // PUT: api/estadopago/5
        [HttpPut("{id}")]
        public IActionResult PutEstadoPago(int id, EstadoPago estadoPago)
        {
            if (id != estadoPago.IdEstadoPago)
            {
                return BadRequest();
            }

            _context.Entry(estadoPago).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException)
            {
                if (!_context.EstadoPago.Any(e => e.IdEstadoPago == id))
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

        // DELETE: api/estadopago/5
        [HttpDelete("{id}")]
        public IActionResult DeleteEstadoPago(int id)
        {
            var estadoPago = _context.EstadoPago.Find(id);
            if (estadoPago == null)
            {
                return NotFound();
            }

            _context.EstadoPago.Remove(estadoPago);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
