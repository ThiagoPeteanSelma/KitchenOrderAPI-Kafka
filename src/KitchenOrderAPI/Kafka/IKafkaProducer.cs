
using Confluent.Kafka;
using System.Text.Json;
using KitchenOrderAPI.Models;

namespace KitchenOrderAPI.Kafka
{
    public interface IKafkaProducer
    {
        void Publish(string topic, OrderDto order);
    }
}
