namespace SimpleLoggingInterfaces.Enums
{
    public class EnumCollection
    {
        public enum LogLevel
        {
            Debug = 0,
            Info = 1,
            Error = 2,
            Off = 3
        }

        public enum TransactionType
        {
            Internal = 0,
            External = 1
        }
    }
}