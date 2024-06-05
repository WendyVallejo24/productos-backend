using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoUsabilidad.Models
{
    [Table("Nota_ventas")]
    public class NotaVentas
    {
        [Key]
        [Column("numero_nota")]
        public int NumeroNota { get; set; }

        [Column("fecha")]
        public DateTime Fecha { get; set; }

        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public Clientes Cliente { get; set; }

        [Column("total")]
        public decimal Total { get; set; }

        [Column("id_detalle_pedido")]
        public int IdDetallePedido { get; set; }
        [ForeignKey("IdDetallePedido")]
        public DetallePedido DetallePedido { get; set; }

        [Column("id_detalle_venta")]
        public int IdDetalleVenta { get; set; }
        [ForeignKey("IdDetalleVenta")]
        public List<DetalleVenta> DetalleVenta { get; set; }
    }
}
