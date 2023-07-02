namespace API_Pizza.Builder
{
    public class CuatroQuesosBuilder: PizzaBuilder
    {
        public CuatroQuesosBuilder(string tamano)
        {
            Pizza = new Pizza
            {
                Tamano = tamano
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
    }
}
