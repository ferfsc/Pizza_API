namespace Pizza_API.Builder
{
    public class Cocina
    {
        private PizzaBuilder _pizzaBuilder;

        public Pizza CocinarPizza(PizzaBuilder pizzaBuilder)
        {
            RecepcionarProximaPizza(pizzaBuilder);
            CocinarPizzaPasoAPaso();
            return PizzaPreparada;
        }

        public Pizza CocinarPizza(PizzaBuilder pizzaBuilder, int cantidad)
        {
            RecepcionarProximaPizza(pizzaBuilder, cantidad);
            CocinarPizzaPasoAPaso();
            return PizzaPreparada;
        }
        public void RecepcionarProximaPizza(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }
        public void RecepcionarProximaPizza(PizzaBuilder pizzaBuilder, int cantidad)
        {
            _pizzaBuilder = pizzaBuilder;
            _pizzaBuilder.cantidad = cantidad;
        }
        public void CocinarPizzaPasoAPaso()
        {
            _pizzaBuilder.PasoPrepararMasa();
            _pizzaBuilder.PasoAdicionarSalsa();
            _pizzaBuilder.PasoPrepararRelleno();
            _pizzaBuilder.PasoDefinirForma();
            _pizzaBuilder.PasoDefinirCantidadPizza();
        }

        public Pizza PizzaPreparada
        {
            get { return _pizzaBuilder.ObtenerPizza(); }

        }

    }
}
