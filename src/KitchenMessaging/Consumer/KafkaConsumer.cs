using Confluent.Kafka;
using System.Text.Json;
using KitchenMessaging.Interfaces;
using KitchenShared.Enums;
using KitchenShared.Constant;

public class KafkaConsumer<T> : IKafkaConsumer<T>
{
    private readonly ConsumerConfig _config;

    public KafkaConsumer(string bootstrapServers, string groupId)
    {
        _config = new ConsumerConfig
        {
            BootstrapServers = bootstrapServers,
            GroupId = groupId,
            AutoOffsetReset = AutoOffsetReset.Earliest
        };
    }

    public void Consume(KafkaTopic topic, Action<T> handleMessage)
    {
        using var consumer = new ConsumerBuilder<Null, string>(_config).Build();
        consumer.Subscribe(topic.ToString().ToLower());

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
                Console.WriteLine(string.Format(ErrorMessage.JsonDeserializationError, ex.Message));
            }
        }
    }
}
