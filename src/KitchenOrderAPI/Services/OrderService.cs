using KitchenOrderAPI.Models;

namespace KitchenOrderAPI.Services
{
    public interface IOrderService
    {
        OrderDto Create(OrderDto order);
        OrderDto? GetById(Guid id);
        IEnumerable<OrderDto> GetAll();
        bool UpdateStatus(Guid id, string status);
        bool Cancel(Guid id);
    }

    public class OrderService : IOrderService
    {
        private readonly List<OrderDto> _orders = new();

        public OrderDto Create(OrderDto order)
        {
            _orders.Add(order);
            return order;
        }

        public OrderDto? GetById(Guid id) => _orders.FirstOrDefault(o => o.Id == id);

        public IEnumerable<OrderDto> GetAll() => _orders;

        public bool UpdateStatus(Guid id, string status)
        {
            var order = GetById(id);
            if (order == null) return false;
            order.Status = status;
            return true;
        }

        public bool Cancel(Guid id)
        {
            var order = GetById(id);
            if (order == null) return false;
            _orders.Remove(order);
            return true;
        }
    }
}
