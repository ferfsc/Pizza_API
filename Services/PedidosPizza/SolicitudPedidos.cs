using Pizza_API.Builder.Pedidos;
using Pizza_API.Builder.Pedidos.DetallePedidos;
using Pizza_API.Builder.ProdPizzas;
using Pizza_API.Builder.PromocionesDia;

namespace Pizza_API.Services.PedidosPizza
{
    public class SolicitudPedidos : ISolicitudPedidos
    {
        private readonly DataSolicitudPedidos _Solicitud;
        private readonly DataDetallePedidos _detalle;
        private readonly DataPromocion _listaPromos;

        public SolicitudPedidos(DataSolicitudPedidos solPedido, DataDetallePedidos detalle, DataPromocion listaPromos)
        {
            _Solicitud = solPedido;
            _detalle = detalle;
            _listaPromos = listaPromos;
        }
        public void SolicitarPedido(string cliente, DateTime fecha, List<Pizza> ListaPizza)
        {
            throw new NotImplementedException();
        }

        public string SolicitarPedido(string cliente, string fecha, Pizza pizzaProducto)
        {

            //var hayPromo = _Solicitud.SolicitudPedido.FirstOrDefault(x => x.IdPedido == promo.ID);
            //if (hayPromo != null)
            //{
            //    throw new ArgumentException("La Promo ya existe");
            //}
            int Codigo = new Random().Next(1, 10000);
            string[] partFecha = fecha.Split('/');
            //throw new NotImplementedException();
            SolicitudPedido oPedido = new SolicitudPedido();
            oPedido.IdPedido = Codigo;
            oPedido.NombreCliente = cliente;

            oPedido.fecha = new DateTime(Convert.ToInt32(partFecha[2]), Convert.ToInt32(partFecha[1]), Convert.ToInt32(partFecha[0]));// Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

            _Solicitud.AddSolicitudPedido(oPedido);

            int IdDetalle = new Random().Next(1, 10000);
            DetallePedido oDetalle = new DetallePedido();
            oDetalle.idDetalle = IdDetalle;
            oDetalle.idPedido = oPedido.IdPedido;
            oDetalle.PedidoPizza = pizzaProducto;
            oDetalle.Cantidad = pizzaProducto.Cantidad;
            oDetalle.precio = 30;
            oDetalle.preciototal = oDetalle.Cantidad * oDetalle.precio;

            _detalle.AddDetallePedido(oDetalle);
            int diaSemana = (int)oPedido.fecha.DayOfWeek;

            var existePromo = _listaPromos.promo_dia(diaSemana);

            decimal CantidadTotal = 0;
            (_detalle.DetallePedido.Where(x => x.idPedido == Codigo).ToList()).ForEach(x => CantidadTotal += x.Cantidad);


            decimal precioTotal = 0;
            (_detalle.DetallePedido.Where(x => x.idPedido == Codigo).ToList()).ForEach(x => precioTotal += x.preciototal);


            precioTotal = (precioTotal * (existePromo.descuento / 100));

            string retorno =
                  "REPORTE DE PEDIDO" +
                  "\nCliente: " + oPedido.NombreCliente +
                  "\nPrecio: " + oDetalle.precio +
                  "\nCantidad: " + CantidadTotal +
                  "\n--------------------" +
                  "\nDETALLE" +
                  "\nPizza: " + pizzaProducto.Nombre +
                  "\nCantidad: " + oDetalle.Cantidad +
                  "\nPrecioUnitario: " + oDetalle.precio +
                  "\nPrecioTotal: " + precioTotal +
                  "\n--------------------" +
                  "\nPROMOCION" +
                  "\nNombre: " + existePromo.Nombre +
                  "\nDescuento: " + existePromo.descuento + " %";
                   

               return retorno;


        }
    }
}
