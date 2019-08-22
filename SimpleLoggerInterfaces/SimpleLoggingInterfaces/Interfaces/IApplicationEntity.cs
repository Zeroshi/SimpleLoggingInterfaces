namespace SimpleLoggingInterfaces.Interfaces
{
    public interface IApplicationEntity : IEntityBase
    {
        string ApplicationMessage { get; set; }
        string CurrentMethod { get; set; }
    }
}