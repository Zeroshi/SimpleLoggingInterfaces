using static SimpleLoggingInterfaces.Enums.EnumCollection;

namespace SimpleLoggingInterfaces.Interfaces
{
    public interface ITransactions : IEntityBase
    {
        TransactionType TrasactionType { get; set; }
        string Request { get; set; }
        string Reponse { get; set; }
        string URI { get; set; }
    }
}