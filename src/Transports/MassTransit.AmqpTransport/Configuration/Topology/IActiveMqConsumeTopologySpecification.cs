namespace MassTransit
{
    using AmqpTransport.Topology;


    public interface IActiveMqConsumeTopologySpecification :
        ISpecification
    {
        void Apply(IReceiveEndpointBrokerTopologyBuilder builder);
    }
}
