using Confluent.Kafka;
using System.Text.Json;
using KitchenMessaging.Interfaces;
using KitchenShared.Enums;
using KitchenShared.Constant;
using Microsoft.Extensions.Logging;

namespace KitchenMessaging.Consumer
{
    /// <summary>
    /// Kafka consumer implementation for consuming messages from a Kafka topic.
    /// </summary>
    /// <typeparam name="T">The type of messages to consume.</typeparam>
    public class KafkaConsumer<T> : IKafkaConsumer<T>
    {
        /// <summary>
        /// The configuration for the Kafka consumer, including bootstrap servers, group ID, and auto offset reset policy.
        /// </summary>
        private readonly ConsumerConfig _config;

        private readonly ILogger<KafkaConsumer<T>> _logger;
        /// <summary>
        /// Initializes a new instance of the KafkaConsumer class with the specified bootstrap servers, group ID, username, and password.
        /// </summary>
        /// <param name="bootstrapServers">The Kafka bootstrap servers.</param>
        /// <param name="groupId">The consumer group ID.</param>
        /// <param name="username">The SASL username for authentication.</param>
        /// <param name="password">The SASL password for authentication.</param>
        public KafkaConsumer(string bootstrapServers, string groupId, string username, string password, ILogger<KafkaConsumer<T>> logger)
        {
            _config = KafkaConfig.GetConsumerConfig(bootstrapServers, groupId, username, password);
            _logger = logger;
        }
        /// <summary>
        /// Consumes messages of type T from the specified Kafka topic and invokes the provided message handler for each consumed message.
        /// </summary>
        /// <param name="topic">The Kafka topic to consume messages from.</param>
        /// <param name="handleMessage">The action to invoke for each consumed message of type T.</param>
        public void Consume(KafkaTopic topic, Action<T> handleMessage)
        {
            using var consumer = new ConsumerBuilder<Null, string>(_config).Build();
            consumer.Subscribe(topic.ToString().ToLower());
            _logger.LogInformation(LogMessages.ConsumerStarted, topic);

            while (true)
            {
                var cr = consumer.Consume();
                try
                {
                    var obj = JsonSerializer.Deserialize<T>(cr.Message.Value);
                    if (obj != null)
                        handleMessage(obj);
                }
                catch (JsonException ex)
                {
                    _logger.LogError(LogMessages.JsonDeserializationError, topic, ex.Message);
                }
                catch (Exception ex)
                {
                    _logger.LogError(LogMessages.UnexpectedConsumerError, topic, ex.Message);
                }
            }
        }
    }
}