using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLoggingInterfaces.Interfaces
{
    public interface IRelationalDatabaseEntity : IEntityBase
    {
        string Query { get; set; }
        string Database { get; set; }
        string QueryResult { get; set; }
    }
}