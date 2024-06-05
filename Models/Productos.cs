using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoUsabilidad.Models
{
    [Table("Productos")]
    public class Productos
    {
        [Key]
        [Column("codigo")]
        public int Codigo { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("precio")]
        public double Precio {  get; set; }

        [Column("existencia")]
        public int Existencia { get; set; }

        [Column("id_categoria")]
        public int IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public Categorias Categoria { get; set; }

        [Column("id_marca")]
        public int IdMarca { get; set; }
        [ForeignKey("IdMarca")]
        public Marcas Marca { get; set; }

        [Column("id_unidad_med")]
        public int IdUnidadMed { get; set; }
        [ForeignKey("IdUnidadMed")]
        public UnidadMedida UnidadMedida { get; set; }
    }
}
