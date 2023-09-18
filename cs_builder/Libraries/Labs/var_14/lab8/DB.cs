using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using OneOf;

namespace cs_builder.Libraries.Labs.var_14.lab8
{
    public class DB
    {
        NpgsqlConnection connection;

        public DB()
        {
            this.connection = new NpgsqlConnection();
        }

        public bool isConnected { 
            get { 
                return connection.State == ConnectionState.Open;
            } 
        }
        public Exception? connect(string connection_string)
        {
            try
            {
                connection.ConnectionString = connection_string;
                connection.Open();
                if(connection.State == ConnectionState.Open)
                {
                    return null;
                }


                return new Exception("Incorrect connection data");
            }catch (Exception ex)
            {
                return ex;
            }
        }

        public OneOf<Exception,DataTable> pushQuery(string query)
        {
            if (!isConnected) return new Exception("Connection does not exist");

            try
            {
                DataSet dataSet = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
                adapter.SelectCommand = new NpgsqlCommand(query, connection);
                adapter.Fill(dataSet);

                if (dataSet.Tables.Count > 0) return dataSet.Tables[0];
                return new DataTable();

            }catch(Exception ex)
            {
                return ex;
            }
        }
    }
}
