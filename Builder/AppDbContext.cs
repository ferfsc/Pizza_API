using Microsoft.EntityFrameworkCore;
using Pizza_API.Builder.PromocionesDia;

namespace Pizza_API.Builder
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=PedidosPizza.sqlite");
        }

        public DbSet<Promociones> Promociones { get; set; }
    }
}
