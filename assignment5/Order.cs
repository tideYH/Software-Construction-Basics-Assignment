using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public int OrderId { get; set; }
    public Customer Customer { get; set; }
    public List<OrderDetails> OrderDetails { get; set; }

    public Order(int orderId, Customer customer)
    {
        OrderId = orderId;
        Customer = customer;
        OrderDetails = new List<OrderDetails>();
    }

    public void AddOrderDetail(OrderDetails orderDetail)
    {
        if (OrderDetails.Contains(orderDetail))
        {
            throw new Exception("订单明细已存在。");
        }
        OrderDetails.Add(orderDetail);
    }

    public decimal GetTotalAmount()
    {
        return OrderDetails.Sum(detail => detail.Amount);
    }

    public override bool Equals(object obj)
    {
        return obj is Order order &&
               OrderId == order.OrderId;
    }

    public override int GetHashCode()
    {
        return OrderId.GetHashCode();
    }

    public override string ToString()
    {
        return $"OrderId: {OrderId}, Customer: {Customer}, TotalAmount: {GetTotalAmount()}";
    }
}

