using System.Runtime;

namespace Pizza_API.Builder.ProdPizzas
{
    public abstract class PizzaBuilder
    {
        // Protected para que las clases que implementen puedan acceder
        protected Pizza Pizza;

        public string nombre { get; set; }
        public string Tamano { get; set; }

        public int cantidad { get; set; }
        public Pizza ObtenerPizza()
        {
            return Pizza;
        }

        public virtual void PasoPrepararMasa()
        {

        }

        public virtual void PasoAdicionarSalsa()
        {

        }

        public virtual void PasoPrepararRelleno()
        {

        }

        public virtual void PasoDoblarPizza()
        {

        }

        public virtual void PasoDefinirForma()
        {

        }
        public virtual void PasoDefinirCantidadPizza()
        {

        }
    }
}
