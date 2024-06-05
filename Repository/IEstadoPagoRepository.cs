using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Repository
{
    public interface IEstadoPagoRepository
    {
        Task<EstadoPago> FindByIdAsync(long id);
    }
}
