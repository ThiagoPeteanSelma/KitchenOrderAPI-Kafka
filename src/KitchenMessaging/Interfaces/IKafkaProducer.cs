using System;
using KitchenShared.Enums;

namespace KitchenMessaging.Interfaces
{
    /// <summary>
    /// Interface to define a Kafka producer for publishing messages to a Kafka topic.
    /// </summary>
    /// <typeparam name="T">The type of message to be published to the Kafka topic.</typeparam>
    public interface IKafkaProducer<T>
    {
        /// <summary>
        /// Publishes a message of type T to the specified Kafka topic.
        /// </summary>
        /// <param name="topic">The Kafka topic to publish the message to.</param>
        /// <param name="message">The message of type T to be published.</param>
        void Publish(KafkaTopic topic, T message);
    }
}
