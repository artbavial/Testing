using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Testing
{


    class Program
    {
        static void Main(string[] args)
        {
            string connectDataBase = "server=localhost;uid=root;database=testdb;password=########";

            MySqlConnection connect = new MySqlConnection(connectDataBase);

            connect.Open();

            for (int x = 1; x <= 7; x++)
            {
                string sqlQuery = $"SELECT name FROM tabledb WHERE id = {x}";

                MySqlCommand command = new MySqlCommand(sqlQuery, connect);

                string name = command.ExecuteScalar().ToString();

                Console.WriteLine(name);
            }

            connect.Close();

            Console.ReadKey();
        }
        
    }
}
