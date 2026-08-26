using Confluent.Kafka;

namespace KitchenMessaging
{
    /// <summary>
    /// Provides configuration settings for Kafka producers and consumers, including bootstrap servers, security protocols, and authentication credentials.
    /// </summary>
    public static class KafkaConfig
    {
        /// <summary>
        /// Gets the configuration settings for a Kafka producer, including bootstrap servers, security protocol, SASL mechanism, username, and password.
        /// </summary>
        /// <param name="bootstrapServers">The Kafka bootstrap servers.</param>
        /// <param name="username">The SASL username for authentication.</param>
        /// <param name="password">The SASL password for authentication.</param>
        /// <returns>A ProducerConfig object containing the configuration settings for the Kafka producer.</returns>
        public static ProducerConfig GetProducerConfig(string bootstrapServers, string username, string password)
        {
            return new ProducerConfig
            {
                BootstrapServers = bootstrapServers,
                SecurityProtocol = SecurityProtocol.SaslSsl,
                SaslMechanism = SaslMechanism.ScramSha512,
                SaslUsername = username,
                SaslPassword = password
            };
        }
        /// <summary>
        /// Gets the configuration settings for a Kafka consumer, including bootstrap servers, group ID, security protocol, SASL mechanism, username, and password.
        /// </summary>
        /// <param name="bootstrapServers">The Kafka bootstrap servers.</param>
        /// <param name="groupId">The consumer group ID.</param>
        /// <param name="username">The SASL username for authentication.</param>
        /// <param name="password">The SASL password for authentication.</param>
        /// <returns>A ConsumerConfig object containing the configuration settings for the Kafka consumer.</returns>
        public static ConsumerConfig GetConsumerConfig(string bootstrapServers, string groupId, string username, string password)
        {
            return new ConsumerConfig
            {
                BootstrapServers = bootstrapServers,
                GroupId = groupId,
                AutoOffsetReset = AutoOffsetReset.Earliest,
                SecurityProtocol = SecurityProtocol.SaslSsl,
                SaslMechanism = SaslMechanism.ScramSha512,
                SaslUsername = username,
                SaslPassword = password
            };
        }
    }
}