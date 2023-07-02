using Microsoft.AspNetCore.Mvc;
using Pizza_API.Builder;
using Pizza_API.Services.Cocina;

namespace Pizza_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoCocinaController : Controller
    {
        private IPedidoCocina _pedido;
        public PedidoCocinaController(IPedidoCocina pedido_cocina) {
            _pedido = pedido_cocina;
        }

        [Route("Pedido Pizza")]
        [HttpPost]
        public IActionResult Pedido(int cantidad)
        {
            Pizza sol_pizza = _pedido.SolicitarPizza(cantidad);
            return Ok(new { sol_pizza.Tamano, sol_pizza.Masa, sol_pizza.Salsa, sol_pizza.Forma, sol_pizza.Cantidad });

        }

        [Route("Crear Pedido Pizza")]
        [HttpPost]
        public IActionResult CrearPizza(Pizza datos)
        {
            return Ok();
        }
    }
}
