using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Reszke
{
    static class ConfigFileLoader
    {
        static public string LoadDBConnectionString(string configFile)
        {
            try
            {
                string jsonString = File.ReadAllText(configFile);
                using JsonDocument document = JsonDocument.Parse(jsonString);
                JsonElement root = document.RootElement;

                string server = root.GetProperty("server").ToString();
                string user = root.GetProperty("user").ToString();
                string password = root.GetProperty("password").ToString();
                string database = root.GetProperty("database").ToString();

                string connectionString = $"server={server};userid={user};password={password};database={database}";
                if (connectionString == "")
                {
                    Debugger.CreateLogMessage($"Błąd ładowania konfiguracji DB z pliku {configFile}");
                    return "";
                }
                else
                {
                    return connectionString;
                }
            }
            catch (Exception e)
            {
                Debugger.CreateLogMessage($"Błąd ładowania konfiguracji DB z pliku {configFile} ({e.Message})");
                return "";
            }
        }
    }
}
