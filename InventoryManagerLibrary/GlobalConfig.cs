using InventoryManagerLibrary.DataAccess;
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
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitialiseConnections(bool database, bool textFiles)
        {
             if (database)
            {
                // TODO - Set up the SQL Connector properly
                NpgsqlConnector npgsql = new NpgsqlConnector();
                Connections.Add(npgsql);
            }

             if (textFiles)
            {
                // TODO - Create text connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
