using Confluent.Kafka;
using System.Text.Json;
using KitchenMessaging.Interfaces;
using KitchenShared.Enums;

namespace KitchenMessaging.Producer
{
    /// <summary>
    /// Represents a Kafka producer that can publish messages of type T to a specified Kafka topic.
    /// </summary>
    /// <typeparam name="T">The type of messages to publish.</typeparam>
    public class KafkaProducer<T> : IKafkaProducer<T>
    {
        /// <summary>
        /// The Kafka producer instance used to send messages to the Kafka broker.
        /// </summary>
        private readonly IProducer<Null, string> _producer;
        public KafkaProducer(string bootstrapServers, string username, string password)
        {
            var config = KafkaConfig.GetProducerConfig(bootstrapServers, username, password);
            _producer = new ProducerBuilder<Null, string>(config).Build();
        }
        /// <summary>
        /// Publishes a message of type T to the specified Kafka topic.
        /// </summary>
        /// <param name="topic">The Kafka topic to publish the message to.</param>
        /// <param name="message">The message of type T to publish.</param>
        public void Publish(KafkaTopic topic, T message)
        {
            var json = JsonSerializer.Serialize(message);
            _producer.Produce(topic.ToString(), new Message<Null, string> { Value = json });
            _producer.Flush(TimeSpan.FromSeconds(5));
        }
    }
}
