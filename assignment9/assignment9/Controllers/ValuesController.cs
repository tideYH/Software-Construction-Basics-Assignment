

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using assignment9class;

namespace assignment9.Controllers
{

    [ApiController]
    [Route("api/order")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService orderService;

        public OrderController(OrderService orderService)
        {
            this.orderService = orderService;
        }

        // GET: api/Order
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            return orderService.QueryOrdersByPredicate(o=>true);
        }

        // GET: api/Order/1
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var orders = orderService.QueryOrdersByPredicate(o => o.OrderId == id);
            var order = orders.FirstOrDefault();
            return (order == null) ? NotFound() : Ok(order);
        }


        // POST: api/Order
        [HttpPost]
        public ActionResult<Order> AddOrder(Order order)
        {

                orderService.AddOrder(order);
            return order;
        }

        // PUT: api/Order/1
        [HttpPut("{id}")]
        public ActionResult<Order> UpdateOrder(int id, Order order)
        {
            if (id != order.OrderId)
            {
                return BadRequest();
            }
            try
            {
                orderService.UpdateOrder(order);
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/Order/1
        [HttpDelete("{id}")]
        public ActionResult<Order> DeleteOrder(int id)
        {
            try
            {
                orderService.RemoveOrder(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException?.Message ?? e.Message);
            }
            return NoContent();
        }

    }

}

