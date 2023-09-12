using OneOf;
using System;
using System.Collections.Generic;
using System.Data;

namespace DB
{
    public interface IDataBase<DB_Mediator, QueryType> : IDisposable
    {
        public OneOf<DB_Mediator, Exception> connect(Dictionary<string,string> settings);

        public bool isConnected { get; }

        public OneOf<DataTable,Exception> setQuery(QueryType query);

        public void disconnect();
    }
}
