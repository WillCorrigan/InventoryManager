using InventoryManagerLibrary.DataAccess;
using InventoryManagerLibrary.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitialiseConnections(DatabaseType db)
        {
             if (db == DatabaseType.Sql)
            {
                // TODO - Set up the SQL Connector properly
                NpgsqlConnector npgsql = new NpgsqlConnector();
                Connection = npgsql;
            }

             if (db == DatabaseType.TextFile)
            {
                // TODO - Create text connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
