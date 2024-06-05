using System.ComponentModel.DataAnnotations;

namespace proyectoUsabilidad.DTO
{
    public class DTOEstadoPedido
    {
        public long IdEstadoPedido { get; set; }
        [Required(ErrorMessage = "La nota no puede ser nula")]
        public long nNota { get; set; }

        public DTOEstadoPedido() { }

        public DTOEstadoPedido(long idEstadoPedido, long nNota)
        {
            IdEstadoPedido = idEstadoPedido;
            this.nNota = nNota;
        }
    }
}
