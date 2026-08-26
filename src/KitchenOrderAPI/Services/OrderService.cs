using KitchenShared.Models;
using KitchenShared.Enums;
using KitchenOrderAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitchenOrderAPI.Services
{
    /// <summary>
    /// Service class for managing orders. This class provides methods to create, retrieve, update, and cancel orders. It uses an in-memory list to store orders and is designed to be a singleton service.
    /// The service also utilizes Kafka settings for potential integration with a Kafka producer, although the actual implementation is not shown in this example.
    /// </summary>
    public class OrderService : IOrderService
    {
        /// <summary>
        /// In-memory list to store orders. This list is used to simulate a database for the purpose of this example. In a real-world application, this would be replaced with a database context or repository.
        /// </summary>
        private readonly List<OrderDto> _orders = new();
        /// <summary>
        /// Kafka settings used for configuring the Kafka producer. This allows the service to send order messages to a Kafka topic. The settings are injected via dependency injection and can be configured in the appsettings.json file.
        /// </summary>
        private readonly KafkaSettings _kafkaSettings;
        /// <summary>
        /// Initializes a new instance of the OrderService class with the specified Kafka settings. The Kafka settings are used to configure the Kafka producer for sending order messages. This constructor is called by the dependency injection framework when the service is registered in the application.
        /// </summary>
        /// <param name="kafkaSettings">The Kafka settings used to configure the Kafka producer.</param>
        public OrderService(KafkaSettings kafkaSettings)
        {
            _kafkaSettings = kafkaSettings;
        }
        /// <summary>
        /// Creates a new order and adds it to the in-memory list of orders. This method simulates the creation of an order and would typically involve additional logic such as validation, persistence to a database, and sending a message to a Kafka topic. In this example, the order is simply added to the list and returned.
        /// </summary>
        /// <param name="order">The order to create.</param>
        /// <returns>The created order.</returns>
        public OrderDto Create(OrderDto order)
        {
            _orders.Add(order);
            return order;
        }
        /// <summary>
        /// Retrieves an order by its unique identifier. This method searches the in-memory list of orders for an order with the specified ID. If found, the order is returned; otherwise, null is returned. This method simulates the retrieval of an order and would typically involve querying a database or other data store.
        /// </summary>
        /// <param name="id">The unique identifier of the order.</param>
        /// <returns>The order with the specified ID, or null if not found.</returns>
        public OrderDto? GetById(Guid id) => _orders.FirstOrDefault(o => o.Id == id);
        /// <summary>
        /// Retrieves all orders in the in-memory list. This method returns an enumerable collection of all orders currently stored in the service. In a real-world application, this method would typically involve querying a database or other data store to retrieve the orders.
        /// </summary>
        /// <returns>A collection of all orders.</returns>
        public IEnumerable<OrderDto> GetAll() => _orders;
        /// <summary>
        /// Updates the status of an existing order. This method searches for an order with the specified ID and, if found, updates its status to the provided value. If the order is not found, the method returns false; otherwise, it returns true to indicate that the status was successfully updated. This method simulates the process of updating an order's status and would typically involve additional logic such as validation and persistence to a database.
        /// </summary>
        /// <param name="id">The unique identifier of the order to update.</param>
        /// <param name="status">The new status to set for the order.</param>
        /// <returns>True if the order was found and updated; otherwise, false.</returns>
        public bool UpdateStatus(Guid id, OrderStatus status)
        {
            var order = GetById(id);
            if (order == null) return false;
            order.Status = status;
            return true;
        }
        /// <summary>
        /// Cancels an existing order by setting its status to "Cancelled". This method searches for an order with the specified ID and, if found, updates its status to "Cancelled". If the order is not found, the method returns false; otherwise, it returns true to indicate that the order was successfully cancelled. This method simulates the process of cancelling an order and would typically involve additional logic such as validation and persistence to a database.
        /// </summary>
        /// <param name="id">The unique identifier of the order to cancel.</param>
        /// <returns>True if the order was found and cancelled; otherwise, false.</returns>
        public bool Cancel(Guid id)
        {
            var order = GetById(id);
            if (order == null) return false;
            switch (order.Status)
            {
                case OrderStatus.Completed:
                case OrderStatus.Cancelled:
                    return false; // Cannot cancel orders that are already completed or cancelled
            }
            order.Status = OrderStatus.Cancelled;
            return true;
        }

        public bool Remove(Guid id)
        {
            var order = GetById(id);
            if (order == null) return false;

            switch (order.Status)
            {
                case OrderStatus.Completed:
                case OrderStatus.Cancelled:
                    _orders.Remove(order);
                    return true;
                default:
                    return false; // Cannot remove orders that are not completed or cancelled
            }
        }
    }
}
