using System;
using KitchenShared.Contracts;
using KitchenShared.Enums;

namespace KitchenShared.Models
{
    /// <summary>
    /// DTO (Data Transfer Object) to represent an order in the kitchen system
    /// </summary>
    public class OrderDto : IOrder
    {
        /// <summary>
        /// Gets or sets the unique identifier of the order
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        /// <summary>
        /// Gets or sets the name of the customer who placed the order
        /// </summary>
        public string CustomerName { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the item that was ordered
        /// </summary>
        public string Item { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the quantity of the item ordered
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the status of the order
        /// </summary>
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
    }
}
