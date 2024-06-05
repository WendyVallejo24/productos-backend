using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoUsabilidad.Models
{
    [Table("Estados_pedidos")]
    public class EstadoPedidos
    {
        [Key]
        [Column("id_estado")]
        public int IdEstado { get; set; }
        [Column("estado")]
        public string Estado { get; set;}

        public virtual ICollection<DetallePedido> DetallePedido { get; set; }
    }
}
