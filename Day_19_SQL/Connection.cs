using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Day_19_SQL
{
    class Connection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;


        public Connection()
        {
            Init();
        }

        private void Init()
        {
            server = "localhost";
            database = "veikals";
            uid = "root";
            password = "pollux";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public bool Open()
        {
            connection.Open();
            return true;
        }
    }

}