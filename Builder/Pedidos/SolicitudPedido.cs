using System.ComponentModel.DataAnnotations;

namespace Pizza_API.Builder.Pedidos
{
    public class SolicitudPedido
    {
        [Key]
        public int IdPedido { get; set; }   
        public string NombreCliente { get; set; }
        public DateTime fecha { get; set; }= DateTime.Now;

    }
}
