namespace EventLoggerConnector
{
    public interface IEventSink
    {
        void OnMessage(Message msg);
    }
}