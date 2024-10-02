namespace MassTransit.AmqpTransport.Configuration
{
    using MassTransit.Configuration;
    using Transports;


    public interface IActiveMqReceiveEndpointConfiguration :
        IReceiveEndpointConfiguration,
        IActiveMqEndpointConfiguration
    {
        ReceiveSettings Settings { get; }

        void Build(IHost host);
    }
}
