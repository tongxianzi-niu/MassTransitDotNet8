namespace MassTransit.AmqpTransport
{
    public class ArtemisConsumerEndpointQueueNameFormatter :
        IActiveMqConsumerEndpointQueueNameFormatter
    {
        public string Format(string topic, string endpointName)
        {
            return $"{topic}::Consumer.{endpointName}.{topic}";
        }
    }
}
