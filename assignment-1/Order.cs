using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetails>OrderDetails { get; set; }
        public Order(int id,Customer customer) {
            Id= id;
            Customer = customer;
            OrderDetails = new List<OrderDetails>();
        }

        public void AddOrderDetails(OrderDetails orderDetails) {
            if (OrderDetails.Contains(orderDetails))
            {
                throw new Exception("订单已经存在");
            }
            OrderDetails.Add(orderDetails);
        }

        public double GetTotalAmount()
        {
            return OrderDetails.Sum(detail => detail.Amount);
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
               Id == order.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"OrderId: {Id}, Customer: {Customer}, TotalAmount: {GetTotalAmount()}";
        }
    }
}
