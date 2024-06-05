using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Repository
{
    public interface INotaVentaRepository
    {
        Task<long?> FindMaxNumeroNotaAsync();
        Task<NotaVentas> FindByIdAsync(long id);
        Task<NotaVentas> SaveAsync(NotaVentas notaVenta);
        Task<List<NotaVentas>> GetAllAsync();
    }
}
