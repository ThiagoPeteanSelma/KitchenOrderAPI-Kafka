
using Confluent.Kafka;
using System.Text.Json;
using KitchenOrderAPI.Models;

namespace KitchenOrderAPI.Kafka
{
    public class KafkaProducer : IKafkaProducer
    {
        private readonly IProducer<Null, string> _producer;

        public KafkaProducer()
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };
            _producer = new ProducerBuilder<Null, string>(config).Build();
        }

        public void Publish(string topic, OrderDto order)
        {
            var message = JsonSerializer.Serialize(order);
            _producer.Produce(topic, new Message<Null, string> { Value = message });
        }
    }
}
