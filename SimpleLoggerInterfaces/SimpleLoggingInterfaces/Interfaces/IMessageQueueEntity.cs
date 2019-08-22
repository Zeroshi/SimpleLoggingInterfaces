namespace SimpleLoggingInterfaces.Interfaces
{
    public interface IMessageQueueEntity
    {
        string PopMessage { get; set; }
        string PushMessage { get; set; }
    }
}