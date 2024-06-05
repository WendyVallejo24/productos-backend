using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Repository
{
    public interface IDetalleVentaRepository
    {
        Task SaveAsync(DetalleVenta detalleVenta);
    }
}
