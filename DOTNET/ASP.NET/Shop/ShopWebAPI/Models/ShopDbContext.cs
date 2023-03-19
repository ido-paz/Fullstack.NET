using Microsoft.EntityFrameworkCore;

namespace ShopWebAPI.Models
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Product> Products{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=Shop;Integrated Security=True;trustservercertificate=true");
        }


    }
}
