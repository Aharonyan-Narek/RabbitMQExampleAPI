namespace RabbitMQExampleAPI.Producers
{
    public interface IMessageProducer
    {
        void SendMessage<T>(T message);
    }
}
