using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
            {
                throw new Exception("订单已存在。");
            }
            orders.Add(order);
        }

        public void RemoveOrder(int orderId)
        {
            Order order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
            {
                throw new Exception("订单不存在。");
            }
            orders.Remove(order);
        }

        public void UpdateOrder(Order order)
        {
            Order oldOrder = orders.FirstOrDefault(o => o.OrderId == order.OrderId);
            if (oldOrder == null)
            {
                throw new Exception("订单不存在。");
            }
            orders.Remove(oldOrder);
            orders.Add(order);
        }

        public List<Order> QueryOrdersByPredicate(Func<Order, bool> predicate)
        {
            return orders.Where(predicate).OrderBy(order => order.GetTotalAmount()).ToList();
        }

        public void SortOrders(Func<Order, object> keySelector)
        {
            orders = orders.OrderBy(keySelector).ToList();
        }
    }
}

