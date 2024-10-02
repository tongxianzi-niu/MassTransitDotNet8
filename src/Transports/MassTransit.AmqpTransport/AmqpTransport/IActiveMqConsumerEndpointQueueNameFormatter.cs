namespace MassTransit.AmqpTransport
{
    public interface IActiveMqConsumerEndpointQueueNameFormatter
    {
        public string Format(string topic, string endpointName);
    }
}
