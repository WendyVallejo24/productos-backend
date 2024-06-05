using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoUsabilidad.Models
{
    [Table("detalle_pedido")]
    public class DetallePedido
    {
        [Key]
        [Column("id_detalle_pedido")]
        public int IdDetallePedido { get; set; }

        [Column("fecha_entrega")]
        public DateTime FechaEntrega { get; set; }

        [Column("id_estado")]
        public int IdEstado { get; set; }

        [ForeignKey("IdEstado")]
        public EstadoPedidos Estado { get; set; }
    }
}
