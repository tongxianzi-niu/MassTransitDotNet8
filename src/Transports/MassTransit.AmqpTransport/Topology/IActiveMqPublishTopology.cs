namespace MassTransit
{
    using AmqpTransport.Topology;


    public interface IActiveMqPublishTopology :
        IPublishTopology
    {
        string VirtualTopicPrefix { get; }

        string VirtualTopicConsumerPattern { get; }

        new IActiveMqMessagePublishTopology<T> GetMessageTopology<T>()
            where T : class;

        BrokerTopology GetPublishBrokerTopology();
    }
}
