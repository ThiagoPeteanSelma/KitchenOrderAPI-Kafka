using Confluent.Kafka;
using System.Text.Json;
using KitchenMessaging.Interfaces;
using KitchenShared.Enums;

namespace KitchenMessaging.Producer
{
    public class KafkaProducer<T> : IKafkaProducer<T>
    {
        private readonly IProducer<Null, string> _producer;

        public KafkaProducer(string bootstrapServers)
        {
            var config = new ProducerConfig { BootstrapServers = bootstrapServers };
            _producer = new ProducerBuilder<Null, string>(config).Build();
        }

        public void Publish(KafkaTopic topic, T message)
        {
            var json = JsonSerializer.Serialize(message);
            _producer.Produce(topic.ToString(), new Message<Null, string> { Value = json });
            _producer.Flush(TimeSpan.FromSeconds(5));
        }
    }
}
