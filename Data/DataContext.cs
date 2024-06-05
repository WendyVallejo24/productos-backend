using Microsoft.EntityFrameworkCore;
using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<EstadoPago> EstadoPago { get; set; }
        public DbSet<EstadoPedidos> EstadosPedidos { get; set; }
        public DbSet<DetallePedido> DetallePedido { get; set; }
        public DbSet<NotaVentas> NotaVentas { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Marcas> Marcas { get; set; }
        public DbSet<UnidadMedida> UnidadMedida { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<DetalleVenta> DetalleVenta { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
    }
}
