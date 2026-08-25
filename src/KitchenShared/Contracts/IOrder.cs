using System;
using KitchenShared.Enums;

namespace KitchenShared.Contracts
{
    /// <summary>
    /// Interface to represent an order in the kitchen order system
    /// </summary>
    public interface IOrder
    {
        /// <summary>
        /// Gets or sets the unique identifier for the order
        /// </summary>
        Guid Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the customer who placed the order
        /// </summary>
        string CustomerName { get; set; }
        /// <summary>
        /// Gets or sets the item that was ordered
        /// </summary>
        string Item { get; set; }
        /// <summary>
        /// Gets or sets the quantity of the item ordered
        /// </summary>
        int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the status of the order
        /// </summary>
        OrderStatus Status { get; set; }
    }
}