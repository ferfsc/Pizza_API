using System.Runtime.Intrinsics.X86;

namespace Pizza_API.Builder
{
    public class CrearPizza : PizzaBuilder
    {

        public CrearPizza(string tamano)
        {
            Pizza = new Pizza
            {
                Tamano = tamano
            };
        }

        public CrearPizza(string tamano, string masa, string salsa, string relleno, string forma, int cantidad)
        {
            Pizza = new Pizza
            {
                Tamano = tamano,
                Masa = masa,
                Salsa = salsa,
                Relleno = relleno,
                Forma = forma,
                Cantidad = cantidad
            };
        }
       

        public override void PasoPrepararMasa()
        {
            
        }

        public override void PasoAdicionarSalsa()
        {
            
        }

        public override void PasoPrepararRelleno()
        {
            
        }
        public override void PasoDefinirForma()
        {
           
        }

        public override void PasoDefinirCantidadPizza()
        {
            
        }
    }
}
