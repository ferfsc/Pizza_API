namespace API_Pizza.Builder
{
    public abstract class PizzaBuilder
    {
        // Protected para que las clases que implementen puedan acceder
        protected Pizza Pizza;
        public string Tamano { get; set; }

        public Pizza ObtenerPizza() { 
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
    }
}
