using Npgsql;
using System;

namespace CreaterOfDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string username = "student";
            string password = username;
            var connString = $"Host = 192.168.56.101; Port = 5432; Database = Students; Username ={username}; Password ={password}";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("CREATE TABLE Test(id INTEGER PRIMARY KEY)", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
