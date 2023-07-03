namespace Pizza_API.Builder.ProdPizzas
{
    public class CuadradaEspecial : PizzaBuilder
    {
        public CuadradaEspecial(string tamano)
        {
            Pizza = new Pizza
            {
                Tamano = tamano
            };
        }

        public CuadradaEspecial(string tamano, int cantidad)
        {
            Pizza = new Pizza
            {
                Nombre = "Cuadrada",
                Tamano = tamano,
                Cantidad = cantidad
            };
        }

        public override void PasoPrepararMasa()
        {
            Pizza.Masa = "Super Cocida";
        }

        public override void PasoAdicionarSalsa()
        {
            Pizza.Salsa = "Sala de Tomate";
        }

        public override void PasoPrepararRelleno()
        {
            Pizza.Relleno = "mozzarela+gorgonzola+parmesano+ricotta+chorizo";
        }
        public override void PasoDefinirForma()
        {
            Pizza.Forma = "Redonda";
        }

        public override void PasoDefinirCantidadPizza()
        {
            //Pizza.Cantidad = cantidad;
        }
    }
}
