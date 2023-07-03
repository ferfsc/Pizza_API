using Pizza_API.Builder.ProdPizzas;
using System.ComponentModel.DataAnnotations;

namespace Pizza_API.Builder.Pedidos.DetallePedidos
{
    public class DetallePedido
    {
        [Key]
        public int idDetalle { get; set; }
        public int idPedido { get; set; }
        //public List<Pizza> Detalle { get; set; }
        public Pizza PedidoPizza { get; set; }

        public int Cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal preciototal { get; set; }

    }
}
