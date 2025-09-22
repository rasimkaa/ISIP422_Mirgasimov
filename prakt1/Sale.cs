using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt1
{
    public class Sale
    {
        public Product Product { get; }
        public int Quantity { get; }
        public decimal Total => Product.Price * Quantity;

        public Sale(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
