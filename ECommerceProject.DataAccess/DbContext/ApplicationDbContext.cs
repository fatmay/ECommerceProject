using Microsoft.EntityFrameworkCore;
using ECommerceProject.Core.Entities;
using ECommerceProject.ECommerceProject.Core.Entities;

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
            modelBuilder.Entity<Product>().Property(p => p.GenderDescription).HasColumnName("Cinsiyet Açıklama");
            modelBuilder.Entity<Product>().Property(p => p.ColorCode).HasColumnName("Renk Kodu");
            modelBuilder.Entity<Product>().Property(p => p.ColorDescription).HasColumnName("Renk Açıklama");
            modelBuilder.Entity<Product>().Property(p => p.Gender).HasColumnName("Cinsiyet");
            modelBuilder.Entity<Season>().Property(p => p.SeasonName).HasColumnName("Sezon");
            modelBuilder.Entity<Season>().Property(p => p.SeasonDescription).HasColumnName("Sezon Açıklama");

            modelBuilder.Entity<Product>().Property(p => p.BrandDescription).HasColumnName("Marka Açıklama");
            modelBuilder.Entity<Product>().Property(p => p.BrandCode).HasColumnName("Marka");
            modelBuilder.Entity<Product>().Property(p => p.ProductName).HasColumnName("Ürün Adı");
            modelBuilder.Entity<Product>().Property(p => p.ProductCode).HasColumnName("Ürün Kodu");
            modelBuilder.Entity<Product>().Property(p => p.ProductGroup).HasColumnName("Ürün Gurubu");
            modelBuilder.Entity<Product>().Property(p => p.ProductGroupDescription).HasColumnName("Ürün Gurubu Açıklama");
            modelBuilder.Entity<Product>().Property(p => p.ProductFeature).HasColumnName("Ürün Özellikler");
            modelBuilder.Entity<Product>().Property(p => p.ProductFeatureDescription).HasColumnName("Ürün Özellikler Açıklama");
            modelBuilder.Entity<Product>().Property(p => p.Size).HasColumnName("Beden");
            modelBuilder.Entity<Product>().Property(p => p.Inventory).HasColumnName("Envanter");
            modelBuilder.Entity<Product>().Property(p => p.Kavala).HasColumnName("Kavala");



            // Store
            modelBuilder.Entity<Store>().ToTable("Stores");
            modelBuilder.Entity<Store>().Property(s => s.StoreCode).HasColumnName("Mağaza Kodu");
            modelBuilder.Entity<Store>().Property(s => s.StoreName).HasColumnName("Mağaza Adı");

            // Warehouse
            modelBuilder.Entity<Warehouse>().ToTable("Warehouses");
            modelBuilder.Entity<Warehouse>().Property(w => w.WarehouseCode).HasColumnName("Depo Kodu");
            modelBuilder.Entity<Warehouse>().Property(w => w.WarehouseName).HasColumnName("Depo Adı");

            //Stock
            // modelBuilder.Entity<Stock>().Property(w => w.Id).HasColumnName("Stok Durumu");



        }
    }
}
