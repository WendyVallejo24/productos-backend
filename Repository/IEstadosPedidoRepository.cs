using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Repository
{
    public interface IEstadosPedidoRepository
    {
        Task<EstadoPedidos> FindByIdAsync(long id);
    }
}
