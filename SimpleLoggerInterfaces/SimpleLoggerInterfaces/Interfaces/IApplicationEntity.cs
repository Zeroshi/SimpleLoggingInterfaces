namespace SimpleLoggerInterfaces.Interfaces
{
    public interface IApplicationEntity
    {
        string ApplicationMessage { get; set; }
        string CurrentMethod { get; set; }
    }
}