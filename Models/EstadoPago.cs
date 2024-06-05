using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoUsabilidad.Models
{
    [Table("Estado_pago")]
    public class EstadoPago
    {
        [Key]
        [Column("id_estado_pago")]
        public int IdEstadoPago { get; set; }
        [Column("estado")]
        public string estado {  get; set; }

    }
}
