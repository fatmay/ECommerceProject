using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryId { get; set; }

        // Relationships
        public Category Category { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
        public ICollection<Stock> Stocks { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
