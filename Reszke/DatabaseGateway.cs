using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Reszke
{
    internal static class DatabaseGateway
    {

        public static string ExecuteScalarCommand(string sql, ref MySqlConnection databaseConnection)
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

        public static int ExecuteNonQueryCommand(string sql, ref MySqlConnection databaseConnection)
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

        public static string[,] ExecuteSelectCommand(string sql, ref MySqlConnection databaseConnection)
        {
            try
            {
                //funkcja ładująca dane z bazy pobrane poleceniem select i zwracajaza je w formie tabeli
                List<List<string>> data = new List<List<string>>();


                MySqlCommand command = new MySqlCommand(sql, databaseConnection);

                databaseConnection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                

                while (reader.Read())
                {
                    List<string> row = new List<string>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader.GetValue(i).ToString());
                    }

                    data.Add(row);
                }

                reader.Close();
                databaseConnection.Close();


                int rows = data.Count;
                int columns = data[0].Count;

                string[,] result = new string[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        result[i, j] = data[i][j];
                    }
                }


                return result;
            }
            catch (Exception e)
            {
                //error
                Debugger.CreateLogMessage($"Błąd przy wykonywaniu komendy '{sql}', ({e.Message})");
                return new string[0,0];
            }

        }

        public static string GetStringSha256Hash(string text)
        {
            //Function for generating SHA256 hashes
            if (String.IsNullOrEmpty(text))
            {
                return String.Empty;
            }
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        public static string SanitizeString(string input)
        {
            //Function for sanitizing strings, especially recieved directly from user. 
            Regex ruleRegex = new Regex(@"[^\w\.\s@-]");
            return Regex.Replace(input, $"{ruleRegex}", "");
        }
    }
}
