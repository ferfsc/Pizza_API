namespace Pizza_API.Builder.Pedidos.DetallePedidos
{
    public class DataDetallePedidos
    {
        public readonly List<DetallePedido> _detalle;

        public IEnumerable<DetallePedido> DetallePedido => _detalle;

        public DataDetallePedidos()
        {
            _detalle = new List<DetallePedido>();
        }

        public void AddDetallePedido(DetallePedido solicitud)
        {
            _detalle.Add(solicitud);
        }

       
    }
}
