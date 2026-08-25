namespace KitchenOrderAPI.Models
{
    public class OrderDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CustomerName { get; set; } = string.Empty;
        public string Item { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
