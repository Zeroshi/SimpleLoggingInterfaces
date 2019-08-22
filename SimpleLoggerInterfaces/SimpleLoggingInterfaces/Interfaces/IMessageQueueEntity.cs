namespace SimpleLoggingInterfaces.Interfaces
{
    public interface IMessageQueueEntity : IEntityBase
    {
        string PopMessage { get; set; }
        string PushMessage { get; set; }
    }
}