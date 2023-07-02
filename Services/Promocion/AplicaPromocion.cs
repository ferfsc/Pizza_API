using Pizza_API.Builder.PromocionesDia;

namespace Pizza_API.Services.Promocion
{
    public class AplicaPromocion : IAplicaPromocion
    {
        private readonly DataPromocion _dataPromo;

        public AplicaPromocion(DataPromocion datospromo)
        {
            _dataPromo = datospromo;
        }

        public void RegistrarPromo(Promociones promo)
        {
            var hayPromo = _dataPromo.Promociones.FirstOrDefault(x => x.ID == promo.ID);
            if (hayPromo != null)
            {
                throw new ArgumentException("La Promo ya existe");
            }

            _dataPromo.AddPromocion(promo);

        }        
    }
}
