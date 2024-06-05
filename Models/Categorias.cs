using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoUsabilidad.Models
{
    [Table("Categorias")]
    public class Categorias
    {
        [Key]
        [Column("id_categoria")]
        public int IdCategoria { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
    }
}
