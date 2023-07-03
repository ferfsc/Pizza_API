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
            promo.diasPromo = "2,3";
            promo.TipoID = 1; // al total de las pizzas

            _promociones.Add(promo);

            promo = new Promociones();
            promo.ID = 2;
            promo.Nombre = "Delivery Gratis solo Jueves";
            promo.descuento = 100;
            promo.diasPromo = "4";
            promo.TipoID = 2; // solo delivery

            _promociones.Add(promo);
        }


        public void AddPromocion(Promociones promocion)
        {
            _promociones.Add(promocion);
        }

        public Promociones promo_dia(int dia)
        {
            foreach (var item in _promociones)
            {
                var dias = item.diasPromo.Split(',');
                foreach (var item2 in dias)
                {
                    if (Convert.ToInt32(item2) == dia)
                        return item;
                }
            }
            return null;
        }
    }
}
