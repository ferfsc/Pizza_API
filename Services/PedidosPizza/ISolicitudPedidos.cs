using Pizza_API.Builder.ProdPizzas;

namespace Pizza_API.Services.PedidosPizza
{
    public interface ISolicitudPedidos
    {
        void SolicitarPedido(string cliente, DateTime fecha, List<Pizza> ListaPizza);

        string SolicitarPedido(string cliente, string fecha, Pizza pizzaProducto);


    }
}
