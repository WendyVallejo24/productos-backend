using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proyectoUsabilidad.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        [Key]
        [Column("id_cliente")]
        public int IdCliente { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("apellidos")]
        public string Apellidos { get; set; }

        [Column("telefono")]
        public string Telefono { get; set; }

        [Column("direccion")]
        public string Direccion { get; set; }
    }
}
