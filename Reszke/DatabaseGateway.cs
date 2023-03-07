using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Reszke
{
    internal abstract class DatabaseGateway
    {


        public string ExecuteScalarCommand(string sql, ref MySqlConnection databaseConnection)
        {
            string result;
            try
            {
                databaseConnection.Open();
                MySqlCommand command = new MySqlCommand(sql, databaseConnection);
                result = command.ExecuteScalar().ToString();
                databaseConnection.Close();
                return result;
            }
            catch (Exception e)
            {
                //error
                Debugger.CreateLogMessage($"Błąd przy wykonywaniu komendy '{sql}', ({e.Message})");
                return "";
            }
        }

        public int ExecuteNonQueryCommand(string sql, ref MySqlConnection databaseConnection)
        {
            int result;
            try
            {
                databaseConnection.Open();
                MySqlCommand command = new MySqlCommand(sql, databaseConnection);
                result = command.ExecuteNonQuery();
                databaseConnection.Close();
                return result;
            }
            catch (Exception e)
            {
                //error
                Debugger.CreateLogMessage($"Błąd przy wykonywaniu komendy '{sql}', ({e.Message})");
                return -1;
            }
        }

    }
}
