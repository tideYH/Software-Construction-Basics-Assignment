using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    public class OrderDetails
    {
        public Product Product { get; set; }

        public int Quantity {  get; set; }

        public OrderDetails(Product product,int quantity) {
            Product = product;
            Quantity = quantity;
        }

        public double Amount => Product.Price*Quantity;

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   EqualityComparer<Product>.Default.Equals(Product, details.Product);
        }
        public override int GetHashCode()
        {
            return Product.GetHashCode();
        }
        public override string ToString() { 
            return $"Product: {Product}, Quantity: {Quantity}";
        }
    }
}
