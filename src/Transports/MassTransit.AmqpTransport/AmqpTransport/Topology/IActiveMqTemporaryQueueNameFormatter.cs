namespace MassTransit.AmqpTransport.Topology
{
    public interface IActiveMqTemporaryQueueNameFormatter
    {
        public string Format(string queueName);
    }
}
