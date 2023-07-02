using System.ComponentModel.DataAnnotations;

namespace Pizza_API.Builder.Pedidos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string NombrePedido { get; set; }
        public decimal importe { get; set; }        
        public int Disponible { get; set; }

    }
}
