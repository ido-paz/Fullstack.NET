using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ShopDAL;

public partial class ShopDbContext : DbContext
{
    public ShopDbContext()
    {
    }

    public ShopDbContext(DbContextOptions<ShopDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Password).HasDefaultValueSql("(N'')");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.RoleID).HasDefaultValue(1).IsRequired();
        });

        modelBuilder.Entity<Product>().HasData(new Product[]
        {
            new Product { Id = 1, Name = "p1", Price = 10 },
            new Product { Id = 2, Name = "p2", Price = 20 },
            new Product { Id = 3, Name = "p3", Price = 30 },
            new Product { Id = 4, Name = "p4", Price = 40 },
            new Product { Id = 5, Name = "p5", Price = 50 }
        });

        modelBuilder.Entity<User>().HasData(new User[]
        {
            //password=1111
            new User { UserId = 1, UserName = "admin", Password = "AQAAAAEAACcQAAAAEF0yg+txDUNebuNSw+ieaIC/H0Xeu+MUqB/doLTDmBR59cwAl+QwMkMftjY2SMh7ww==", RoleID = 1 },
            new User { UserId =11, UserName = "u1", Password = "AQAAAAEAACcQAAAAEF0yg+txDUNebuNSw+ieaIC/H0Xeu+MUqB/doLTDmBR59cwAl+QwMkMftjY2SMh7ww==", RoleID = 2},
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
