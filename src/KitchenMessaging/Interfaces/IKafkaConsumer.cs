using System;
using KitchenShared.Enums;

namespace KitchenMessaging.Interfaces
{
    /// <summary>
    /// Interface to define a Kafka consumer for consuming messages from a Kafka topic.
    /// </summary>
    public interface IKafkaConsumer<T>
    {
        /// <summary>
        /// Consumes messages of type T from the specified Kafka topic and invokes the provided message handler for each consumed message.
        /// </summary>
        /// <param name="topic">The Kafka topic to consume messages from.</param>
        /// <param name="messageHandler">The handler to invoke for each consumed message.</param>
        void Consume(KafkaTopic topic, Action<T> messageHandler);
    }
}