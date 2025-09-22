using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt1
{
    public class Product
    {
        private static int counter = 1;

        public int Code { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool InStock => Quantity > 0;
        public ProductCategory Category { get; set; }

        public Product(string name, decimal price, int quantity, ProductCategory category)
        {
            Code = counter++;
            Name = name;
            Price = price;
            Quantity = quantity;
            Category = category;
        }

        public void Sell(int amount)
        {
            if (Quantity >= amount)
                Quantity -= amount;
            else
                throw new InvalidOperationException("Недостаточно товара на складе!");
        }

        public void Restock(int amount)
        {
            Quantity += amount;
        }
    }
}
