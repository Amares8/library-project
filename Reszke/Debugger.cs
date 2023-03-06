using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reszke
{
    internal class Debugger
    {
        public static void CreateLogMessage(string message)
        {
            //Metoda do tworzenia logów w pliku log.txt. W parametrze podajemy treść wiadomości, znacznik czasowy zostanie dodany automatycznie. 
            //Proszę o rozważne korzystanie z opcji tworzenia logów :)

            string path = "log.txt";
            DateTime timestamp = DateTime.Now;

            using (StreamWriter streamWriter = File.AppendText(path))
            {
                streamWriter.WriteLine(timestamp.ToString() + " - " + message);
            }
        }
    }
}
