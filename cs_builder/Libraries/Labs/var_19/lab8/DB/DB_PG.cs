using Npgsql;
using System.Data;
using OneOf;

namespace DB.PG
{
    public class DB_PG : IDataBase<NpgsqlConnection, NpgsqlCommand>
    {
        NpgsqlConnection connection;
        public NpgsqlConnection SetConnection { set { connection = value; } }

        public DB_PG() {}

        public OneOf<NpgsqlConnection, Exception> connect(Dictionary<string, string> settings)
        {
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(
                    $"Host={settings["server"]};" +
                    $"Port={settings["port"]};" +
                    $"Database={settings["db_name"]};" +
                    $"Username={settings["user_name"]};" +
                    $"Password={settings["password"]};"
                );

                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    return connection;
                }

                return new Exception("Connection failed : provided data is bad");
            }
            catch (Exception error)
            {
                return error;
            }
        }

        public bool isConnected => connection != null && connection.State == ConnectionState.Open;

        public OneOf<DataTable, Exception> setQuery(NpgsqlCommand commandQuery)
        {
            if (!isConnected)
            {
                return new Exception("Connection does not exist");
            }

            try
            {
                DataSet ds = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

                commandQuery.Connection = connection;
                adapter.SelectCommand = commandQuery;
                adapter.Fill(ds);

                return ds.Tables.Count == 0 ? new DataTable() : ds.Tables[0];
            }
            catch (Exception error)
            {
                return error;
            }
        }

        public void disconnect()
        {
            if (isConnected)
            {
                connection.Close();
            }
            connection.Dispose();
        }

        public void Dispose()
        {
            disconnect();
        }
    }
}
