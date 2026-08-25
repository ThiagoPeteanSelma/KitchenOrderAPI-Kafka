using Microsoft.AspNetCore.Mvc;
using KitchenOrderAPI.Models;   // DTOs e entidades
using KitchenOrderAPI.Services; // Serviços de negócio
using KitchenOrderAPI.Kafka;    // Producer

namespace KitchenOrderAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        // POST /api/orders
        [HttpPost]
        public IActionResult CreateOrder([FromBody] OrderDto order)
        {
            // TODO: Lógica para enviar pedido ao Kafka Producer
            return Ok();
        }

        // GET /api/orders/{id}
        [HttpGet("{id}")]
        public IActionResult GetOrderById(Guid id)
        {
            // TODO: Lógica para buscar pedido
            return Ok();
        }

        // GET /api/orders
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            // TODO: Lógica para listar pedidos
            return Ok();
        }

        // PUT /api/orders/{id}/status
        [HttpPut("{id}/status")]
        public IActionResult UpdateOrderStatus(Guid id, [FromBody] string status)
        {
            // TODO: Lógica para atualizar status
            return Ok();
        }

        // DELETE /api/orders/{id}
        [HttpDelete("{id}")]
        public IActionResult CancelOrder(Guid id)
        {
            // TODO: Lógica para cancelar pedido
            return Ok();
        }
    }
}