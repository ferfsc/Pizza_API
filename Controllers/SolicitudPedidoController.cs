using Microsoft.AspNetCore.Mvc;
using Pizza_API.Builder.ProdPizzas;
using Pizza_API.Builder.PromocionesDia;
using Pizza_API.Services.PedidosPizza;
using Pizza_API.Services.Promocion;

namespace Pizza_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SolicitudPedidoController : Controller
    {
        private ISolicitudPedidos _Solicitud;

        public SolicitudPedidoController(ISolicitudPedidos sol)
        {
            _Solicitud = sol;
        }

        [Route("Solicitar Pedido de Pizza Promocion")]
        [HttpPost]
        public IActionResult SolicitarPedido(string cliente, string fecha, Pizza pizzaProducto)
        {
            
            return Ok(_Solicitud.SolicitarPedido(cliente, fecha, pizzaProducto));
        }
    }
}
