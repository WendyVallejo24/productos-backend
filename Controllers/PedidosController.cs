using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using proyectoUsabilidad.DTO;
using proyectoUsabilidad.Models;
using proyectoUsabilidad.Service;

namespace proyectoUsabilidad.Controllers
{
    [ApiController]
    [Route("api/pedido")]
    [EnableCors("AllowSpecificOrigin")]
    public class PedidosController : ControllerBase
    {
        private readonly PedidoServicio _pedidoServicio;

        public PedidosController(PedidoServicio pedidoServicio)
        {
            _pedidoServicio = pedidoServicio;
        }

        // GET: api/Pedidos/{id}
        [HttpGet]
        public async Task<ActionResult<List<NotaVentas>>> GetPedidos()
        {
            var pedido = await _pedidoServicio.ObtenerPedidosAsync();

            if (pedido == null)
            {
                return NotFound($"No exiten pedidos");
            }

            return pedido;
        }

        [HttpPost]
        public async Task<ActionResult<NotaVentas>> PostPedido(NotaVentas pedido)
        {
            try
            {
                _pedidoServicio.CrearPedidoAsync(pedido);
                return StatusCode(201, "Pedido creado con éxito");
            }
            catch (Exception e)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpPut("{id}/estado")]
        public async Task<IActionResult> ModificarEstadoPedido(DTOEstadoPedido estadoPedido)
        {
            var resultado = await _pedidoServicio.ModificarEstadoPedidoAsync(estadoPedido);
            if (resultado == "Nota de venta no encontrada" || resultado == "Detalle de pedido no encontrado" || resultado == "Estado de pedido no encontrado")
            {
                return NotFound(resultado);
            }
            return Ok(resultado);
        }

        [HttpPost("{id}/entregar")]
        public async Task<IActionResult> EntregarPedido(long id)
        {
            var notaVenta = await _pedidoServicio.ObtenerNotaVentaPorIdAsync(id);
            if (notaVenta == null)
            {
                return NotFound("Nota de venta no encontrada");
            }
            await _pedidoServicio.EntregarPedidoAsync(notaVenta);
            return Ok("Pedido entregado");
        }
    }
}
