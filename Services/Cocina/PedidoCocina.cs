using Pizza_API.Builder;

namespace Pizza_API.Services.Cocina
{
    public class PedidoCocina : IPedidoCocina
    {
        public List<Pizza> VerMenu()
        {
            throw new NotImplementedException();
        }

        public Pizza SolicitarPizza(int cantidad)
        {
            var cocina = new Builder.Cocina();

            cocina.RecepcionarProximaPizza(new CuatroQuesosBuilder("Familiar",cantidad ));
            cocina.CocinarPizzaPasoAPaso();
            var pizzaCuatroQuesos = cocina.PizzaPreparada;

            return cocina.PizzaPreparada;
        }
    }
}
