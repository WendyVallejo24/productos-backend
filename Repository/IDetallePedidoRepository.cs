using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Repository
{
    public interface IDetallePedidoRepository
    {
        Task<DetallePedido> SaveAsync(DetallePedido detallePedido);
        Task<DetallePedido> FindByIdAsync(long id);
    }
}
