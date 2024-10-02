namespace MassTransit.AmqpTransport
{
    using Transports;


    /// <summary>
    /// Creates and caches a session on the connection
    /// </summary>
    public interface ISessionContextSupervisor :
        ITransportSupervisor<SessionContext>
    {
    }
}
