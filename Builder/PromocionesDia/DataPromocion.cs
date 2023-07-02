namespace Pizza_API.Builder.PromocionesDia
{
    public class DataPromocion
    {
        public readonly List<Promociones> _promociones;

        public IEnumerable<Promociones> Promociones => _promociones;

        public DataPromocion()
        {

            _promociones = new List<Promociones>();

            CargarPromo();

        }

        public void CargarPromo()
        {
            Promociones promo = new Promociones();
            promo.ID = 1;
            promo.Nombre = "2x1 Martes, Miercoles";
            promo.descuento = 50;
            promo.diasPromo = "3,4";
            promo.TipoID = 1;

            _promociones.Add(promo);
        }


        public void AddPromocion(Promociones promocion)
        {
            _promociones.Add(promocion);
        }
    }
}
