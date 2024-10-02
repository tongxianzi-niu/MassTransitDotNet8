namespace MassTransit.AmqpTransport.Topology
{
    using MassTransit.Topology;


    public interface ConsumerHandle :
        EntityHandle
    {
        Consumer Consumer { get; }
    }
}
