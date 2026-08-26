using Confluent.Kafka;
using System.Text.Json;
using KitchenMessaging.Interfaces;
using KitchenShared.Enums;
using KitchenShared.Constant;
using Microsoft.Extensions.Logging;

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
        /// <summary>
        /// The logger instance used for logging information and errors related to the Kafka producer.
        /// </summary>
        private readonly ILogger<KafkaProducer<T>> _logger;
        /// <summary>
        /// Initializes a new instance of the KafkaProducer class with the specified bootstrap servers, username, password, and logger.
        /// </summary>
        /// <param name="bootstrapServers">The Kafka bootstrap servers.</param>
        /// <param name="username">The username for Kafka authentication.</param>
        /// <param name="password">The password for Kafka authentication.</param>
        /// <param name="logger">The logger instance for logging information and errors.</param>
        public KafkaProducer(string bootstrapServers, string username, string password, ILogger<KafkaProducer<T>> logger)
        {
            var config = KafkaConfig.GetProducerConfig(bootstrapServers, username, password);
            _producer = new ProducerBuilder<Null, string>(config).Build();
            _logger = logger;
        }
        /// <summary>
        /// Publishes a message of type T to the specified Kafka topic.
        /// </summary>
        /// <param name="topic">The Kafka topic to publish the message to.</param>
        /// <param name="message">The message of type T to publish.</param>
        public void Publish(KafkaTopic topic, T message)
        {
            try
            {
                var json = JsonSerializer.Serialize(message);
                _producer.Produce(topic.ToString(), new Message<Null, string> { Value = json });
                _producer.Flush(TimeSpan.FromSeconds(5));
                _logger.LogInformation(LogMessages.MessagePublished, topic, json);
            }
            catch (Exception ex)
            {
                _logger.LogError(LogMessages.ProducerError, topic, ex.Message);
            }
        }
    }
}
