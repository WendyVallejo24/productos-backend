using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoUsabilidad.Models
{
    [Table("Detalle_venta")]
    public class DetalleVenta
    {
        [Key]
        [Column("id_detalle")]
        public int IdDetalle { get; set; }

        [Column("cantidad")]
        public int Cantidad { get; set; }

        [Column("subtotal")]
        public decimal Subtotal { get; set; }

        [Column("fecha")]
        public DateTime Fecha { get; set; }

        [Column("codigo")]
        public int Codigo { get; set; }
        [ForeignKey("Codigo")]
        public Productos Producto { get; set; }

        [Column("numero_nota")]
        public int NumeroNota { get; set; }
        [ForeignKey("NumeroNota")]
        public NotaVentas NotaVenta { get; set; }
    }
}
