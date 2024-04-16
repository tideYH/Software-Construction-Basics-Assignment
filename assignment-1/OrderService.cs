using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
            {
                throw new Exception("订单已经存在");
            }
            orders.Add(order);
        }

        public void RemoveOrder(int orderId)
        {
            Order order = orders.FirstOrDefault(o => o.Id == orderId);
        }
    }
}
