using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
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
            //Funkcja pobierająca pojedynczą wartość z bazy, zwraca ją w formie stringa
            //W przypadku błędu zwraca pusty łańcuch
            string result;
            try
            {
                if (databaseConnection != null && databaseConnection.State == ConnectionState.Closed)
                {
                    databaseConnection.Open();
                    MySqlCommand command = new MySqlCommand(sql, databaseConnection);
                    result = command.ExecuteScalar().ToString();
                    databaseConnection.Close();
                    return result;
                }
                else
                {
                    return "";
                }
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
            //Funkcja zwraca ilość wierszy, na które wpłynęło wykonanie polecenia
            //W przypadku wystąpienia błędu, zwraca -1
            int result;
            try
            {
                if (databaseConnection != null && databaseConnection.State == ConnectionState.Closed)
                {
                    databaseConnection.Open();
                    MySqlCommand command = new MySqlCommand(sql, databaseConnection);
                    result = command.ExecuteNonQuery();
                    databaseConnection.Close();
                    return result;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                //error
                Debugger.CreateLogMessage($"Błąd przy wykonywaniu komendy '{sql}', ({e.Message})");
                return -1;
            }
            finally
            {
                if (databaseConnection != null && databaseConnection.State == ConnectionState.Open)
                {
                    databaseConnection.Close();
                }
            }
        }

        public static string[,] ExecuteSelectCommand(string sql, ref MySqlConnection databaseConnection)
        {
            try
            {
                if (databaseConnection != null && databaseConnection.State == ConnectionState.Closed)
                {
                    //funkcja ładująca dane z bazy pobrane poleceniem select i zwracająca je w formie tabeli
                    //W przypadku błędu zwróci null
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
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                //error
                Debugger.CreateLogMessage($"Błąd przy wykonywaniu komendy '{sql}', ({e.Message})");
                return null;
            }
            finally
            {
                if (databaseConnection != null && databaseConnection.State == ConnectionState.Open)
                {
                    databaseConnection.Close();
                }
            }

        }

        public static DataTable ExecuteSelectDataTableCommand(string sql, ref MySqlConnection databaseConnection)
        {
            try
            {
                //funkcja ładująca dane z bazy pobrane poleceniem select i zwracająca je w formie obiektu DataTable
                //W przypadku błędu zwróci null
                DataTable dataTable = new DataTable();


                MySqlCommand command = new MySqlCommand(sql, databaseConnection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

                databaseConnection.Open();
                dataAdapter.Fill(dataTable);
                databaseConnection.Close();


                return dataTable;
            }
            catch (Exception e)
            {
                //error
                Debugger.CreateLogMessage($"Błąd przy wykonywaniu komendy '{sql}', ({e.Message})");
                return null;
            }
            finally
            {
                if (databaseConnection != null && databaseConnection.State == ConnectionState.Open)
                {
                    databaseConnection.Close();
                }
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


        public static bool IsValidSqlDate(string dateStr)
        {
            //returns true if input string is valid date in YYYY-MM-DD format, else returns false
            DateTime date;
            bool isValid = DateTime.TryParseExact(dateStr, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
            return isValid;
        }

    }
}
