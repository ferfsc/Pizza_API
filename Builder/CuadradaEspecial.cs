using API_Pizza.Builder;

namespace Pizza_API.Builder
{
    public class CuadradaEspecial: PizzaBuilder
    {
        public CuadradaEspecial(string tamano)
        {
            Pizza = new Pizza
            {
                Tamano = tamano
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
    }
}
