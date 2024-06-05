using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoUsabilidad.Models
{
    [Table("Unidad_medida")]
    public class UnidadMedida
    {
        [Key]
        [Column("id_unidad_med")]
        public int IdUnidadMed { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }
    }
}
