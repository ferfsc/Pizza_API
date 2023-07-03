using Pizza_API.Builder.PromocionesDia;

namespace Pizza_API.Builder.Pedidos
{
    public class DataSolicitudPedidos
    {
        public readonly List<SolicitudPedido> _solicitudes;

        public IEnumerable<SolicitudPedido> SolicitudPedido => _solicitudes;

        public DataSolicitudPedidos()
        {
            _solicitudes = new List<SolicitudPedido>();
        }

        public void AddSolicitudPedido(SolicitudPedido solicitud)
        {
            _solicitudes.Add(solicitud);
        }

    }
}
