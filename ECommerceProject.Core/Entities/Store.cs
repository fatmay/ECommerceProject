using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Core.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Owner { get; set; }

        // Relationships
        public ICollection<Product> Products { get; set; }
    }
}
