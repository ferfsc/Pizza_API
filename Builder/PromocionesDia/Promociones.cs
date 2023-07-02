using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Pizza_API.Builder.PromocionesDia
{
    public class Promociones
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal descuento { get; set; }
        public string diasPromo { get; set; }

        public int TipoID { get; set; } // 1 aplica al total, 2 aplica al delivery

    }
}
