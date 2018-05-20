using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace nextcars.dal
{
    public abstract class BaseRepository
    {
        public static string GetConnectionString(string connStrName)
        {
            return ConfigurationManager.ConnectionStrings[connStrName].ConnectionString;
        }
        public static IDbConnection OpenConnection(string connStrName)
        {
            IDbConnection connection = new SqlConnection(connStrName);

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }
    }
}
