using KitchenShared.Enums;
using KitchenShared.Models;
using System;

namespace KitchenOrderAPI.Interfaces
{
    /// <summary>
    /// Interface for order service operations.
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Creates a new order.
        /// </summary>
        /// <param name="order">The order to create.</param>
        /// <returns>The created order.</returns>
        OrderDto Create(OrderDto order);
        /// <summary>
        /// Gets an order by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the order.</param>
        /// <returns>The order with the specified ID, or null if not found.</returns>
        OrderDto? GetById(Guid id);
        /// <summary>
        /// Gets all orders.
        /// </summary>
        /// <returns>A collection of all orders.</returns>
        IEnumerable<OrderDto> GetAll();
        /// <summary>
        /// Updates the status of an order.
        /// </summary>
        /// <param name="id">The unique identifier of the order.</param>
        /// <param name="status">The new status of the order.</param>
        /// <returns>True if the status was updated successfully; otherwise, false.</returns>
        bool UpdateStatus(Guid id, OrderStatus status);
        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="id">The unique identifier of the order.</param>
        /// <returns>True if the order was cancelled successfully; otherwise, false.</returns>
        bool Cancel(Guid id);
    }
}