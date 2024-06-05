using proyectoUsabilidad.DTO;
using proyectoUsabilidad.Models;
using proyectoUsabilidad.Repository;

namespace proyectoUsabilidad.Service
{
    public class PedidoServicio
    {
        private readonly INotaVentaRepository _notaVentaRepository;
        private readonly IEstadoPagoRepository _estadoPagoRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IDetallePedidoRepository _detallePedidoRepository;
        private readonly IDetalleVentaRepository _detalleVentaRepository;
        private readonly IProductoRepository _productoRepository;
        private readonly IEstadosPedidoRepository _estadosPedidoRepository;

        private readonly DateTime _fecha = DateTime.Now;

        public PedidoServicio(
        INotaVentaRepository notaVentaRepository,
        IEstadoPagoRepository estadoPagoRepository,
        IClienteRepository clienteRepository,
        IDetallePedidoRepository detallePedidoRepository,
        IDetalleVentaRepository detalleVentaRepository,
        IProductoRepository productoRepository,
        IEstadosPedidoRepository estadosPedidoRepository)
        {
            _notaVentaRepository = notaVentaRepository;
            _estadoPagoRepository = estadoPagoRepository;
            _clienteRepository = clienteRepository;
            _detallePedidoRepository = detallePedidoRepository;
            _detalleVentaRepository = detalleVentaRepository;
            _productoRepository = productoRepository;
            _estadosPedidoRepository = estadosPedidoRepository;
        }

        public async Task<long> ObtenerUltimoNumeroNotaAsync()
        {
            var ultimoNumeroNota = await _notaVentaRepository.FindMaxNumeroNotaAsync();
            return ultimoNumeroNota ?? 0L;
        }

        public async Task<NotaVentas> ObtenerNotaVentaPorIdAsync(long id)
        {
            return await _notaVentaRepository.FindByIdAsync(id);
        }

        public async Task<NotaVentas> CrearPedidoAsync(NotaVentas pedido)
        {
            var detallePedido = await CrearDetallePedidoAsync(pedido);
            var notaVenta = await CrearNotaVentaAsync(pedido, detallePedido);
            await CrearDetalleVentaAsync(pedido, notaVenta);

            return notaVenta;
        }

        private async Task<DetallePedido> CrearDetallePedidoAsync(NotaVentas nota)
        {
            var nuevoDetallePedido = new DetallePedido
            {
                FechaEntrega = nota.DetallePedido.FechaEntrega,
                Estado = await _estadosPedidoRepository.FindByIdAsync(2L)
            };

            return await _detallePedidoRepository.SaveAsync(nuevoDetallePedido);
        }

        private async Task<NotaVentas> CrearNotaVentaAsync(NotaVentas notaVenta, DetallePedido detallePedido)
        {
            var nuevaNotaVenta = new NotaVentas
            {
                Fecha = _fecha,
                Total = notaVenta.Total,
                Cliente = await _clienteRepository.FindByIdAsync(notaVenta.Cliente.IdCliente),
                DetallePedido = await CrearDetallePedidoAsync(notaVenta)
            };

            return await _notaVentaRepository.SaveAsync(nuevaNotaVenta);
        }

        private async Task CrearDetalleVentaAsync(NotaVentas pedido, NotaVentas notaVenta)
        {
            foreach (var detalle in pedido.DetalleVenta)
            {
                var producto = await _productoRepository.FindByIdAsync(detalle.Producto.Codigo);
                var detalleVenta = new DetalleVenta
                {
                    Cantidad = detalle.Cantidad,
                    Subtotal = detalle.Subtotal,
                    Fecha = _fecha,
                    Producto = producto,
                    NotaVenta = notaVenta
                };

                await _detalleVentaRepository.SaveAsync(detalleVenta);

                producto.Existencia -= detalle.Cantidad;
                await _productoRepository.SaveAsync(producto);
            }
        }

        public async Task<string> ModificarEstadoPedidoAsync(DTOEstadoPedido estadoPedido)
        {
            var notaVenta = await _notaVentaRepository.FindByIdAsync(estadoPedido.nNota);
            if (notaVenta == null) return "Nota de venta no encontrada";

            if (notaVenta.DetallePedido.Estado.IdEstado == 3L)
            {
                return "El pedido ya está cancelado";
            }

            if (estadoPedido.IdEstadoPedido == 3L)
            {
                await CancelarPedidoAsync(notaVenta);
                return "Pedido cancelado";
            }

            var detallePedido = await _detallePedidoRepository.FindByIdAsync(notaVenta.DetallePedido.IdDetallePedido);
            if (detallePedido == null) return "Detalle de pedido no encontrado";

            var estado = await _estadosPedidoRepository.FindByIdAsync(estadoPedido.IdEstadoPedido);
            if (estado == null) return "Estado de pedido no encontrado";

            detallePedido.Estado = estado;
            await _detallePedidoRepository.SaveAsync(detallePedido);

            return "Estado de pedido modificado";
        }

        private async Task CancelarPedidoAsync(NotaVentas notaVenta)
        {
            var detallePedido = await _detallePedidoRepository.FindByIdAsync(notaVenta.DetallePedido.IdDetallePedido);
            if (detallePedido == null) throw new KeyNotFoundException("Detalle de pedido no encontrado");

            detallePedido.Estado = await _estadosPedidoRepository.FindByIdAsync(3L);
            await _detallePedidoRepository.SaveAsync(detallePedido);

            foreach (var detalleVenta in notaVenta.DetalleVenta)
            {
                var producto = await _productoRepository.FindByIdAsync(detalleVenta.Producto.Codigo);
                if (producto == null) throw new KeyNotFoundException("Producto no encontrado");

                producto.Existencia += detalleVenta.Cantidad;
                await _productoRepository.SaveAsync(producto);
            }
        }

        public async Task EntregarPedidoAsync(NotaVentas notaVenta)
        {
            var detallePedido = await _detallePedidoRepository.FindByIdAsync(notaVenta.DetallePedido.IdDetallePedido);
            if (detallePedido == null) throw new KeyNotFoundException("Detalle de pedido no encontrado");

            detallePedido.Estado = await _estadosPedidoRepository.FindByIdAsync(1L);
            await _detallePedidoRepository.SaveAsync(detallePedido);
        }

        public async Task<List<NotaVentas>> ObtenerPedidosAsync()
        {
            return await _notaVentaRepository.GetAllAsync();
        }
    }
}
