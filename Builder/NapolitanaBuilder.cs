namespace API_Pizza.Builder
{
    public class NapolitanaBuilder: PizzaBuilder
    {
        public NapolitanaBuilder(string tamano)
        {
            Pizza = new Pizza { Tamano = tamano };
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
