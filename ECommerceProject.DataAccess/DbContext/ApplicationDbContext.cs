using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using ECommerceProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace ECommerceProject.DataAccess.DbContext
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Tablolar
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Discount> Discounts { get; set; }
    };

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // "Products" tablosunun ismini veritabanındaki "tblProducts" ile eşleştir
            modelBuilder.Entity<Product>().ToTable("tblProducts");

            // Sütun isimlerini eşleştir (örnek: "Name" yerine "ProductName" kullanılmışsa)
            modelBuilder.Entity<Product>().Property(p => p.Name).HasColumnName("ProductName");
            modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnName("ProductPrice");
        }



    }
}