namespace KitchenShared.Enums
{
    /// <summary>
    /// Represents the Kafka topics used in the application for message publishing and consumption.
    /// </summary>
    public enum KafkaTopic
    {
        Orders,
        OrdersResponse,
        DeadLetter
    }
}