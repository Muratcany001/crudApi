using Microsoft.EntityFrameworkCore;
using projeApi.Entities.appEntities;

namespace projeApi.Entities
{
    public class Context : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-KP4MLAD\\MURAT;Database=MarketAppDB;TrustServerCertificate=True;Trusted_Connection=True;");
            }
        }
    }
}
