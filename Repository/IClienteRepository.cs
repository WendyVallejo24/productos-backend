using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Repository
{
    public interface IClienteRepository 
    {
        Task<Clientes> FindByIdAsync(long id);
    }
}
