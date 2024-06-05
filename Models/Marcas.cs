using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoUsabilidad.Models
{
    [Table("Marcas")]
    public class Marcas
    {
        [Key]
        [Column("id_marca")]
        public int IdMarca { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }
    }
}
