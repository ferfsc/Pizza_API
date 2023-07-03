using Microsoft.AspNetCore.Mvc;
using Pizza_API.Builder.PromocionesDia;
using Pizza_API.Services.Cocina;
using Pizza_API.Services.Promocion;

namespace Pizza_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AplicaPromocionController : Controller
    {
        private IAplicaPromocion _promo;

        public AplicaPromocionController(IAplicaPromocion promo)
        {
            _promo = promo;
        }


        [Route("Adicinar Promocion")]
        [HttpPost]
        public IActionResult CrearPromocion(Promociones p)
        {
            _promo.RegistrarPromo(p);
            return Ok();
        }
    }
}
