
using Microsoft.EntityFrameworkCore;

namespace Shop_FC_Summery.Models
{
    internal class ShopDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserOrder> UsersOrders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductsOrders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=Shop;Integrated Security=True;trustservercertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasIndex("Login").IsUnique();
            modelBuilder.Entity<Product>().HasIndex(p => p.Name).IsUnique();
            modelBuilder.Entity<ProductOrder>().HasKey(po => new { po.OrderId, po.ProductId });
            modelBuilder.Entity<UserOrder>().HasKey("OrderId");
            modelBuilder.Entity<UserOrder>().Property(uo=> uo.Created).HasColumnType("datetime");
            //
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var users = new User[] 
            {
                new User(){UserId=1,Login="U1"},
                new User(){UserId=2,Login="U2"},
                new User(){UserId=3,Login="U3"},
            };
            var products = new Product[]
            {
                new Product(){ ProductId=1,Name="p1",Price=1},
                new Product(){ ProductId=2,Name="p2",Price=2},
                new Product(){ ProductId=3,Name="p3",Price=3}
            };
            var usersOrders = new UserOrder[]
            {
                new UserOrder(){ OrderId=1,UserId=1,Created=DateTime.Now},
                new UserOrder(){ OrderId=2,UserId=1,Created=DateTime.Now},
                new UserOrder(){ OrderId=3,UserId=1,Created=DateTime.Now},
                new UserOrder(){ OrderId=4,UserId=2,Created=DateTime.Now},
                new UserOrder(){ OrderId=5,UserId=2,Created=DateTime.Now},
            };
            var productsOrders = new ProductOrder[]
            {
                new ProductOrder(){ OrderId =1 ,ProductId=1,Quantity=1},
                new ProductOrder(){ OrderId =1 ,ProductId=2,Quantity=1},
                new ProductOrder(){ OrderId =1 ,ProductId=3,Quantity=1},
                new ProductOrder(){ OrderId =2 ,ProductId=2,Quantity=2},
                new ProductOrder(){ OrderId =3 ,ProductId=1,Quantity=1},
                new ProductOrder(){ OrderId =3 ,ProductId=3,Quantity=1},
            };
            //
            //
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<UserOrder>().HasData(usersOrders);
            modelBuilder.Entity<ProductOrder>().HasData(productsOrders);
        }
    }
}
