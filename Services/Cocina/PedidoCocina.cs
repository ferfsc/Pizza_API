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

        public Pizza CrearPizza(Pizza datos, string nombre, int cantidad)
        {
            var cocina = new Builder.Cocina();
            var _pizza = new CrearPizza(datos.Tamano, datos.Masa, datos.Salsa, datos.Relleno, datos.Forma, datos.Cantidad);
            
            cocina.RecepcionarProximaPizza(_pizza);
            cocina.CocinarPizzaPasoAPaso();
           
            return cocina.PizzaPreparada;
        }
    }
}
