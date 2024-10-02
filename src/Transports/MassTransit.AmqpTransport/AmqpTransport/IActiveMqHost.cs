namespace MassTransit.AmqpTransport
{
    using Transports;


    public interface IActiveMqHost :
        IHost<IActiveMqReceiveEndpointConfigurator>
    {
    }
}
