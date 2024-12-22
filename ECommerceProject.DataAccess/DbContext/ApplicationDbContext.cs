using Microsoft.EntityFrameworkCore;
using ECommerceProject.Core.Entities;

namespace ECommerceProject.DataAccess.DbContext
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Tablolar
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Product
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().Property(p => p.Barcode).HasColumnName("Barkod");
            modelBuilder.Entity<Product>().Property(p => p.CostPrice).HasColumnName("Maliyet Fiyatı");
            modelBuilder.Entity<Product>().Property(p => p.SalePrice).HasColumnName("Satış Fiyatı");
            modelBuilder.Entity<Product>().Property(p => p.Gender).HasColumnName("Cinsiyet Açıklama");
            modelBuilder.Entity<Product>().Property(p => p.Season).HasColumnName("Sezon Açıklama");
            modelBuilder.Entity<Product>().Property(p => p.Brand).HasColumnName("Marka Açıklama");
            modelBuilder.Entity<Product>().Property(p => p.ProductGroup).HasColumnName("Ürün Gurubu Açıklama");
            modelBuilder.Entity<Product>().Property(p => p.ProductFeature).HasColumnName("Ürün Özellikler Açıklama");

            // Store
            modelBuilder.Entity<Store>().ToTable("Stores");
            modelBuilder.Entity<Store>().Property(s => s.StoreCode).HasColumnName("Mağaza Kodu");
            modelBuilder.Entity<Store>().Property(s => s.StoreName).HasColumnName("Mağaza Adı");

            // Warehouse
            modelBuilder.Entity<Warehouse>().ToTable("Warehouses");
            modelBuilder.Entity<Warehouse>().Property(w => w.WarehouseCode).HasColumnName("Depo Kodu");
            modelBuilder.Entity<Warehouse>().Property(w => w.WarehouseName).HasColumnName("Depo Adı");
        }
    }
}
