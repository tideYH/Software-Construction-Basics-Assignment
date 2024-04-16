using System;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();

            // 示例：添加订单
            Customer customer = new Customer("张三");
            Order order = new Order(1, customer);
            Product product = new Product("电脑", 5000m);
            OrderDetails orderDetails = new OrderDetails(product, 1);
            order.AddOrderDetail(orderDetails);
            orderService.AddOrder(order);

            // 示例：查询订单
            var orders = orderService.QueryOrdersByPredicate(o => o.Customer.Name == "张三");
            foreach (var ord in orders)
            {
                Console.WriteLine(ord);
            }

            // 这里可以添加更多操作示例，如删除、修改等
        }
    }
}
