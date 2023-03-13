using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reszke
{
    //Klasa reprezentująca pakiet językowy, zawierający wszystkie teksty wyświetlane użytkownikowi w danym języku
    public class LanguagePack
    {
        //kod języka w standardzie ISO 639-2
        public string ISOCode { get; set; }

        //nazwa języka po angielsku
        public string langName { get; set; }

        //nazwa języka w danym języku
        public string localLangName { get; set; }
        
        //nazwy dni tygodnia
        public string monday { get; set; }
        public string tuesday { get; set; }
        public string wednesday { get; set; }
        public string thursday { get; set; }
        public string friday { get; set; }
        public string saturday { get; set; }
        public string sunday { get; set; }



    }
}
