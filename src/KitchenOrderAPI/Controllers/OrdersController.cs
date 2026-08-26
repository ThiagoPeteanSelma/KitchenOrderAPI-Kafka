using Microsoft.AspNetCore.Mvc;
using KitchenShared.Models;   // DTOs e entidades
using KitchenOrderAPI.Services; // Serviços de negócio
using KitchenMessaging.Producer;    // Producer
using KitchenShared.Enums; // Enums

namespace KitchenOrderAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }
        // POST /api/orders
        [HttpPost]
        public IActionResult CreateOrder([FromBody] OrderDto order)
        {
            _orderService.Create(order);
            return Ok();
        }

        // GET /api/orders/{id}
        [HttpGet("{id}")]
        public IActionResult GetOrderById(Guid id)
        {
            var order = _orderService.GetById(id);
            if (order == null) return NotFound();
            return Ok(order);
        }

        // GET /api/orders
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var orders = _orderService.GetAll();
            return Ok(orders);
        }

        // PUT /api/orders/{id}/status
        [HttpPut("{id}/status")]
        public IActionResult UpdateOrderStatus(Guid id, [FromBody] string status)
        {
            var success = _orderService.UpdateStatus(id, Enum.Parse<OrderStatus>(status, true));
            if (!success) return NotFound();
            return Ok();
        }

        // PUT /api/orders/{id}/cancel
        [HttpPut("{id}/cancel")]
        public IActionResult CancelOrder(Guid id)
        {
            var success = _orderService.Cancel(id);
            if (!success) return NotFound();
            return Ok();
        }

        // DELETE /api/orders/{id}
        [HttpDelete("{id}")]
        public IActionResult RemoveOrder(Guid id)
        {
            var success = _orderService.Remove(id);
            if (!success) return NotFound();
            return Ok();
        }
    }
}