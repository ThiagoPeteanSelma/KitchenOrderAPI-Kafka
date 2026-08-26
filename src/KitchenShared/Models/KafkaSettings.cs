namespace KitchenShared.Models
{
    /// <summary>
    /// Class that represents the settings required to configure Kafka connections and authentication.
    /// </summary>
    public class KafkaSettings
    {
        /// <summary>
        /// Gets or sets the bootstrap servers for the Kafka connection, which is a comma-separated list of host:port pairs that the Kafka client will use to establish an initial connection to the Kafka cluster.
        /// </summary>
        public required string BootstrapServers { get; set; }
        /// <summary>
        /// Gets or sets the security protocol used for the Kafka connection, which defines how the client will communicate with the Kafka brokers (e.g., PLAINTEXT, SSL, SASL_PLAINTEXT, SASL_SSL).
        /// </summary>
        public required string SecurityProtocol { get; set; }
        /// <summary>
        /// Gets or sets the SASL mechanism used for authentication with the Kafka brokers, which specifies the authentication method (e.g., PLAIN, SCRAM-SHA-256, SCRAM-SHA-512).
        /// </summary>
        public required string SaslMechanism { get; set; }
        /// <summary>
        /// Gets or sets the SASL username used for authentication with the Kafka brokers, which is required when using SASL mechanisms that require a username and password.
        /// </summary>
        public required string SaslUsername { get; set; }
        /// <summary>
        /// Gets or sets the SASL password used for authentication with the Kafka brokers, which is required when using SASL mechanisms that require a username and password.
        /// </summary>
        public required string SaslPassword { get; set; }
        /// <summary>
        /// Gets or sets the consumer group ID used to identify the group of consumers that share the same subscription to Kafka topics, which is important for load balancing and message processing.
        /// </summary>
        public required string GroupId { get; set; }
    }
}
