using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Core.Entities
{
    public class Product
    {
        public int Id { get; set; } // Birincil anahtar
        public string Barcode { get; set; } // Barkod
        public decimal CostPrice { get; set; } // Maliyet Fiyatı
        public decimal SalePrice { get; set; } // Satış Fiyatı
        public string Gender { get; set; } // Cinsiyet Açıklama
        public string Season { get; set; } // Sezon Açıklama
        public string Brand { get; set; } // Marka Açıklama
        public string ProductGroup { get; set; } // Ürün Gurubu Açıklama
        public string ProductFeature { get; set; } // Ürün Özellikler Açıklama
        // Relationships
        public Category Category { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
        public ICollection<Stock> Stocks { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
