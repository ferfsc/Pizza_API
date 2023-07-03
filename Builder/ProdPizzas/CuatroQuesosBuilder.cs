namespace Pizza_API.Builder.ProdPizzas
{
    public class CuatroQuesosBuilder : PizzaBuilder
    {
        public CuatroQuesosBuilder(string tamano)
        {
            Pizza = new Pizza
            {
                Nombre = "Cuatro Quesos",
                Tamano = tamano
            };
        }

        public CuatroQuesosBuilder(string tamano, int cantidad)
        {
            Pizza = new Pizza
            {
                Tamano = tamano,
                Cantidad = cantidad
            };
        }

        public override void PasoPrepararMasa()
        {
            Pizza.Masa = "Cocido";
        }

        public override void PasoAdicionarSalsa()
        {
            Pizza.Salsa = "Roquefort";
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

        }
    }
}
