namespace Pizza_API.Builder.ProdPizzas
{
    public class NapolitanaBuilder : PizzaBuilder
    {
        public NapolitanaBuilder(string tamano)
        {
            Pizza = new Pizza { Tamano = tamano };
        }
        public NapolitanaBuilder(string tamano, int cantidad)
        {
            Pizza = new Pizza
            {
                Nombre = "Napolitana",
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
            Pizza.Salsa = "Tomate";
        }

        public override void PasoPrepararRelleno()
        {
            Pizza.Relleno = "mozzarela+aceite de oliva+parmesano";
        }

        public override void PasoDefinirForma()
        {
            Pizza.Forma = "Redonda";
        }

    }
}
