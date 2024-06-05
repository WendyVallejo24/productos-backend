using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Repository
{
    public interface IProductoRepository
    {
        Task<Productos> FindByIdAsync(long codigo);
        Task SaveAsync(Productos producto);
    }
}
