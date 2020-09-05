using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;


namespace Day_19_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection con = new Connection();
            Console.WriteLine(con.Open());
        }
    }
}
