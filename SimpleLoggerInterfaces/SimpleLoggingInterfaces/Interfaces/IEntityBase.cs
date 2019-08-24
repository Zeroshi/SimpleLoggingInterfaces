using System;
using static SimpleLoggingInterfaces.Enums.EnumCollection;

namespace SimpleLoggingInterfaces.Interfaces
{
    public interface IEntityBase
    {
        bool WrittenToPlatform { get; set; }
        bool OnlyInnerException { get; set; }
        string Note { get; set; }
        LogLevel LogLevel { get; set; }
        Exception Error { get; set; }
        string Application { get; set; }
        DateTime DateTime { get; set; }
    }
}