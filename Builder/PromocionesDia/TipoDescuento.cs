using System.ComponentModel.DataAnnotations;

namespace Pizza_API.Builder.PromocionesDia
{
    public class TipoDescuento
    {
        [Key]
        public int id { get; set; }
        public string descripcion { get; set; }
    }
}
