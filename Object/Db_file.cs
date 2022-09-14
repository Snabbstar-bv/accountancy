using System;
using System.Data;
using Microsoft.AspNetCore.Hosting.Server;
using MySql.Data.MySqlClient;
namespace Snabbstar_Education.Object
{
    public class Db_file
    {
        // properties
        private const string db_server = "localhost";
        private const string db_user = "root";
        private const string db_password = "";
        private const string db_name = "sensors";

        public MySqlConnection db_Connection()
        {
            String connection = $"server={db_server};user={db_user};password={db_password};database={db_name};";
            MySqlConnection newConnection = new MySqlConnection(connection);
            newConnection.Open();
            return newConnection;
        }

        public DataTable queryFunction(string sql)
        {
            DataTable query = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db_Connection());
            adapter.Fill(query);
            return query;
        }
    }
}


