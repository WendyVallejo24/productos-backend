namespace proyectoUsabilidad.DTO
{
    public class ProductoUpdateDto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public double Precio {  get; set; }
        public int Existencia { get; set; }
        public int IdCategoria { get; set; }
        public int IdMarca { get; set; }
        public int IdUnidadMed { get; set; }
    }
}
